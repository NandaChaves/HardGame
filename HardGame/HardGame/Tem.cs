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
    public partial class Tem : Form
    {
        public Tem()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FQBHMD6\\SQLEXPRESS;Initial Catalog=HardGame;Integrated Security=True");
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {   //código sql para inserir dados
                string sqlproduto = "INSERT INTO TEM(LojaID, NIF)" +
                              "VALUES (@loja,@nif)";

                try
                {
                    SqlCommand cmd = new SqlCommand(sqlproduto, con);
                    //vai buscar os valores a introduzir na base de dados às textboxes criadas no formulário
                    cmd.Parameters.Add(new SqlParameter("@nif", tbx_nif.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@loja", tbx_loja.Text.ToString()));


                    //executar a query
                    cmd.BeginExecuteNonQuery();

                    MessageBox.Show("O cliente foi adicionado a Loja!");

                    // fecha a ligação com o servidor SQL


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro! " + ex);
                }

                con.Close();
            }
        }
    }
}
