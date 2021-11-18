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
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sql = "INSERT INTO LOJA(LojaID, Rua, Numero, Cidade)" +
               "VALUES (@id,@rua,@numero,@cidade)";


                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@rua", tbx_rua.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@numero", tbx_numero.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@cidade", tbx_cidade.Text.ToString()));
                    //executar a query
                    cmd.BeginExecuteNonQuery();

                    MessageBox.Show("A Loja foi adicionado a base de dados!");

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
                    string sql = "DELETE FROM LOJA WHERE LojaID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Loja " + tbx_id.Text.ToString() + " apagada com sucesso!");
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
                    string sql = "UPDATE LOJA SET LojaID=@id, Rua=@rua, Numero=@numero, Cidade=@cidade " +
                                 " WHERE LojaID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@rua", tbx_rua.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@numero", tbx_numero.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@cidade", tbx_cidade.Text.ToString()));

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Loja " + tbx_id.Text.ToString() + " atualizada com sucesso!");
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
                string sql = "SELECT * FROM LOJA WHERE LojaID = " + tbx_id.Text.ToString();

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbx_id.Text = dataReader.GetValue(0).ToString();
                    tbx_rua.Text = dataReader.GetValue(1).ToString();
                    tbx_numero.Text = dataReader.GetValue(2).ToString();
                    tbx_cidade.Text = dataReader.GetValue(3).ToString();

                    string output = "ID: " + dataReader.GetValue(0) + "\n" +
                                    "Rua: " + dataReader.GetValue(1) + "\n" +
                                    "Numero: " + dataReader.GetValue(2) + "\n" +
                                    "Cidade: " + dataReader.GetValue(3) + "\n";

                    MessageBox.Show(output);
                }
                dataReader.Close();
                cmd.Dispose();
                con.Close();
            }
        }
    }
}

