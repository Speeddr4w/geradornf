using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorNF.Model
{
    class NF
    {
        public int NumeroNF { get; set; }
        public string NomeProdutos { get; set; }
        public int QuanVendida { get; set; }
        public string PrecoVendido { get; set; }
        public string PrecoTotal { get; set; }
        public string VendedorNome { get; set; }
        public string ClienteNome { get; set; }
        public string Regiao { get; set; }

        public NF(int numeronf, string nomeprodutos, int quanvendida, double precovendido, double precototal, string vendedornome, string clientenome, string regiao)
        {
            NumeroNF = numeronf;
            NomeProdutos = nomeprodutos;
            QuanVendida = quanvendida;
            PrecoVendido = precovendido.ToString("F");
            PrecoTotal = precototal.ToString("F");
            VendedorNome = vendedornome;
            ClienteNome = clientenome;
            Regiao = regiao;

        }

    }
}
