using MySql.Data.MySqlClient;
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
    public partial class Form_Update : Form
    {
        public Form_Update()
        {
            InitializeComponent();
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Atualizar           
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=conce; password=''"); // Conexão - Server: porta / DB
            MySqlCommand sqlQuery = new MySqlCommand("UPDATE empresa SET nome = '" + textBox6.Text +
                                                     "', cpf = '" + textBox2.Text +
                                                     "', idade = '" + textBox3.Text +
                                                       "', sexo = '" + textBox4.Text +
                                                         "', email = '" + textBox7.Text +
                                                           "', senha = '" + textBox8.Text +
                                                             "', estado = '" + textBox10.Text +
                                                               "', cep = '" + textBox11.Text +
                                                     "' WHERE id = " + int.Parse(textBox1.Text), conexao); // Instr. SQL



            conexao.Open(); // Abrir Conexão

            var resp = MessageBox.Show("Identificador: " + "\n\nDeseja realmente alterar ? ", "Alterar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                sqlQuery.ExecuteNonQuery(); // Executa a instrução SQL; 
                MessageBox.Show("Dados alterados!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }
    }
}
