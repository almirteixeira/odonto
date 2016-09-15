using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace odonto
{
    public partial class Form4 : Form
    {
        public Form4(string id)
        {
            InitializeComponent();
            SqlConnection sql1 = new SqlConnection("Data Source=ALMIR-PC\\SQLEXPRESS;Initial Catalog=odonto;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT nome, cpf, idade, telefone, notas FROM odonto.dbo.pacientes WHERE id =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sql1;
            sql1.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                textBox1.Text = reader[0].ToString();
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                textBox4.Text = reader[3].ToString();
                richTextBox1.Text = reader[4].ToString();
            }
            catch
            {
                MessageBox.Show("Não encontrado!");
            }

            sql1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
