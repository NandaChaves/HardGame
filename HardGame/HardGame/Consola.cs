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
    public partial class Consola : Form
    {
        public Consola()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sqlproduto = "INSERT INTO PRODUTO(ProdutoID, Nome, Preco)" +
                              "VALUES (@id,@nome,@preco);" +
                              "INSERT INTO CONSOLA(ProdutoID, Geracao)" +
                              "VALUES (@id,@geracao)";

                try
                {
                    SqlCommand cmd = new SqlCommand(sqlproduto, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nome", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@preco", tbx_preco.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@geracao", tbx_geracao.Text.ToString()));

                    //executar a query
                    cmd.BeginExecuteNonQuery();

                    MessageBox.Show("A consola foi adicionado a base de dados!");

                    // fecha a ligação com o servidor SQL


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }

                con.Close();
            }
        }

        private void remover_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string sql = "DELETE FROM CONSOLA WHERE ProdutoID = " + tbx_id.Text.ToString() + ";"
                                + "DELETE FROM PRODUTO WHERE ProdutoID  = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Consola " + tbx_id.Text.ToString() + " apagada com sucesso!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {

                try //FuncionarioID, Nome, Tipo, Sexo, LojaID
                {
                    string sql = "UPDATE PRODUTO SET ProdutoID=@id, Nome=@nome, Preco=@preco" +
                                 " WHERE ProdutoID = " + tbx_id.Text.ToString() + ";" +
                                 "UPDATE CONSOLA SET ProdutoID=@id, Geracao=@geracao" +
                                 " WHERE ProdutoID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nome", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@preco", tbx_preco.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@geracao", tbx_geracao.Text.ToString()));

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Consola " + tbx_id.Text.ToString() + " atualizado com sucesso!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }
            }
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string sql = "SELECT * FROM (PRODUTO JOIN CONSOLA ON PRODUTO.ProdutoID = CONSOLA.ProdutoID) WHERE PRODUTO.ProdutoID = " + tbx_id.Text.ToString();

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbx_id.Text = dataReader.GetValue(0).ToString();
                    tbx_nome.Text = dataReader.GetValue(1).ToString();
                    tbx_preco.Text = dataReader.GetValue(2).ToString();
                    tbx_geracao.Text = dataReader.GetValue(4).ToString();

                    string output = "ID: " + dataReader.GetValue(0) + "\n" +
                                    "Nome: " + dataReader.GetValue(1) + "\n" +
                                    "Preco: " + dataReader.GetValue(2) + "\n" +
                                    "Genero: " + dataReader.GetValue(4) + "\n";

                    MessageBox.Show(output);
                }
                dataReader.Close();
                cmd.Dispose();
                con.Close();
            }
        }
    }
}
