using GeradorNF.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorNF.Control
{
    class DAONF
    {
        public static List<NF> listaNF = new List<NF>();
        public static List<NF> listaNFOrdenado = new List<NF>();

        public static void addNF(string nomeproduto, int quanvendida, double precounitario, string nomevendedor, string nomecliente, string regiao)
        {
            double precototal = precounitario * quanvendida;

            Random random = new Random();

            int numeronf = random.Next(1000000, 9999999);

            NF aux = listaNF.Find(x => x.NumeroNF == numeronf);

            while(aux != null)
            {
                random.Next(1000000, 9999999);
                numeronf = Convert.ToInt32(random);
                aux = listaNF.Find(x => x.NumeroNF == numeronf);
            }
            listaNF.Add(new NF(numeronf, nomeproduto, quanvendida, precounitario, precototal, nomevendedor, nomecliente, regiao));
            updatelistaordenada();
            ExportarNF();
        }

        public static void updatelistaordenada()
        {
            listaNFOrdenado = listaNF.OrderBy(x => x.NumeroNF).ToList();
        }

        public static void ImportarNF()
        {
            using (StreamReader r = new StreamReader(@"lista.json"))
            {
                string json = r.ReadToEnd();
                listaNF = JsonConvert.DeserializeObject<List<NF>>(json);
            }
        }


        public static void ExportarNF()
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(listaNF);
            System.IO.File.WriteAllText(@"lista.json", jsonString);
        }
        public static List<NF> FiltrarVendedor(string filtro) 
        {
            List<NF> filter = new List<NF>();
            foreach (NF notafis in listaNFOrdenado)
            {
                if (notafis.VendedorNome == filtro)
                {
                    filter.Add(notafis);
                }
            }
            return filter;
        }
        public static List<NF> FiltrarCliente(string filtro)
        {
            List<NF> filter = new List<NF>();
            foreach (NF notafis in listaNFOrdenado)
            {
                if (notafis.ClienteNome == filtro)
                {
                    filter.Add(notafis);
                }
            }
            MudarTotalCompra(filter);
            return filter;
        }
        public static void MudarTotalCompra(List<NF> mudar)
        {
            Double total = Convert.ToDouble(mudar.Sum(x => Convert.ToDouble(x.PrecoTotal)));
            MessageBox.Show($"R$ {total.ToString("F")}","Total Comprado");
            
            
        }

        public static String AcharRegiaoComMaisVendas()
        {
            List<NF> Norte = listaNF.Where(x => x.Regiao == "NORTE").ToList();
            List<NF> Nordeste = listaNF.Where(x => x.Regiao == "NORDESTE").ToList();
            List<NF> CentroOeste = listaNF.Where(x => x.Regiao == "CENTRO-OESTE").ToList();
            List<NF> Sudeste = listaNF.Where(x => x.Regiao == "SUDESTE").ToList();
            List<NF> Sul = listaNF.Where(x => x.Regiao == "SUL").ToList();

            List<double> listaTotalOrdenada = new List<double>();

            listaTotalOrdenada.Add(Norte.Sum(x => Convert.ToDouble(x.PrecoVendido)));
            listaTotalOrdenada.Add(Nordeste.Sum(x => Convert.ToDouble(x.PrecoVendido)));
            listaTotalOrdenada.Add(CentroOeste.Sum(x => Convert.ToDouble(x.PrecoVendido)));
            listaTotalOrdenada.Add(Sudeste.Sum(x => Convert.ToDouble(x.PrecoVendido)));
            listaTotalOrdenada.Add(Sul.Sum(x => Convert.ToDouble(x.PrecoVendido)));

            double maiorvalor = listaTotalOrdenada.Max();

            if (maiorvalor == Norte.Sum(x => Convert.ToDouble(x.PrecoVendido)))
            {
                return "NORTE";
            }
            if (maiorvalor == Nordeste.Sum(x => Convert.ToDouble(x.PrecoVendido)))
            {
                return "NORDESTE";
            }
            if (maiorvalor == CentroOeste.Sum(x => Convert.ToDouble(x.PrecoVendido)))
            {
                return "CENTRO-OESTE";
            }
            if (maiorvalor == Sudeste.Sum(x => Convert.ToDouble(x.PrecoVendido)))
            {
                return "SUDESTE";
            }
            if (maiorvalor == Sul.Sum(x => Convert.ToDouble(x.PrecoVendido)))
            {
                return "SUL";
            }
            return null;

        }

    }
}
