using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebService.Infra;

namespace WebService.Service.Base
{
    public class WebServiceBase<T> where T : class
    {
        private static string BaseUrl = "http://apresentacao.attps.com.br/AMD/HMP/Servico/";

        public string Token
        {
            get;
            set;
        }

        public WebServiceBase()
        {
            Token = (string)GlobalVariablesManager.GetApplicationCurrentProperty("token");
        }

        public WebServiceBase(string _token)
        {
            Token = _token;
        }

        public static async Task<T> RequestAsync(string URL, RequestType requestType = RequestType.Get, string requestBody = null, int triesNumber = 0, string contentType = "application/json")
        {

            T tReturn = null;

            for (int i = 0; i <= triesNumber; i++)
            {
                try
                {

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = new HttpResponseMessage();

                        client.BaseAddress = new Uri(BaseUrl);

                        client.DefaultRequestHeaders.Add("Authorization", (string)GlobalVariablesManager.GetApplicationCurrentProperty("token"));

                        HttpContent httpContent = new StringContent(requestBody, Encoding.UTF8, contentType);

                        switch (requestType)
                        {
                            case RequestType.Get:
                                response = await client.GetAsync(URL);
                                break;
                            case RequestType.Post:
                                response = await client.PostAsync(URL, httpContent);
                                break;
                            case RequestType.Put:
                                response = await client.PutAsync(URL, httpContent);
                                break;
                            case RequestType.Delete:
                                response = await client.DeleteAsync(URL);
                                break;
                            default:
                                break;
                        }

                        if (response.IsSuccessStatusCode)
                        {
                            string responseString = await response.Content.ReadAsStringAsync();

                            var objetoRetorno = JsonHelper<T>.JsonToObject(responseString);


                            tReturn = objetoRetorno;

                        }
                        else
                        {
                            if (response.StatusCode == System.Net.HttpStatusCode.RequestTimeout)
                            {
                                if (i == triesNumber)
                                    throw new Exception("Tempo limite atingido");
                            }
                            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                                throw new Exception("Serviço não encontrado");
                            else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                            {
                                if (i == triesNumber)
                                    throw new Exception("Serviço indisponível no momento");
                            }
                            else
                                throw new Exception("Falha no acesso!");
                        }
                    }

                }
                catch (JsonException x)
                {
                    throw x;
                }
                catch (Exception x)
                {
                    throw x;
                }
            }

            return tReturn;

        }
    }

    public enum RequestType
    {
        Get,
        Post,
        Put,
        Delete
    }
}
