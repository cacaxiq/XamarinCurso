using System;

using Newtonsoft.Json;

namespace Organizacao.Models
{
    public class Item : ModelBase 
    {
        string text = string.Empty;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
    }
}
