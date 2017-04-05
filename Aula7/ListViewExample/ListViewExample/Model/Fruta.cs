using System;
using ListViewExample.Infra;

namespace ListViewExample.Model
{
    public class Fruta : EventChanged
    {
        public Fruta()
        {
        }

        public string NomeFruta
        {
            get;
            set;
        }

        public Estacao Estacao
        {
            get;
            set;
        }

        public string Cidade
        {
            get;
            set;
        }

    }

    public enum Estacao
    {
        Outono,
        Inverno,
        Primavera,
        Verão
    }
}
