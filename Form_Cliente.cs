using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concessionaria
{
    public partial class Form_Cliente : Form
    {
        Cadastro_Cliente cadastroClie = new Cadastro_Cliente();
        Form_consulta consulta = new Form_consulta();
        Form_Update upp = new  Form_Update();
        Form_Delet dell = new Form_Delet();
        public Form_Cliente()
        {
            InitializeComponent();
        }

        private void Form_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abre tela cadastro cliente
            cadastroClie.Show();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // abre tela consulta de dados
            consulta.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //abre tela atualizar
           upp.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tela deletar
           dell.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
