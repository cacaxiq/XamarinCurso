using System;
using WebService.Infra;
using WebService.Model;
using WebService.Service.Base;

namespace WebService.Service
{
    public class LoginService
    {
        public bool Logar(Login login)
        {
            try
            {
                var autenticado = WebServiceBase<CurrentUser>.RequestAsync("Autenticacao/oauth2/token", Base.RequestType.Post, JsonHelper<Login>.ObjectToJson(login), 2, "application/x-www-form-urlencoded").Result;
                GlobalVariablesManager.SetApplicationCurrentProperty("token", "bearer " + autenticado.Access_Token);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
