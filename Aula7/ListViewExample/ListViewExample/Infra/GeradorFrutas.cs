using System;
using System.Collections.ObjectModel;
using ListViewExample.Model;

namespace ListViewExample.Infra
{
    public static class GeradorFrutas
    {
        public static string[] baseFrutas = { "maçã", "banana", "uva", "melão", "melancia", "abacate", "laranja", "mexerica", "pessego", "caju", "kiwi", "amora", "abacaxi", "manga", "ameixa", "pera", "goiaba", "morango", "acerola" };
        public static string[] baseCidades = { "Porto Alegre", "São Paulo", "Salvador", "Rio de Janeiro", "Macápa", "Manaus", "Cuiabá", "Natal", "Teresina", "Belém", "Campinas", "Belo Horizonte", "Betim" };
        public static string[] baseTipo = { "Doce", "Azeda", "Amarga" };
        public static string[] baseCor = { "Amarela", "Verde", "Vermelha" };

        public static ObservableCollection<Fruta> GerarListaFrutas(int qtdade)
        {
            var lista = new ObservableCollection<Fruta>();

            Random random = new Random();
            Array estacoes = Enum.GetValues(typeof(Estacao));

            for (int i = 0; i < qtdade; i++)
            {
                var fruta = new Fruta();

                fruta.NomeFruta = (string)baseFrutas.GetValue(random.Next(baseFrutas.Length));
                fruta.Estacao = (Estacao)estacoes.GetValue(random.Next(estacoes.Length));
                fruta.Cidade = (string)baseCidades.GetValue(random.Next(baseCidades.Length));

                lista.Add(fruta);
            }

            return lista;
        }

        public static ObservableCollection<FrutasGroup> GerarListaFrutasGroup(int qtdade)
        {
            var lista = new ObservableCollection<FrutasGroup>();

            Random random = new Random();
            Array estacoes = Enum.GetValues(typeof(Estacao));

            for (int i = 0; i < baseTipo.Length; i++)
            {
                var frutasGroup = new FrutasGroup();

                frutasGroup.Tipo = baseTipo[i];
                frutasGroup.Cor = baseCor[i];

                GerarListaFrutas(frutasGroup);

                lista.Add(frutasGroup);
            }

            return lista;
        }

        public static void GerarListaFrutas(ObservableCollection<Fruta> lista)
        {
            lista.Clear();

            Random random = new Random();
            Array estacoes = Enum.GetValues(typeof(Estacao));

            for (int i = 0; i < 10; i++)
            {
                var fruta = new Fruta();

                fruta.NomeFruta = (string)baseFrutas.GetValue(random.Next(baseFrutas.Length));
                fruta.Estacao = (Estacao)estacoes.GetValue(random.Next(estacoes.Length));
                fruta.Cidade = (string)baseCidades.GetValue(random.Next(baseCidades.Length));

                lista.Add(fruta);
            }
        }
    }
}
