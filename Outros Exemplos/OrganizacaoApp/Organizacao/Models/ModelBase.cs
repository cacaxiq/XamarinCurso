using System;
using Newtonsoft.Json;

namespace Organizacao.Models
{
    public class ModelBase : ObservableObject
    {
        string id = string.Empty;

        [JsonIgnore]
        public string Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }
    }
}
