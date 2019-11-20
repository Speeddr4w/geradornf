using GeradorNF.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAONF.updatelistaordenada();
            lblMaiorRegiao.Text = DAONF.AcharRegiaoComMaisVendas();
            dataGridView1.DataSource = DAONF.listaNFOrdenado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeproduto = txtboxNomeProduto.Text;
            int quanvendida = Convert.ToInt32(txtboxQuanVendida.Value);
            double precounitario = Convert.ToDouble(txtboxPrecoUnitario.Value);
            string nomevendedor = txtboxVendedorNome.Text;
            string nomecliente = txtboxClienteNome.Text;
            string regiao = comboxRegiao.Text;

            DAONF.addNF(nomeproduto, quanvendida, precounitario, nomevendedor, nomecliente, regiao);
            dataGridView1.DataSource = DAONF.listaNFOrdenado;
            lblMaiorRegiao.Text = DAONF.AcharRegiaoComMaisVendas();

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            string filtro = Convert.ToString(txtboxFiltroVendedor.Text);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = DAONF.FiltrarVendedor(filtro);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filtro = Convert.ToString(txtboxFiltroCliente.Text);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = DAONF.FiltrarCliente(filtro);
        }
    }
}
