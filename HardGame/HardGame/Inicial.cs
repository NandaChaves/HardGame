using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardGame
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //CLIENTE
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }
        
        private void button2_Click(object sender, EventArgs e) //FUNCIONARIO
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
        }

        private void button3_Click(object sender, EventArgs e) //JOGO
        {
            Jogo jogo = new Jogo();
            jogo.Show();
        }

        private void button5_Click(object sender, EventArgs e) //FORNECEDOR
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Show();
        }

        private void button6_Click(object sender, EventArgs e) //LOJA
        {
            Loja loja = new Loja();
            loja.Show();
        }

        private void button8_Click(object sender, EventArgs e) //COMPRA
        {
            Comprar compra = new Comprar();
            compra.Show();
        }

        private void button9_Click(object sender, EventArgs e) //TEM
        {
            Tem tem = new Tem();
            tem.Show();
        }

        private void button7_Click(object sender, EventArgs e) //VENDER
        {
            Vender venda = new Vender();
            venda.Show();
        }

        private void button4_Click(object sender, EventArgs e) //CONSOLA
        {
            Consola consola = new Consola();
            consola.Show();
        }
    }
}
