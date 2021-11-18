using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardGame
{
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string sql = "SELECT FUNCIONARIO.Nome, CLIENTE.Primeiro, PRODUTO.Nome, VENDA.Quantidade, VENDA.DataCompra FROM (VENDA JOIN FUNCIONARIO ON VENDA.FuncionarioID = FUNCIONARIO.FuncionarioID JOIN CLIENTE ON VENDA.NIF = CLIENTE.NIF JOIN PRODUTO ON VENDA.ProdutoID = PRODUTO.ProdutoID)";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    String linha = dataReader.GetValue(0).ToString() + "\t\t" + dataReader.GetValue(1).ToString() + "\t\t" + dataReader.GetValue(2).ToString() + "\t\t" + dataReader.GetValue(3).ToString() + "\t\t" + dataReader.GetValue(4).ToString() + "\t\t";
                    listBox1.Items.Add(linha);
                }
                con.Close();

            }
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sql = "INSERT INTO VENDA(FuncionarioID, NIF, ProdutoID, Quantidade, DataCompra)" +
               "VALUES (@funcionario,@cliente,@produto,@quantidade,@datacompra)";


                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@funcionario", tbx_funcionario.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@cliente", tbx_cliente.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@produto", tbx_produto.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@quantidade", tbx_quantidade.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@datacompra", tbx_data.Text.ToString()));
                    //executar a query
                    cmd.BeginExecuteNonQuery();

                    MessageBox.Show("O Funcionario foi adicionado a base de dados!");

                    // fecha a ligação com o servidor SQL
                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }

                PopulateListBox();
            }
        }
    }
}
