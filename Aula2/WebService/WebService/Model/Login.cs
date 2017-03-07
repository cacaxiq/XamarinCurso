using System;
using WebService.Infra;

namespace WebService.Model
{
    public class Login
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
            set;
        }

        public string Client_Secret
        {
            get;
            set;
        }

        public string Grant_Type
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
    }
}
