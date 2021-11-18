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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sql = "INSERT INTO FUNCIONARIO(FuncionarioID, Nome, Tipo, Sexo, LojaID)" +
               "VALUES (@id,@nome,@tipo,@sexo,@lojaid)";


                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nome", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@tipo", tbx_tipo.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sexo", tbx_sexo.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@lojaid", tbx_loja.Text.ToString()));
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
                    string sql = "DELETE FROM FUNCIONARIO WHERE FuncionarioID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Funcionario " + tbx_id.Text.ToString() + " apagado com sucesso!");
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
                    string sql = "UPDATE FUNCIONARIO SET FuncionarioID=@id, Nome=@nome, Tipo=@tipo, Sexo=@sexo, LojaID=@loja " +
                                 " WHERE FuncionarioID = " + tbx_id.Text.ToString();

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@id", tbx_id.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@nome", tbx_nome.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@tipo", tbx_tipo.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sexo", tbx_sexo.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@loja", tbx_loja.Text.ToString()));

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Funcionario " + tbx_id.Text.ToString() + " atualizado com sucesso!");
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
                string sql = "SELECT * FROM FUNCIONARIO WHERE FuncionarioID = " + tbx_id.Text.ToString();

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbx_id.Text = dataReader.GetValue(0).ToString();
                    tbx_nome.Text = dataReader.GetValue(1).ToString();
                    tbx_tipo.Text = dataReader.GetValue(2).ToString();
                    tbx_sexo.Text = dataReader.GetValue(3).ToString();
                    tbx_loja.Text = dataReader.GetValue(4).ToString();

                    string output = "ID: " + dataReader.GetValue(0) + "\n" +
                                    "Nome: " + dataReader.GetValue(1) + "\n" +
                                    "Tipo: " + dataReader.GetValue(2) + "\n" +
                                    "Sexo: " + dataReader.GetValue(3) + "\n" +
                                    "Loja: " + dataReader.GetValue(4) + "\n";

                    MessageBox.Show(output);
                }
                dataReader.Close();
                cmd.Dispose();
                con.Close();
            }
        }
    }
}
