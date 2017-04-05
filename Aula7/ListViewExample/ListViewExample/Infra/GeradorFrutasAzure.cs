using System;
using System.Collections.ObjectModel;
using ListViewExample.Model;

namespace ListViewExample.Infra
{
    public static class GeradorFrutasAzure
    {

        public static string[] baseFrutas = { "maçã", "banana", "uva", "melão", "melancia", "abacate", "laranja", "mexerica", "pessego", "caju", "kiwi", "amora", "abacaxi", "manga", "ameixa", "pera", "goiaba", "morango", "acerola" };
        public static string[] baseCidades = { "Porto Alegre", "São Paulo", "Salvador", "Rio de Janeiro", "Macápa", "Manaus", "Cuiabá", "Natal", "Teresina", "Belém", "Campinas", "Belo Horizonte", "Betim" };

        public static void GerarListaFrutas(int qtdade)
        {
            Random random = new Random();
            Array estacoes = Enum.GetValues(typeof(Estacao));

            for (int i = 0; i < qtdade; i++)
            {
                var fruta = new FrutasAzure();

                fruta.NomeFruta = (string)baseFrutas.GetValue(random.Next(baseFrutas.Length));
                fruta.Estacao = (string)estacoes.GetValue(random.Next(estacoes.Length));
                fruta.Cidade = (string)baseCidades.GetValue(random.Next(baseCidades.Length));

                var service = new AzureService();

                service.AdicionarFrutas(fruta);
            }
        }

        public static async void GerarListaFrutas(ObservableCollection<FrutasAzure> lista)
        {
            lista.Clear();

            Random random = new Random();
            Array estacoes = Enum.GetValues(typeof(Estacao));

            for (int i = 0; i < 20; i++)
            {
                var fruta = new FrutasAzure();

                fruta.NomeFruta = (string)baseFrutas.GetValue(random.Next(baseFrutas.Length));
                fruta.Estacao = (string)estacoes.GetValue(random.Next(estacoes.Length));
                fruta.Cidade = (string)baseCidades.GetValue(random.Next(baseCidades.Length));

                lista.Add(fruta);
            }
        }
    }
}
