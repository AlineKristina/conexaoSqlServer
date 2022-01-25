using conexaoSqlServer.Banco;
using conexaoSqlServer.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexaoSqlServer
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            ClienteBanco cliBanco = new ClienteBanco();
            int gravou;

            cli.nome = txt_Nome.Text;
            cli.email = txt_Email.Text;
            cli.endereco = txt_Endereco.Text;
            try
            {
                gravou = cliBanco.InserirCliente(cli);
                MessageBox.Show("Cliente cadastrado com sucesso", "Incluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nome.Clear();
                txt_Endereco.Clear();
                txt_Email.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar cliente\n" + ex.Message, "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            ClienteBanco cliBanco = new ClienteBanco();
            DataTable dadosClientes;
            DataRow dc;

            try
            {
                dc = cliBanco.localizarPorCodigo(Convert.ToInt32(txt_Codigo.Text)).Select()[0];
                if (!dc.IsNull(0))
                {

                    txt_Nome.Text = dc[1].ToString();
                    txt_Endereco.Text = dc[2].ToString();
                    txt_Email.Text = dc[3].ToString();

                }
                else
                {
                    MessageBox.Show("Cliente não localizado");
                }

            }
            catch (SystemException ex)
            {
                MessageBox.Show("WHAT", ex.Message);
            }


        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
