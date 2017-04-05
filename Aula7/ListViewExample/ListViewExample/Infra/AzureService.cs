using Microsoft.WindowsAzure.MobileServices;
using ListViewExample.Model;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ListViewExample.Infra
{
    public class AzureService
    {
        private IMobileServiceClient _client;
        private IMobileServiceTable<FrutasAzure> _table;
        private const string serviceUrl = "http://maratona-xamarin.azurewebsites.net/";

        public AzureService()
        {
            _client = new MobileServiceClient(serviceUrl);
            _table = _client.GetTable<FrutasAzure>();
        }

        public async Task<IEnumerable<FrutasAzure>> ObterFrutas()
        {
            var empty = new FrutasAzure[0];

            try
            {
                return await _table.ToEnumerableAsync();
            }
            catch (System.Exception ex)
            {
                return empty;
            }
        }

        public async void AdicionarFrutas(FrutasAzure frutas)
        {
            await _table.InsertAsync(frutas);
        }
    }
}
