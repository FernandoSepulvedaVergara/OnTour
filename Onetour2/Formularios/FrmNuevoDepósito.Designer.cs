namespace Onetour2.Formularios
{
    partial class FrmNuevoDepósito
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
            this.LblTipoDepósito = new System.Windows.Forms.Label();
            this.LblAdjuntarComprobante = new System.Windows.Forms.Label();
            this.BtnAduntar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblMontoDepósito = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGuardarDepósito = new System.Windows.Forms.Button();
            this.TxtNombreComprobante = new System.Windows.Forms.TextBox();
            this.RdbDepósitoRepresentante = new System.Windows.Forms.RadioButton();
            this.RdbDepósitoApoderado = new System.Windows.Forms.RadioButton();
            this.DgvAlumnosDepósito = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnosDepósito)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTipoDepósito
            // 
            this.LblTipoDepósito.AutoSize = true;
            this.LblTipoDepósito.Location = new System.Drawing.Point(42, 21);
            this.LblTipoDepósito.Name = "LblTipoDepósito";
            this.LblTipoDepósito.Size = new System.Drawing.Size(88, 13);
            this.LblTipoDepósito.TabIndex = 0;
            this.LblTipoDepósito.Text = "Tipo de Depósito";
            // 
            // LblAdjuntarComprobante
            // 
            this.LblAdjuntarComprobante.AutoSize = true;
            this.LblAdjuntarComprobante.Location = new System.Drawing.Point(351, 21);
            this.LblAdjuntarComprobante.Name = "LblAdjuntarComprobante";
            this.LblAdjuntarComprobante.Size = new System.Drawing.Size(112, 13);
            this.LblAdjuntarComprobante.TabIndex = 1;
            this.LblAdjuntarComprobante.Text = "Adjuntar Comprobante";
            // 
            // BtnAduntar
            // 
            this.BtnAduntar.Location = new System.Drawing.Point(478, 41);
            this.BtnAduntar.Name = "BtnAduntar";
            this.BtnAduntar.Size = new System.Drawing.Size(75, 23);
            this.BtnAduntar.TabIndex = 4;
            this.BtnAduntar.Text = "Adjuntar";
            this.BtnAduntar.UseVisualStyleBackColor = true;
            this.BtnAduntar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LblMontoDepósito);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnGuardarDepósito);
            this.splitContainer1.Panel1.Controls.Add(this.TxtNombreComprobante);
            this.splitContainer1.Panel1.Controls.Add(this.RdbDepósitoRepresentante);
            this.splitContainer1.Panel1.Controls.Add(this.RdbDepósitoApoderado);
            this.splitContainer1.Panel1.Controls.Add(this.LblAdjuntarComprobante);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAduntar);
            this.splitContainer1.Panel1.Controls.Add(this.LblTipoDepósito);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvAlumnosDepósito);
            this.splitContainer1.Size = new System.Drawing.Size(617, 377);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 4;
            // 
            // LblMontoDepósito
            // 
            this.LblMontoDepósito.AutoSize = true;
            this.LblMontoDepósito.Location = new System.Drawing.Point(351, 85);
            this.LblMontoDepósito.Name = "LblMontoDepósito";
            this.LblMontoDepósito.Size = new System.Drawing.Size(82, 13);
            this.LblMontoDepósito.TabIndex = 10;
            this.LblMontoDepósito.Text = "Monto Depósito";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 107);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar Depósito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGuardarDepósito
            // 
            this.BtnGuardarDepósito.Location = new System.Drawing.Point(519, 85);
            this.BtnGuardarDepósito.Name = "BtnGuardarDepósito";
            this.BtnGuardarDepósito.Size = new System.Drawing.Size(86, 42);
            this.BtnGuardarDepósito.TabIndex = 6;
            this.BtnGuardarDepósito.Text = "Guardar Depósito";
            this.BtnGuardarDepósito.UseVisualStyleBackColor = true;
            this.BtnGuardarDepósito.Click += new System.EventHandler(this.BtnGuardarDepósito_Click);
            // 
            // TxtNombreComprobante
            // 
            this.TxtNombreComprobante.Enabled = false;
            this.TxtNombreComprobante.Location = new System.Drawing.Point(245, 43);
            this.TxtNombreComprobante.Name = "TxtNombreComprobante";
            this.TxtNombreComprobante.Size = new System.Drawing.Size(218, 20);
            this.TxtNombreComprobante.TabIndex = 3;
            // 
            // RdbDepósitoRepresentante
            // 
            this.RdbDepósitoRepresentante.AutoSize = true;
            this.RdbDepósitoRepresentante.Location = new System.Drawing.Point(12, 66);
            this.RdbDepósitoRepresentante.Name = "RdbDepósitoRepresentante";
            this.RdbDepósitoRepresentante.Size = new System.Drawing.Size(95, 17);
            this.RdbDepósitoRepresentante.TabIndex = 2;
            this.RdbDepósitoRepresentante.TabStop = true;
            this.RdbDepósitoRepresentante.Text = "Representante";
            this.RdbDepósitoRepresentante.UseVisualStyleBackColor = true;
            this.RdbDepósitoRepresentante.CheckedChanged += new System.EventHandler(this.RdbDepósitoRepresentante_CheckedChanged);
            // 
            // RdbDepósitoApoderado
            // 
            this.RdbDepósitoApoderado.AutoSize = true;
            this.RdbDepósitoApoderado.Location = new System.Drawing.Point(12, 43);
            this.RdbDepósitoApoderado.Name = "RdbDepósitoApoderado";
            this.RdbDepósitoApoderado.Size = new System.Drawing.Size(77, 17);
            this.RdbDepósitoApoderado.TabIndex = 1;
            this.RdbDepósitoApoderado.TabStop = true;
            this.RdbDepósitoApoderado.Text = "Apoderado";
            this.RdbDepósitoApoderado.UseVisualStyleBackColor = true;
            this.RdbDepósitoApoderado.CheckedChanged += new System.EventHandler(this.RdbDepósitoApoderado_CheckedChanged);
            // 
            // DgvAlumnosDepósito
            // 
            this.DgvAlumnosDepósito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnosDepósito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAlumnosDepósito.Location = new System.Drawing.Point(0, 0);
            this.DgvAlumnosDepósito.Name = "DgvAlumnosDepósito";
            this.DgvAlumnosDepósito.ReadOnly = true;
            this.DgvAlumnosDepósito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlumnosDepósito.Size = new System.Drawing.Size(617, 233);
            this.DgvAlumnosDepósito.TabIndex = 0;
            this.DgvAlumnosDepósito.Visible = false;
            this.DgvAlumnosDepósito.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvAlumnosDepósito_DataError);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmNuevoDepósito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(617, 377);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoDepósito";
            this.ShowIcon = false;
            this.Text = "Nuevo Depósito";
            this.Load += new System.EventHandler(this.FrmNuevoDepósito_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnosDepósito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTipoDepósito;
        private System.Windows.Forms.Label LblAdjuntarComprobante;
        private System.Windows.Forms.Button BtnAduntar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvAlumnosDepósito;
        private System.Windows.Forms.RadioButton RdbDepósitoRepresentante;
        private System.Windows.Forms.RadioButton RdbDepósitoApoderado;
        private System.Windows.Forms.TextBox TxtNombreComprobante;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnGuardarDepósito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblMontoDepósito;
        private System.Windows.Forms.TextBox textBox1;
    }
}