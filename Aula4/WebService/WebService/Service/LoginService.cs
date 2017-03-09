using System;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using WebService.Infra;
using WebService.Model;

namespace WebService.Service
{
    public class LoginService
    {
        public async Task<bool> Logar(Login login)
        {
            try
            {
                var client = new RestClient("http://apresentacao.attps.com.br/AMD/HMP/Servico/Autenticacao/oauth2/token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("postman-token", "4ae78b2f-a51d-8c65-5ed3-fa83d9178d49");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("application/x-www-form-urlencoded", "Client_id=0DB58563-5073-47AF-BBDF-3BFF2971D808&client_secret=X924yEpQGPUZejLjVt67NmCRgwck8sqGrfANwze3dYS4TucFx9pb6BDXHs8sunXv&username=" + login.Username + "&password=" + login.Password + "&grant_type=password", ParameterType.RequestBody);
                var response = await client.ExecuteTaskAsync<RestResponse<CurrentUser>>(request);

                if (response.StatusDescription == "OK")
                {
                    CurrentUser currentUser = SimpleJson.DeserializeObject<CurrentUser>(response.Content);

                    GlobalVariablesManager.SetApplicationCurrentProperty("TOKEN", string.Format("{0} {1}", currentUser.Token_Type, currentUser.Access_Token));

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
