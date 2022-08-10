using PasswordManager.Models;
using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        private readonly JsonFileUtility _jsonFileUtility = new JsonFileUtility();
        private readonly ProcessUtility _processUtility = new ProcessUtility();
        private readonly string _settingsPath = @"./settings.json";
        private readonly string _credsPath = @"./creds.json";
        private readonly List<Process> _lineageWindows = new List<Process>();

        private Settings _settings;
        private List<Credential> _credentials = new List<Credential>();

        public MainForm()
        {
            _settings = new Settings { LineageWindowTitle = "Lineage" };

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOptions();
            RefreshLineageWindows();
            LoadCredentials();
            UpdateButtonsStates();
        }

        private void RefreshWindows_Click(object sender, EventArgs e)
        {
            RefreshLineageWindows();
            LoginButton.Enabled = false;
        }

        private void LoadOptions()
        {
            if (!File.Exists(_settingsPath))
            {
                _jsonFileUtility.SaveFile(_settingsPath, _settings);
            }
            else
            {
                _settings = _jsonFileUtility.ReadFile<Settings>(_settingsPath);
                PathTextBox.Text = _settings.LineagePath ?? string.Empty;
            }
        }

        private void RefreshLineageWindows()
        {
            WindowsListBox.Items.Clear();
            _lineageWindows.Clear();

            foreach (var item in _processUtility.GetProcesses(_settings.LineageWindowTitle))
            {
                WindowsListBox.Items.Add(item.MainWindowTitle + ", " + item.StartTime.ToString());
                _lineageWindows.Add(item);
            }
        }

        private void LoadCredentials()
        {
            CredentialsListBox.Items.Clear();
            _credentials.Clear();

            if (!File.Exists(_credsPath))
            {
                File.Create(_credsPath);
                return;
            }
            _credentials = _jsonFileUtility.ReadFile<List<Credential>>(_credsPath);
            if (_credentials == null)
            {
                _credentials = new List<Credential>();
            }

            foreach (var credential in _credentials)
            {
                CredentialsListBox.Items.Add(credential.AccountName);
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (WindowsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Lineage window");
                return;
            }
            if (_lineageWindows.Count == 0)
            {
                MessageBox.Show("Lineage window not found");
                return;
            }
            var handle = _lineageWindows[WindowsListBox.SelectedIndex].MainWindowHandle;
            if (handle == null)
            {
                MessageBox.Show("Lineage window not found");
                return;
            }
            _processUtility.InputCreds(handle, _credentials[CredentialsListBox.SelectedIndex]);
        }

        private void Credentials_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonsStates();
        }

        private void Windows_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonsStates();
        }

        private void UpdateButtonsStates()
        {
            LoginButton.Enabled = CredentialsListBox.SelectedIndex >= 0 && WindowsListBox.SelectedIndex >= 0;
            LaunchNewWindowbutton.Enabled = CredentialsListBox.SelectedIndex >= 0 && PathTextBox.Text.Length > 0;
            RemoveButton.Enabled = CredentialsListBox.SelectedIndex >= 0;
        }

        private void PathExe_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            PathTextBox.Text = fileDialog.FileName;
            _settings.LineagePath = fileDialog.FileName;

            _jsonFileUtility.SaveFile(_settingsPath, _settings);

            UpdateButtonsStates();
        }

        private void LaunchNewWindowAndLogin_Click(object sender, EventArgs e)
        {
            _processUtility.StartNewWindowAndLogin(PathTextBox.Text, _credentials[CredentialsListBox.SelectedIndex]);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTextBox.Text) ||
                string.IsNullOrEmpty(PasswordTextBox.Text) ||
                string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Login, Password or Description is empty.");
                return;
            }

            var cred = new Credential
            {
                AccountName = DescriptionTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                IsDefault = IsDefaultCheckBox.Checked
            };
            _credentials.Add(cred);
            CredentialsListBox.Items.Add(cred.AccountName);
            _jsonFileUtility.SaveFile(_credsPath, _credentials);

            DescriptionTextBox.Text = "";
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            IsDefaultCheckBox.Checked = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CredentialsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select credential.");
                return;
            }
            _credentials.RemoveAt(CredentialsListBox.SelectedIndex);
            CredentialsListBox.Items.RemoveAt(CredentialsListBox.SelectedIndex);
            _jsonFileUtility.SaveFile(_credsPath, _credentials);
        }

        private void RunDefaultCredentialsButton_Click(object sender, EventArgs e)
        {
            if (_credentials.Where(x => x.IsDefault).Count() == 0)
            {
                MessageBox.Show("Please enter at least one default credential.");
                return;
            }
            if (string.IsNullOrEmpty(_settings.LineagePath))
            {
                MessageBox.Show("Please specify path to Lineage2 exe file.");
                return;
            }

            foreach (var credential in _credentials.Where(x => x.IsDefault))
            {
                _processUtility.StartNewWindowAndLogin(_settings.LineagePath, credential);
            }
        }
    }
}
