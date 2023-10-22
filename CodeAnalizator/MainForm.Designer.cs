namespace CodeAnalizator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.cbLenguaje = new System.Windows.Forms.ComboBox();
            this.cbCodigoFuente = new System.Windows.Forms.RichTextBox();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnCargarArchivo = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.PictureBox();
            this.btnAnalizador = new System.Windows.Forms.PictureBox();
            this.btnExportarTexto = new System.Windows.Forms.PictureBox();
            this.headerMainForm = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnalizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarTexto)).BeginInit();
            this.headerMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código fuente";
            // 
            // cbLenguaje
            // 
            this.cbLenguaje.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLenguaje.FormattingEnabled = true;
            this.cbLenguaje.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbLenguaje.Items.AddRange(new object[] {
            "C++",
            "Java"});
            this.cbLenguaje.Location = new System.Drawing.Point(314, 273);
            this.cbLenguaje.Name = "cbLenguaje";
            this.cbLenguaje.Size = new System.Drawing.Size(50, 24);
            this.cbLenguaje.TabIndex = 5;
            this.cbLenguaje.TabStop = false;
            this.cbLenguaje.Text = "C++";
            // 
            // cbCodigoFuente
            // 
            this.cbCodigoFuente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.cbCodigoFuente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbCodigoFuente.Font = new System.Drawing.Font("MesloLGL NF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodigoFuente.Location = new System.Drawing.Point(50, 323);
            this.cbCodigoFuente.Name = "cbCodigoFuente";
            this.cbCodigoFuente.ReadOnly = true;
            this.cbCodigoFuente.Size = new System.Drawing.Size(591, 94);
            this.cbCodigoFuente.TabIndex = 7;
            this.cbCodigoFuente.TabStop = false;
            this.cbCodigoFuente.Text = "";
            // 
            // rtbResultado
            // 
            this.rtbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.rtbResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResultado.Font = new System.Drawing.Font("MesloLGL NF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultado.Location = new System.Drawing.Point(13, 11);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.Size = new System.Drawing.Size(591, 94);
            this.rtbResultado.TabIndex = 8;
            this.rtbResultado.TabStop = false;
            this.rtbResultado.Text = "";
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarArchivo.Image")));
            this.btnCargarArchivo.Location = new System.Drawing.Point(116, 265);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(32, 32);
            this.btnCargarArchivo.TabIndex = 9;
            this.btnCargarArchivo.TabStop = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(50, 265);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(32, 32);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnAnalizador
            // 
            this.btnAnalizador.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalizador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalizador.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalizador.Image")));
            this.btnAnalizador.Location = new System.Drawing.Point(380, 265);
            this.btnAnalizador.Name = "btnAnalizador";
            this.btnAnalizador.Size = new System.Drawing.Size(32, 32);
            this.btnAnalizador.TabIndex = 11;
            this.btnAnalizador.TabStop = false;
            this.btnAnalizador.Click += new System.EventHandler(this.btnAnalizador_Click_1);
            // 
            // btnExportarTexto
            // 
            this.btnExportarTexto.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarTexto.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarTexto.Image")));
            this.btnExportarTexto.Location = new System.Drawing.Point(440, 265);
            this.btnExportarTexto.Name = "btnExportarTexto";
            this.btnExportarTexto.Size = new System.Drawing.Size(32, 32);
            this.btnExportarTexto.TabIndex = 12;
            this.btnExportarTexto.TabStop = false;
            this.btnExportarTexto.Click += new System.EventHandler(this.btnExportarTexto_Click);
            // 
            // headerMainForm
            // 
            this.headerMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.headerMainForm.Controls.Add(this.btnAyuda);
            this.headerMainForm.Controls.Add(this.btnClose);
            this.headerMainForm.Controls.Add(this.label1);
            this.headerMainForm.Controls.Add(this.pictureBox1);
            this.headerMainForm.Location = new System.Drawing.Point(0, 0);
            this.headerMainForm.Name = "headerMainForm";
            this.headerMainForm.Size = new System.Drawing.Size(696, 50);
            this.headerMainForm.TabIndex = 13;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(312, 21);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(70, 16);
            this.btnAyuda.TabIndex = 20;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(624, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CodeDev";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Analizador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Léxico";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(440, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 56);
            this.label3.TabIndex = 17;
            this.label3.Text = "Analiza y descompone código C++ y\r\nJava en elementos clave, como palabras\r\nclave " +
    "y operadores, para una mejor\r\ncomprensión y procesamiento.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(37, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 116);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.rtbResultado);
            this.panel3.Location = new System.Drawing.Point(37, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 116);
            this.panel3.TabIndex = 19;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportarTexto);
            this.Controls.Add(this.btnAnalizador);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.cbCodigoFuente);
            this.Controls.Add(this.cbLenguaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.headerMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnalizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarTexto)).EndInit();
            this.headerMainForm.ResumeLayout(false);
            this.headerMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLenguaje;
        private System.Windows.Forms.RichTextBox cbCodigoFuente;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.PictureBox btnCargarArchivo;
        private System.Windows.Forms.PictureBox btnNuevo;
        private System.Windows.Forms.PictureBox btnAnalizador;
        private System.Windows.Forms.PictureBox btnExportarTexto;
        private System.Windows.Forms.Panel headerMainForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btnAyuda;
    }
}

