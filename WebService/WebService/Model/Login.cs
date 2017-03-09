using WebService.Infra;

namespace WebService.Model
{
    public class Login : ObservedClass
    {
        public Login()
        {
            Client_ID = GlobalVariables.ClientIDValue;
            Client_Secret = GlobalVariables.ClientSecretValue;
            Grant_Type = GlobalVariables.GrantTypeValue;
        }

        public string Client_ID
        {
            get;
        }

        public string Client_Secret
        {
            get;
        }

        public string Grant_Type
        {
            get;
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }
    }
}
