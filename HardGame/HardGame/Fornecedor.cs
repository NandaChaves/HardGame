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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sql = "INSERT INTO FORNECEDOR(FornecedorID, Nome, Telefone)" +
               "VALUES (@id,@nome,@telefone)";


                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nome", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@telefone", tbx_telefone.Text.ToString()));
                    //executar a query
                    cmd.BeginExecuteNonQuery();

                    MessageBox.Show("O Fornecedor foi adicionado a base de dados!");

                    // fecha a ligação com o servidor SQL
                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }
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
                    string sql = "DELETE FROM FORNECEDOR WHERE FornecedorID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Fornecedor " + tbx_id.Text.ToString() + " apagado com sucesso!");
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

                try
                {
                    string sql = "UPDATE FORNECEDOR SET FornecedorID=@id, Nome=@nome, Telefone=@telefone " +
                                 " WHERE FornecedorID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nome", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@telefone", tbx_telefone.Text.ToString()));

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Fornecedor " + tbx_id.Text.ToString() + " atualizado com sucesso!");
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
                string sql = "SELECT * FROM FORNECEDOR WHERE FornecedorID = " + tbx_id.Text.ToString();

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbx_id.Text = dataReader.GetValue(0).ToString();
                    tbx_nome.Text = dataReader.GetValue(1).ToString();
                    tbx_telefone.Text = dataReader.GetValue(2).ToString();

                    string output = "ID: " + dataReader.GetValue(0) + "\n" +
                                    "Nome: " + dataReader.GetValue(1) + "\n" +
                                    "Telefone: " + dataReader.GetValue(2) + "\n";

                    MessageBox.Show(output);
                }
                dataReader.Close();
                cmd.Dispose();
                con.Close();
            }
        }
    }
}
