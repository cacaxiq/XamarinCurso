using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListViewExample.Model
{
    public class FrutasGroup : ObservableCollection<Fruta>
    {
        public string Tipo { get; set; }
        public string Cor { get; set; }
    }
}
