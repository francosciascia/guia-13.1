namespace _13._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAtenderDenuncias = new System.Windows.Forms.Button();
            this.btnAtenderNuevoC = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbTurnos = new System.Windows.Forms.ListBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = " ";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(86, 22);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(141, 20);
            this.tbDni.TabIndex = 5;
            this.tbDni.TextChanged += new System.EventHandler(this.tbDni_TextChanged);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTicket.Location = new System.Drawing.Point(251, 76);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(59, 102);
            this.btnTicket.TabIndex = 6;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnExportar.Location = new System.Drawing.Point(244, 184);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(66, 48);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar Tickets";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnImportar.Location = new System.Drawing.Point(244, 238);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(66, 48);
            this.btnImportar.TabIndex = 8;
            this.btnImportar.Text = "Importar Vehiculos";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAtenderDenuncias
            // 
            this.btnAtenderDenuncias.Location = new System.Drawing.Point(23, 305);
            this.btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            this.btnAtenderDenuncias.Size = new System.Drawing.Size(83, 48);
            this.btnAtenderDenuncias.TabIndex = 9;
            this.btnAtenderDenuncias.Text = "Atender Denuncias";
            this.btnAtenderDenuncias.UseVisualStyleBackColor = true;
            // 
            // btnAtenderNuevoC
            // 
            this.btnAtenderNuevoC.Location = new System.Drawing.Point(124, 305);
            this.btnAtenderNuevoC.Name = "btnAtenderNuevoC";
            this.btnAtenderNuevoC.Size = new System.Drawing.Size(83, 48);
            this.btnAtenderNuevoC.TabIndex = 10;
            this.btnAtenderNuevoC.Text = "Atender Nuevo Cliente";
            this.btnAtenderNuevoC.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 148);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nuevo Cliente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 117);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Denuncia";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbTurnos
            // 
            this.lbTurnos.FormattingEnabled = true;
            this.lbTurnos.Location = new System.Drawing.Point(19, 183);
            this.lbTurnos.Name = "lbTurnos";
            this.lbTurnos.Size = new System.Drawing.Size(207, 95);
            this.lbTurnos.TabIndex = 13;
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(124, 115);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(102, 20);
            this.tbPatente.TabIndex = 14;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(124, 144);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 376);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tbPatente);
            this.Controls.Add(this.lbTurnos);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnAtenderNuevoC);
            this.Controls.Add(this.btnAtenderDenuncias);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAtenderDenuncias;
        private System.Windows.Forms.Button btnAtenderNuevoC;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox lbTurnos;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

