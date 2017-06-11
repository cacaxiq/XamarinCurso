using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Organizacao.Models;
using Plugin.Connectivity;

namespace Organizacao.Services
   
{
    public class CloudDataStore<T> : IDataStore<T>   
        where T : ModelBase, new()
    {
        HttpClient client;
        IEnumerable<T> Ts;
        string NomeEntidade;

        public CloudDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.BackendUrl}/api/{NomeEntidade}/");

            Ts = new List<T>();
            var tipoEntidade = typeof(T);
            NomeEntidade = nameof(tipoEntidade);
        }

        public async Task<IEnumerable<T>> GetsAsync(bool forceRefresh = false)
        {
            if (forceRefresh && CrossConnectivity.Current.IsConnected)
            {
                var json = await client.GetStringAsync(string.Empty);
                Ts = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<T>>(json));
            }

            return Ts;
        }

        public async Task<T> GetAsync(string id)
        {
            if (id != null && CrossConnectivity.Current.IsConnected)
            {
                var json = await client.GetStringAsync($"{id}");
                Ts = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<T>>(json));
            }

            return null;
        }

        public async Task<bool> AddAsync(T entity)
        {
            if (entity == null || !CrossConnectivity.Current.IsConnected)
                return false;

            var serializedT = JsonConvert.SerializeObject(entity);

            var response = await client.PostAsync(string.Empty, new StringContent(serializedT, Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode ? true : false;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            if (entity == null || entity.Id == null || !CrossConnectivity.Current.IsConnected)
                return false;

            var serializedT = JsonConvert.SerializeObject(entity);
            var buffer = System.Text.Encoding.UTF8.GetBytes(serializedT);
            var byteContent = new ByteArrayContent(buffer);

            var response = await client.PutAsync(new Uri($"{entity.Id}"), byteContent);

            return response.IsSuccessStatusCode ? true : false;
        }
        

        public async Task<bool> DeleteAsync(string id)
        {
            if (string.IsNullOrEmpty(id) && !CrossConnectivity.Current.IsConnected)
                return false;

            var response = await client.DeleteAsync($"{id}");

            return response.IsSuccessStatusCode ? true : false;
        }
    }
}
