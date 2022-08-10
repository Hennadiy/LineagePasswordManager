using System;

namespace PasswordManager
{
    public class Credential
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string AccountName { get; set; }
        public bool IsDefault { get; set; }
    }
}
