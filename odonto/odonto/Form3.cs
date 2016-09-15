using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odonto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                odontoDataSetTableAdapters.pacientesTableAdapter paciente = new odontoDataSetTableAdapters.pacientesTableAdapter();
                paciente.InsertQuery(txtNome.Text,txt_cpf.Text,txtTelefone.Text, txtIdade.Text, txtNotas.Text);
                MessageBox.Show("Cadastro realizado com Sucesso");
                Close();
            }
            catch
            {
                MessageBox.Show("Problema do cadastro!");
                Close();
            }
        
        }
    }
}
