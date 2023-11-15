using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=mac;uid=root;pwd=etec");
            conectar.Open();
            MySqlCommand cadastrar = new MySqlCommand("INSERT INTO tb_produto (nome_prod, val_prod) values ('" + txtProduto.Text + "'," + txtValor.Text + ");", conectar);
            cadastrar.ExecuteNonQuery();

            MessageBox.Show(" Cadastro realizado com sucesso!!! ");
            
            txtProduto.Text = "";
            txtValor.Text = "";

        }
    }
}
