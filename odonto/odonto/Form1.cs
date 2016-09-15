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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odontoDataSet.pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.odontoDataSet.pacientes);

        }


        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Blue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)20.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {   /*
            listView1.Items.Clear();
           
            txtData.Text = data;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Data == txtData.Text)
                {
                    ListViewItem itm;
                    string[] arr = new string[4];
                    arr[0] = lista[i].Horario;
                    arr[1] = lista[i].Paciente;
                    arr[2] = lista[i].Motivo;
                    arr[3] = lista[i].Status;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }

            }
            */
        }

              
        

        /*

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
            lista.Add(p);
                    
            cbConvenio.Text="";
            cbMotivo.Text="";
            rtNotas.Text="";
            cbStatus.Text="";
            txtHora.Text = "";
            txtMinuto.Text = "";
            cbPaciente.Text="";
            txtValor.Text="";

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Data == txtData.Text)
                {
                    ListViewItem itm;
                    string[] arr = new string[4];
                    arr[0] = lista[i].Horario;
                    arr[1] = lista[i].Paciente;
                    arr[2] = lista[i].Motivo;
                    arr[3] = lista[i].Status;
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }

            }
            */
        

          
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 Atualizar = new Form4(comboBox1.SelectedValue.ToString());
            Atualizar.Show();
            



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 Cadastrar = new Form3();
            Cadastrar.Show();
            comboBox1.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 Marcacao = new Form2();
            Marcacao.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                   

            /*SqlConnection sql1 = new SqlConnection("Data Source=ALMIR-PC\\SQLEXPRESS;Initial Catalog=odonto;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT nome, id FROM odonto.dbo.pacientes";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sql1;
            sql1.Open();
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nome", typeof(string));
            dt.Columns.Add("id", typeof(int));
            dt.Load(reader);
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = dt;
            sql1.Close();
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sql1 = new SqlConnection("Data Source=ALMIR-PC\\SQLEXPRESS;Initial Catalog=odonto;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT idade, telefone, cpf FROM odonto.dbo.pacientes WHERE id =" + comboBox1.SelectedValue.ToString();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sql1;
            sql1.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                label4.Text = comboBox1.Text;
                label5.Text = reader[0].ToString();
                label8.Text = reader[1].ToString();
                label9.Text = reader[2].ToString();
            }
            catch
            {
                MessageBox.Show("Não encontrado!");
            }

            sql1.Close();

            listView2.Items.Clear();

            SqlConnection sql2 = new SqlConnection("Data Source=ALMIR-PC\\SQLEXPRESS;Initial Catalog=odonto;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader reader2;
            cmd2.CommandText = "SELECT data, motivo, valor FROM odonto.dbo.marcacao WHERE idpaciente =" + comboBox1.SelectedValue.ToString();
            cmd2.CommandType = CommandType.Text;
            cmd2.Connection = sql2;
            sql2.Open();
            reader2 = cmd2.ExecuteReader();
            
            while (reader2.Read()) {
                ListViewItem itm;
                string[] arr = new string[3];
                arr[0] = reader2[0].ToString();
                arr[1] = reader2[1].ToString();
                arr[2] = reader2[2].ToString();
               
                itm = new ListViewItem(arr);
                listView2.Items.Add(itm);
                /*  ou ListViewItem itm = new ListViewItem();
                  itm.SubItems.Add(reader2[0].ToString());
                  itm.SubItems.Add(reader2[1].ToString());
                  itm.SubItems.Add(reader2[2].ToString());
                  listView2.Items.Add(itm);*/
            }
            sql2.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string data = "";
           string datacomhora =  monthCalendar1.SelectionRange.Start.ToString();
            for(int i=0; i<10; i++)
            {
                data += datacomhora[i];

            }

            SqlConnection sql3 = new SqlConnection("Data Source=ALMIR-PC\\SQLEXPRESS;Initial Catalog=odonto;Integrated Security=True");
            SqlCommand cmd3 = new SqlCommand();
            SqlDataReader reader3;
            cmd3.CommandText = "SELECT id, horario, paciente, motivo, status FROM odonto.dbo.marcacao WHERE data =" + data;
            cmd3.CommandType = CommandType.Text;
            cmd3.Connection = sql3;
            sql3.Open();
            reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                ListViewItem itm2;
                string[] arr = new string[5];
                arr[0] = reader3[0].ToString();
                arr[1] = reader3[1].ToString();
                arr[2] = reader3[2].ToString();
                arr[3] = reader3[2].ToString();
                arr[4] = reader3[2].ToString();

                itm2 = new ListViewItem(arr);
                listView1.Items.Add(itm2);
                /*  ou ListViewItem itm = new ListViewItem();
                  itm.SubItems.Add(reader2[0].ToString());
                  itm.SubItems.Add(reader2[1].ToString());
                  itm.SubItems.Add(reader2[2].ToString());
                  listView2.Items.Add(itm);*/
            }
            sql3.Close();

        }
    }
}
