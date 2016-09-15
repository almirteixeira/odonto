namespace odonto
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.rtNotas = new System.Windows.Forms.RichTextBox();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.lbNotas = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Horário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = ":";
            // 
            // txtMinuto
            // 
            this.txtMinuto.Location = new System.Drawing.Point(243, 203);
            this.txtMinuto.MaxLength = 2;
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(27, 20);
            this.txtMinuto.TabIndex = 36;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(198, 203);
            this.txtHora.MaxLength = 2;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(28, 20);
            this.txtHora.TabIndex = 35;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Marcado",
            "Atendido",
            "Aguardando",
            "Não compareceu"});
            this.cbStatus.Location = new System.Drawing.Point(198, 246);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 34;
            // 
            // rtNotas
            // 
            this.rtNotas.Location = new System.Drawing.Point(46, 340);
            this.rtNotas.Name = "rtNotas";
            this.rtNotas.Size = new System.Drawing.Size(131, 69);
            this.rtNotas.TabIndex = 33;
            this.rtNotas.Text = "";
            // 
            // cbConvenio
            // 
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(198, 340);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(121, 21);
            this.cbConvenio.TabIndex = 32;
            // 
            // lbNotas
            // 
            this.lbNotas.AutoSize = true;
            this.lbNotas.Location = new System.Drawing.Point(46, 324);
            this.lbNotas.Name = "lbNotas";
            this.lbNotas.Size = new System.Drawing.Size(35, 13);
            this.lbNotas.TabIndex = 31;
            this.lbNotas.Text = "Notas";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(195, 373);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 30;
            this.lbValor.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Convênio";
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(49, 286);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(270, 21);
            this.cbPaciente.TabIndex = 28;
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Location = new System.Drawing.Point(46, 270);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(95, 13);
            this.lbPaciente.TabIndex = 27;
            this.lbPaciente.Text = "Nome do Paciente";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(220, 389);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(78, 20);
            this.txtValor.TabIndex = 26;
            this.txtValor.Text = "0,00";
            // 
            // cbMotivo
            // 
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Items.AddRange(new object[] {
            "Consulta",
            "Resultado",
            "Revisão",
            "Exame",
            "Outro"});
            this.cbMotivo.Location = new System.Drawing.Point(49, 246);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(100, 21);
            this.cbMotivo.TabIndex = 25;
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.Location = new System.Drawing.Point(46, 230);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(39, 13);
            this.lbMotivo.TabIndex = 24;
            this.lbMotivo.Text = "Motivo";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(46, 189);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 23;
            this.lbData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(49, 203);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 22;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(49, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMinuto);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.rtNotas);
            this.Controls.Add(this.cbConvenio);
            this.Controls.Add(this.lbNotas);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.lbMotivo);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form2";
            this.Text = "Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinuto;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.RichTextBox rtNotas;
        private System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label lbNotas;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}