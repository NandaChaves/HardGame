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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adicionar_Click(object sender, EventArgs e) //Criar novo cliente
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sql = "INSERT INTO CLIENTE(NIF, Primeiro, Sobrenome)" +
               "VALUES (@nif,@primeiro,@sobrenome)";


                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@nif", tbx_nif.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@primeiro", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sobrenome", tbx_sobrenome.Text.ToString()));
                    //executar a query
                    cmd.BeginExecuteNonQuery();

                    MessageBox.Show("O Cliente foi adicionado a base de dados!");

                    // fecha a ligação com o servidor SQL
                    con.Close();

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
                string sql = "SELECT * FROM CLIENTE WHERE nif = " + tbx_nif.Text.ToString();

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbx_nif.Text = dataReader.GetValue(0).ToString();
                    tbx_nome.Text = dataReader.GetValue(1).ToString();
                    tbx_sobrenome.Text = dataReader.GetValue(2).ToString();

                    string output = "NIF: " + dataReader.GetValue(0) + "\n" +
                                    "Nome: " + dataReader.GetValue(1) + "\n" +
                                    "Sobrenome: " + dataReader.GetValue(2) + "\n";

                    MessageBox.Show(output);
                }
                dataReader.Close();
                cmd.Dispose();
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
                    string sql = "DELETE FROM CLIENTE WHERE NIF = " + tbx_nif.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Cliente " + tbx_nif.Text.ToString() + " apagado com sucesso!");
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
                    string sql = "UPDATE CLIENTE SET NIF=@nif, Primeiro=@primeiro, Sobrenome=@sobrenome " +
                                 " WHERE NIF = " + tbx_nif.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@nif", tbx_nif.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@primeiro", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sobrenome", tbx_sobrenome.Text.ToString()));

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Cliente " + tbx_nif.Text.ToString() + " atualizado com sucesso!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }
            }

        }
    }
}
