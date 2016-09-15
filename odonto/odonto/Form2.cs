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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            String dataCompleta = monthCalendar1.SelectionRange.Start.ToString();
            String data = "";
            for (int i = 0; i < 10; i++)
            {
                data += dataCompleta[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String horario = txtHora.Text + txtMinuto.Text;
            Agendamento p = new Agendamento();
            p.Convenio = cbConvenio.Text;
            p.Data = txtData.Text;
            p.Motivo = cbMotivo.Text;
            p.Notas = rtNotas.Text;
            p.Status = cbStatus.Text;
            p.Horario = horario;
            p.Paciente = cbPaciente.Text;
            p.Valor = txtValor.Text;
            

            cbConvenio.Text = "";
            cbMotivo.Text = "";
            rtNotas.Text = "";
            cbStatus.Text = "";
            txtHora.Text = "";
            txtMinuto.Text = "";
            cbPaciente.Text = "";
            txtValor.Text = "";

            MessageBox.Show("Atualização Feita com sucesso!");
        }
    }
}
