namespace Onetour2.Formularios
{
    partial class FrmNuevoContrato
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblTituloContrato = new System.Windows.Forms.Label();
            this.BtnGuardarContrato = new System.Windows.Forms.Button();
            this.BtnAdjuntar = new System.Windows.Forms.Button();
            this.TxtDestino = new System.Windows.Forms.TextBox();
            this.LblDestino = new System.Windows.Forms.Label();
            this.LblFechaViaje = new System.Windows.Forms.Label();
            this.DtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaTope = new System.Windows.Forms.DateTimePicker();
            this.LblFechaTope = new System.Windows.Forms.Label();
            this.TxtAdjuntarArchivo = new System.Windows.Forms.TextBox();
            this.LblAdjuntarContrato = new System.Windows.Forms.Label();
            this.TxtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.LblCantidadAlumnos = new System.Windows.Forms.Label();
            this.TxtMontoFinal = new System.Windows.Forms.TextBox();
            this.LblMontoFinal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAsignarSeguro = new System.Windows.Forms.Button();
            this.DgvVseguroVida = new System.Windows.Forms.DataGridView();
            this.BtnAgregarSeguroVida = new System.Windows.Forms.Button();
            this.BtnSuprimirVida = new System.Windows.Forms.Button();
            this.DgvVseguroViaje = new System.Windows.Forms.DataGridView();
            this.LblSeguroVida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSuprimirViaje = new System.Windows.Forms.Button();
            this.BtnAgregarSeguroViaje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVseguroVida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVseguroViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LblTituloContrato
            // 
            this.LblTituloContrato.AutoSize = true;
            this.LblTituloContrato.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloContrato.Location = new System.Drawing.Point(253, 21);
            this.LblTituloContrato.Name = "LblTituloContrato";
            this.LblTituloContrato.Size = new System.Drawing.Size(145, 36);
            this.LblTituloContrato.TabIndex = 0;
            this.LblTituloContrato.Text = "Contrato";
            // 
            // BtnGuardarContrato
            // 
            this.BtnGuardarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarContrato.Location = new System.Drawing.Point(538, 335);
            this.BtnGuardarContrato.Name = "BtnGuardarContrato";
            this.BtnGuardarContrato.Size = new System.Drawing.Size(93, 58);
            this.BtnGuardarContrato.TabIndex = 12;
            this.BtnGuardarContrato.Text = "Guardar Contrato";
            this.BtnGuardarContrato.UseVisualStyleBackColor = true;
            this.BtnGuardarContrato.Click += new System.EventHandler(this.BtnGuardarContrato_Click_1);
            // 
            // BtnAdjuntar
            // 
            this.BtnAdjuntar.Location = new System.Drawing.Point(521, 230);
            this.BtnAdjuntar.Name = "BtnAdjuntar";
            this.BtnAdjuntar.Size = new System.Drawing.Size(93, 30);
            this.BtnAdjuntar.TabIndex = 6;
            this.BtnAdjuntar.Text = "Adjuntar";
            this.BtnAdjuntar.UseVisualStyleBackColor = true;
            this.BtnAdjuntar.Click += new System.EventHandler(this.BtnAdjuntar_Click_1);
            // 
            // TxtDestino
            // 
            this.TxtDestino.Location = new System.Drawing.Point(191, 114);
            this.TxtDestino.Name = "TxtDestino";
            this.TxtDestino.Size = new System.Drawing.Size(319, 20);
            this.TxtDestino.TabIndex = 2;
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(77, 117);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(43, 13);
            this.LblDestino.TabIndex = 4;
            this.LblDestino.Text = "Destino";
            // 
            // LblFechaViaje
            // 
            this.LblFechaViaje.AutoSize = true;
            this.LblFechaViaje.Location = new System.Drawing.Point(77, 157);
            this.LblFechaViaje.Name = "LblFechaViaje";
            this.LblFechaViaje.Size = new System.Drawing.Size(62, 13);
            this.LblFechaViaje.TabIndex = 5;
            this.LblFechaViaje.Text = "Fecha viaje";
            // 
            // DtpFechaViaje
            // 
            this.DtpFechaViaje.Location = new System.Drawing.Point(191, 151);
            this.DtpFechaViaje.Name = "DtpFechaViaje";
            this.DtpFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaViaje.TabIndex = 3;
            // 
            // DtpFechaTope
            // 
            this.DtpFechaTope.Location = new System.Drawing.Point(191, 186);
            this.DtpFechaTope.Name = "DtpFechaTope";
            this.DtpFechaTope.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaTope.TabIndex = 4;
            // 
            // LblFechaTope
            // 
            this.LblFechaTope.AutoSize = true;
            this.LblFechaTope.Location = new System.Drawing.Point(77, 192);
            this.LblFechaTope.Name = "LblFechaTope";
            this.LblFechaTope.Size = new System.Drawing.Size(61, 13);
            this.LblFechaTope.TabIndex = 7;
            this.LblFechaTope.Text = "Fecha tope";
            // 
            // TxtAdjuntarArchivo
            // 
            this.TxtAdjuntarArchivo.Enabled = false;
            this.TxtAdjuntarArchivo.Location = new System.Drawing.Point(191, 236);
            this.TxtAdjuntarArchivo.Name = "TxtAdjuntarArchivo";
            this.TxtAdjuntarArchivo.Size = new System.Drawing.Size(319, 20);
            this.TxtAdjuntarArchivo.TabIndex = 5;
            // 
            // LblAdjuntarContrato
            // 
            this.LblAdjuntarContrato.AutoSize = true;
            this.LblAdjuntarContrato.Location = new System.Drawing.Point(78, 239);
            this.LblAdjuntarContrato.Name = "LblAdjuntarContrato";
            this.LblAdjuntarContrato.Size = new System.Drawing.Size(89, 13);
            this.LblAdjuntarContrato.TabIndex = 10;
            this.LblAdjuntarContrato.Text = "Adjuntar Contrato";
            // 
            // TxtCantidadAlumnos
            // 
            this.TxtCantidadAlumnos.Location = new System.Drawing.Point(191, 79);
            this.TxtCantidadAlumnos.MaxLength = 3;
            this.TxtCantidadAlumnos.Name = "TxtCantidadAlumnos";
            this.TxtCantidadAlumnos.Size = new System.Drawing.Size(35, 20);
            this.TxtCantidadAlumnos.TabIndex = 1;
            // 
            // LblCantidadAlumnos
            // 
            this.LblCantidadAlumnos.AutoSize = true;
            this.LblCantidadAlumnos.Location = new System.Drawing.Point(78, 82);
            this.LblCantidadAlumnos.Name = "LblCantidadAlumnos";
            this.LblCantidadAlumnos.Size = new System.Drawing.Size(106, 13);
            this.LblCantidadAlumnos.TabIndex = 12;
            this.LblCantidadAlumnos.Text = "Cantidad de alumnos";
            // 
            // TxtMontoFinal
            // 
            this.TxtMontoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoFinal.Location = new System.Drawing.Point(410, 325);
            this.TxtMontoFinal.MaxLength = 10;
            this.TxtMontoFinal.Name = "TxtMontoFinal";
            this.TxtMontoFinal.Size = new System.Drawing.Size(100, 24);
            this.TxtMontoFinal.TabIndex = 7;
            // 
            // LblMontoFinal
            // 
            this.LblMontoFinal.AutoSize = true;
            this.LblMontoFinal.Location = new System.Drawing.Point(332, 328);
            this.LblMontoFinal.Name = "LblMontoFinal";
            this.LblMontoFinal.Size = new System.Drawing.Size(59, 13);
            this.LblMontoFinal.TabIndex = 14;
            this.LblMontoFinal.Text = "Monto final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar Contrato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAsignarSeguro
            // 
            this.BtnAsignarSeguro.Location = new System.Drawing.Point(44, 303);
            this.BtnAsignarSeguro.Name = "BtnAsignarSeguro";
            this.BtnAsignarSeguro.Size = new System.Drawing.Size(123, 42);
            this.BtnAsignarSeguro.TabIndex = 16;
            this.BtnAsignarSeguro.Text = "Asignar Seguro";
            this.BtnAsignarSeguro.UseVisualStyleBackColor = true;
            this.BtnAsignarSeguro.Visible = false;
            this.BtnAsignarSeguro.Click += new System.EventHandler(this.BtnAgregarSeguro_Click);
            // 
            // DgvVseguroVida
            // 
            this.DgvVseguroVida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVseguroVida.Location = new System.Drawing.Point(22, 410);
            this.DgvVseguroVida.MultiSelect = false;
            this.DgvVseguroVida.Name = "DgvVseguroVida";
            this.DgvVseguroVida.ReadOnly = true;
            this.DgvVseguroVida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVseguroVida.Size = new System.Drawing.Size(629, 150);
            this.DgvVseguroVida.TabIndex = 17;
            this.DgvVseguroVida.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvVseguroVida_DataError);
            // 
            // BtnAgregarSeguroVida
            // 
            this.BtnAgregarSeguroVida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarSeguroVida.Location = new System.Drawing.Point(24, 382);
            this.BtnAgregarSeguroVida.Name = "BtnAgregarSeguroVida";
            this.BtnAgregarSeguroVida.Size = new System.Drawing.Size(123, 23);
            this.BtnAgregarSeguroVida.TabIndex = 8;
            this.BtnAgregarSeguroVida.Text = "Agregar Seguro";
            this.BtnAgregarSeguroVida.UseVisualStyleBackColor = true;
            this.BtnAgregarSeguroVida.Click += new System.EventHandler(this.BtnAgregarSeguro_Click_1);
            // 
            // BtnSuprimirVida
            // 
            this.BtnSuprimirVida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSuprimirVida.Location = new System.Drawing.Point(153, 382);
            this.BtnSuprimirVida.Name = "BtnSuprimirVida";
            this.BtnSuprimirVida.Size = new System.Drawing.Size(123, 23);
            this.BtnSuprimirVida.TabIndex = 9;
            this.BtnSuprimirVida.Text = "Eliminar Seguro";
            this.BtnSuprimirVida.UseVisualStyleBackColor = true;
            this.BtnSuprimirVida.Click += new System.EventHandler(this.BtnSuprimir_Click);
            // 
            // DgvVseguroViaje
            // 
            this.DgvVseguroViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVseguroViaje.Location = new System.Drawing.Point(22, 639);
            this.DgvVseguroViaje.MultiSelect = false;
            this.DgvVseguroViaje.Name = "DgvVseguroViaje";
            this.DgvVseguroViaje.ReadOnly = true;
            this.DgvVseguroViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVseguroViaje.Size = new System.Drawing.Size(629, 150);
            this.DgvVseguroViaje.TabIndex = 20;
            this.DgvVseguroViaje.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvVseguroViaje_DataError);
            // 
            // LblSeguroVida
            // 
            this.LblSeguroVida.AutoSize = true;
            this.LblSeguroVida.Location = new System.Drawing.Point(21, 366);
            this.LblSeguroVida.Name = "LblSeguroVida";
            this.LblSeguroVida.Size = new System.Drawing.Size(80, 13);
            this.LblSeguroVida.TabIndex = 21;
            this.LblSeguroVida.Text = "Seguro de Vida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Seguro de Viaje";
            // 
            // BtnSuprimirViaje
            // 
            this.BtnSuprimirViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSuprimirViaje.Location = new System.Drawing.Point(151, 608);
            this.BtnSuprimirViaje.Name = "BtnSuprimirViaje";
            this.BtnSuprimirViaje.Size = new System.Drawing.Size(123, 23);
            this.BtnSuprimirViaje.TabIndex = 11;
            this.BtnSuprimirViaje.Text = "Eliminar Seguro";
            this.BtnSuprimirViaje.UseVisualStyleBackColor = true;
            this.BtnSuprimirViaje.Click += new System.EventHandler(this.BtnSuprimirViaje_Click);
            // 
            // BtnAgregarSeguroViaje
            // 
            this.BtnAgregarSeguroViaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarSeguroViaje.Location = new System.Drawing.Point(22, 608);
            this.BtnAgregarSeguroViaje.Name = "BtnAgregarSeguroViaje";
            this.BtnAgregarSeguroViaje.Size = new System.Drawing.Size(123, 23);
            this.BtnAgregarSeguroViaje.TabIndex = 10;
            this.BtnAgregarSeguroViaje.Text = "Agregar Seguro";
            this.BtnAgregarSeguroViaje.UseVisualStyleBackColor = true;
            this.BtnAgregarSeguroViaje.Click += new System.EventHandler(this.BtnAgregarSeguroViaje_Click);
            // 
            // FrmNuevoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(678, 572);
            this.Controls.Add(this.BtnSuprimirViaje);
            this.Controls.Add(this.BtnAgregarSeguroViaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblSeguroVida);
            this.Controls.Add(this.DgvVseguroViaje);
            this.Controls.Add(this.BtnSuprimirVida);
            this.Controls.Add(this.BtnAgregarSeguroVida);
            this.Controls.Add(this.DgvVseguroVida);
            this.Controls.Add(this.BtnAsignarSeguro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblMontoFinal);
            this.Controls.Add(this.TxtMontoFinal);
            this.Controls.Add(this.LblCantidadAlumnos);
            this.Controls.Add(this.TxtCantidadAlumnos);
            this.Controls.Add(this.LblAdjuntarContrato);
            this.Controls.Add(this.TxtAdjuntarArchivo);
            this.Controls.Add(this.DtpFechaTope);
            this.Controls.Add(this.LblFechaTope);
            this.Controls.Add(this.DtpFechaViaje);
            this.Controls.Add(this.LblFechaViaje);
            this.Controls.Add(this.LblDestino);
            this.Controls.Add(this.TxtDestino);
            this.Controls.Add(this.BtnAdjuntar);
            this.Controls.Add(this.BtnGuardarContrato);
            this.Controls.Add(this.LblTituloContrato);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoContrato";
            this.ShowIcon = false;
            this.Text = "Nuevo Contrato";
            this.Load += new System.EventHandler(this.FrmNuevoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVseguroVida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVseguroViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblTituloContrato;
        private System.Windows.Forms.Button BtnGuardarContrato;
        private System.Windows.Forms.Button BtnAdjuntar;
        private System.Windows.Forms.TextBox TxtDestino;
        private System.Windows.Forms.Label LblDestino;
        private System.Windows.Forms.Label LblFechaViaje;
        private System.Windows.Forms.DateTimePicker DtpFechaViaje;
        private System.Windows.Forms.DateTimePicker DtpFechaTope;
        private System.Windows.Forms.Label LblFechaTope;
        private System.Windows.Forms.TextBox TxtAdjuntarArchivo;
        private System.Windows.Forms.Label LblAdjuntarContrato;
        private System.Windows.Forms.TextBox TxtCantidadAlumnos;
        private System.Windows.Forms.Label LblCantidadAlumnos;
        private System.Windows.Forms.TextBox TxtMontoFinal;
        private System.Windows.Forms.Label LblMontoFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAsignarSeguro;
        private System.Windows.Forms.DataGridView DgvVseguroVida;
        private System.Windows.Forms.Button BtnAgregarSeguroVida;
        private System.Windows.Forms.Button BtnSuprimirVida;
        private System.Windows.Forms.DataGridView DgvVseguroViaje;
        private System.Windows.Forms.Label LblSeguroVida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSuprimirViaje;
        private System.Windows.Forms.Button BtnAgregarSeguroViaje;
    }
}