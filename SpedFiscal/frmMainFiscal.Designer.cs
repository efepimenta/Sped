namespace SpedFiscal
{
    partial class frmMainFiscal
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.edtFinalidade = new System.Windows.Forms.TextBox();
            this.edtCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Perfil = new System.Windows.Forms.Label();
            this.edtPerfil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtAtividade = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(7, 341);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(36, 13);
            this.lblSaida.TabIndex = 1;
            this.lblSaida.Text = "Saída";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(410, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Validar?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // edtFinalidade
            // 
            this.edtFinalidade.Location = new System.Drawing.Point(12, 25);
            this.edtFinalidade.Name = "edtFinalidade";
            this.edtFinalidade.Size = new System.Drawing.Size(124, 20);
            this.edtFinalidade.TabIndex = 3;
            this.edtFinalidade.Text = "1";
            // 
            // edtCnpj
            // 
            this.edtCnpj.Location = new System.Drawing.Point(12, 64);
            this.edtCnpj.Name = "edtCnpj";
            this.edtCnpj.Size = new System.Drawing.Size(127, 20);
            this.edtCnpj.TabIndex = 4;
            this.edtCnpj.Text = "12345678901";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Finalidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNPJ";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(12, 142);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFim.TabIndex = 8;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(10, 103);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInicio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Inicio";
            // 
            // Perfil
            // 
            this.Perfil.AutoSize = true;
            this.Perfil.Location = new System.Drawing.Point(9, 165);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(30, 13);
            this.Perfil.TabIndex = 12;
            this.Perfil.Text = "Perfil";
            // 
            // edtPerfil
            // 
            this.edtPerfil.Location = new System.Drawing.Point(12, 181);
            this.edtPerfil.Name = "edtPerfil";
            this.edtPerfil.Size = new System.Drawing.Size(55, 20);
            this.edtPerfil.TabIndex = 13;
            this.edtPerfil.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome";
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(12, 220);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(473, 20);
            this.edtNome.TabIndex = 15;
            this.edtNome.Text = "Fabio Pimenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "atividade";
            // 
            // edtAtividade
            // 
            this.edtAtividade.Location = new System.Drawing.Point(73, 181);
            this.edtAtividade.Name = "edtAtividade";
            this.edtAtividade.Size = new System.Drawing.Size(100, 20);
            this.edtAtividade.TabIndex = 17;
            this.edtAtividade.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMainFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.edtAtividade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtPerfil);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtCnpj);
            this.Controls.Add(this.edtFinalidade);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.button1);
            this.Name = "frmMainFiscal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox edtFinalidade;
        private System.Windows.Forms.TextBox edtCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.TextBox edtPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtAtividade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

