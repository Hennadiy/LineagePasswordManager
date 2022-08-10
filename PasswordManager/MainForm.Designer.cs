namespace PasswordManager
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WindowsListBox = new System.Windows.Forms.ListBox();
            this.RefreshWindowsButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CredentialsListBox = new System.Windows.Forms.ListBox();
            this.LaunchNewWindowbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathExeButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RunAllButton = new System.Windows.Forms.Button();
            this.IsDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credentials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lineage window";
            // 
            // WindowsListBox
            // 
            this.WindowsListBox.FormattingEnabled = true;
            this.WindowsListBox.ItemHeight = 20;
            this.WindowsListBox.Location = new System.Drawing.Point(612, 224);
            this.WindowsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WindowsListBox.Name = "WindowsListBox";
            this.WindowsListBox.Size = new System.Drawing.Size(390, 284);
            this.WindowsListBox.TabIndex = 4;
            this.WindowsListBox.SelectedIndexChanged += new System.EventHandler(this.Windows_SelectedIndexChanged);
            // 
            // RefreshWindowsButton
            // 
            this.RefreshWindowsButton.Location = new System.Drawing.Point(890, 516);
            this.RefreshWindowsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshWindowsButton.Name = "RefreshWindowsButton";
            this.RefreshWindowsButton.Size = new System.Drawing.Size(112, 35);
            this.RefreshWindowsButton.TabIndex = 5;
            this.RefreshWindowsButton.Text = "Refresh";
            this.RefreshWindowsButton.UseVisualStyleBackColor = true;
            this.RefreshWindowsButton.Click += new System.EventHandler(this.RefreshWindows_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Enabled = false;
            this.LoginButton.Location = new System.Drawing.Point(882, 179);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 35);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // CredentialsListBox
            // 
            this.CredentialsListBox.FormattingEnabled = true;
            this.CredentialsListBox.ItemHeight = 20;
            this.CredentialsListBox.Location = new System.Drawing.Point(18, 224);
            this.CredentialsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CredentialsListBox.Name = "CredentialsListBox";
            this.CredentialsListBox.Size = new System.Drawing.Size(578, 284);
            this.CredentialsListBox.TabIndex = 7;
            this.CredentialsListBox.SelectedIndexChanged += new System.EventHandler(this.Credentials_SelectedIndexChanged);
            // 
            // LaunchNewWindowbutton
            // 
            this.LaunchNewWindowbutton.Enabled = false;
            this.LaunchNewWindowbutton.Location = new System.Drawing.Point(326, 179);
            this.LaunchNewWindowbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LaunchNewWindowbutton.Name = "LaunchNewWindowbutton";
            this.LaunchNewWindowbutton.Size = new System.Drawing.Size(270, 35);
            this.LaunchNewWindowbutton.TabIndex = 9;
            this.LaunchNewWindowbutton.Text = "Launch new window and login";
            this.LaunchNewWindowbutton.UseVisualStyleBackColor = true;
            this.LaunchNewWindowbutton.Click += new System.EventHandler(this.LaunchNewWindowAndLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lineage path:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathTextBox.Location = new System.Drawing.Point(130, 18);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(805, 26);
            this.PathTextBox.TabIndex = 11;
            // 
            // PathExeButton
            // 
            this.PathExeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathExeButton.Location = new System.Drawing.Point(946, 15);
            this.PathExeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathExeButton.Name = "PathExeButton";
            this.PathExeButton.Size = new System.Drawing.Size(48, 35);
            this.PathExeButton.TabIndex = 12;
            this.PathExeButton.Text = "...";
            this.PathExeButton.UseVisualStyleBackColor = true;
            this.PathExeButton.Click += new System.EventHandler(this.PathExe_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(12, 95);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(200, 26);
            this.LoginTextBox.TabIndex = 13;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(256, 95);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 26);
            this.PasswordTextBox.TabIndex = 14;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(499, 95);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(200, 26);
            this.DescriptionTextBox.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(882, 91);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 35);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(18, 72);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(48, 20);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(256, 71);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(499, 71);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.DescriptionLabel.TabIndex = 19;
            this.DescriptionLabel.Text = "Description";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(484, 516);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(112, 35);
            this.RemoveButton.TabIndex = 20;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RunAllButton
            // 
            this.RunAllButton.Location = new System.Drawing.Point(22, 516);
            this.RunAllButton.Name = "RunAllButton";
            this.RunAllButton.Size = new System.Drawing.Size(112, 35);
            this.RunAllButton.TabIndex = 21;
            this.RunAllButton.Text = "Run All";
            this.RunAllButton.UseVisualStyleBackColor = true;
            this.RunAllButton.Click += new System.EventHandler(this.RunAllButton_Click);
            // 
            // IsDefaultCheckBox
            // 
            this.IsDefaultCheckBox.AutoSize = true;
            this.IsDefaultCheckBox.Location = new System.Drawing.Point(719, 96);
            this.IsDefaultCheckBox.Name = "IsDefaultCheckBox";
            this.IsDefaultCheckBox.Size = new System.Drawing.Size(104, 24);
            this.IsDefaultCheckBox.TabIndex = 22;
            this.IsDefaultCheckBox.Text = "Is Default";
            this.IsDefaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 567);
            this.Controls.Add(this.IsDefaultCheckBox);
            this.Controls.Add(this.RunAllButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PathExeButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LaunchNewWindowbutton);
            this.Controls.Add(this.CredentialsListBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RefreshWindowsButton);
            this.Controls.Add(this.WindowsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "PasswordManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox WindowsListBox;
        private System.Windows.Forms.Button RefreshWindowsButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ListBox CredentialsListBox;
        private System.Windows.Forms.Button LaunchNewWindowbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button PathExeButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button RunAllButton;
        private System.Windows.Forms.CheckBox IsDefaultCheckBox;
    }
}

