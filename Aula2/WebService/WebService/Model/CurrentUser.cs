using System;
namespace WebService.Model
{
    public class CurrentUser
    {
        public CurrentUser()
        {
        }
        public string Access_Token
        {
            get;
            set;
        }
        public string Token_Type
        {
            get;
            set;
        }
        public string Expires_In
        {
            get;
            set;
        }
    }
}
