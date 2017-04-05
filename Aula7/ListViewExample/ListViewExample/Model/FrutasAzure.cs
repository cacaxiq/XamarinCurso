using System;
using ListViewExample.Infra;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace ListViewExample.Model
{
    [DataTable("Frutas")]
    public class FrutasAzure : EventChanged
    {
        [JsonProperty("Id")]
        public string id
        {
            get;
            set;
        }

        [JsonProperty("Nome")]
        public string NomeFruta
        {
            get;
            set;
        }

        [JsonProperty("Estacao")]
        public string Estacao
        {
            get;
            set;
        }

        [JsonProperty("CidadeOrigem")]
        public string Cidade
        {
            get;
            set;
        }

        [Version]
        public string Version
        {
            get;
            set;
        }
    }
}
