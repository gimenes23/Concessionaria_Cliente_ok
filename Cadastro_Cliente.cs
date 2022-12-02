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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace Concessionaria
{
    public partial class Cadastro_Cliente : Form
    {
        Class_Cliente client = new Class_Cliente();
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //informações textBox
            client.setId(int.Parse(textBox1.Text));
            client.setCpf(textBox2.Text);
            client.setIdade(textBox3.Text);
            client.setSexo(textBox4.Text);
            client.setNomecompleto(textBox6.Text);
            client.setEmail(textBox7.Text);
            client.setSenha(textBox8.Text);
            client.setEstado(textBox10.Text);
            client.setCeP(textBox11.Text);



            //Conexao com Db para enviar as informações 
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=conce; password=''");
            MySqlCommand sqlQuery = new MySqlCommand($"INSERT INTO empresa VALUE ('{client.getId()}','{client.getNomecompleto()}','{client.getCpf()}'," +
                                                        $"'{client.getIdade()}','{client.getSexo()}','{client.getEmail()}','{client.getSenha()}','{client.getEstado()}','{client.getCep()}') ", conexao);

            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();
                MessageBox.Show("Dados enviado com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR Atençao!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fecha conexao
                conexao.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
