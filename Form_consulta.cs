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
    public partial class Form_consulta : Form
    {
        public Form_consulta()
        {
            InitializeComponent();
        }

        private void Form_consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Exibi o dataGrid
            dataGridView1.Rows.Clear();



            // Conexao com o banco de dados
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=conce; password=''");
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM empresa", conexao);


            try
            {
                conexao.Open(); //Abre conexao
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();


                while (dataReader.Read())
                {
                    object[] registro = new object[dataReader.FieldCount];


                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));

                        }
                    }

                    // Busca o registro
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        registro[i] = dataReader.GetValue(i); //mostra o registro                  
                    }
                    dataGridView1.Rows.Add(registro); // Adiciona uma linha
                }
            }
            catch (Exception ex)
            {
                // caso tenha um erro
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fecha conexao com o banco de dados
                conexao.Close();
            }

        }
    }
}
