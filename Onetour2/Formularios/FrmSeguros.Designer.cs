namespace Onetour2.Formularios
{
    partial class FrmSeguros
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNuevoSeguro = new System.Windows.Forms.Button();
            this.LblSeguroViaje = new System.Windows.Forms.Label();
            this.LblSeguroVida = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvSeguroVida = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvSeguroViaje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeguroVida)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeguroViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnNuevoSeguro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LblSeguroViaje);
            this.splitContainer1.Panel2.Controls.Add(this.LblSeguroVida);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(692, 426);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nuevo Seguro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnNuevoSeguro
            // 
            this.BtnNuevoSeguro.Location = new System.Drawing.Point(12, 12);
            this.BtnNuevoSeguro.Name = "BtnNuevoSeguro";
            this.BtnNuevoSeguro.Size = new System.Drawing.Size(78, 42);
            this.BtnNuevoSeguro.TabIndex = 0;
            this.BtnNuevoSeguro.Text = "Nuevo Seguro";
            this.BtnNuevoSeguro.UseVisualStyleBackColor = true;
            this.BtnNuevoSeguro.Click += new System.EventHandler(this.BtnNuevoSeguro_Click);
            // 
            // LblSeguroViaje
            // 
            this.LblSeguroViaje.AutoSize = true;
            this.LblSeguroViaje.Location = new System.Drawing.Point(39, 183);
            this.LblSeguroViaje.Name = "LblSeguroViaje";
            this.LblSeguroViaje.Size = new System.Drawing.Size(82, 13);
            this.LblSeguroViaje.TabIndex = 3;
            this.LblSeguroViaje.Text = "Seguro de Viaje";
            // 
            // LblSeguroVida
            // 
            this.LblSeguroVida.AutoSize = true;
            this.LblSeguroVida.Location = new System.Drawing.Point(39, 15);
            this.LblSeguroVida.Name = "LblSeguroVida";
            this.LblSeguroVida.Size = new System.Drawing.Size(80, 13);
            this.LblSeguroVida.TabIndex = 2;
            this.LblSeguroVida.Text = "Seguro de Vida";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvSeguroVida);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 127);
            this.panel2.TabIndex = 1;
            // 
            // DgvSeguroVida
            // 
            this.DgvSeguroVida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSeguroVida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSeguroVida.Location = new System.Drawing.Point(0, 0);
            this.DgvSeguroVida.Name = "DgvSeguroVida";
            this.DgvSeguroVida.ReadOnly = true;
            this.DgvSeguroVida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSeguroVida.Size = new System.Drawing.Size(692, 127);
            this.DgvSeguroVida.TabIndex = 0;
            this.DgvSeguroVida.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvSeguroVida_DataError);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvSeguroViaje);
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 133);
            this.panel1.TabIndex = 0;
            // 
            // DgvSeguroViaje
            // 
            this.DgvSeguroViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSeguroViaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSeguroViaje.Location = new System.Drawing.Point(0, 0);
            this.DgvSeguroViaje.MultiSelect = false;
            this.DgvSeguroViaje.Name = "DgvSeguroViaje";
            this.DgvSeguroViaje.ReadOnly = true;
            this.DgvSeguroViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSeguroViaje.Size = new System.Drawing.Size(689, 133);
            this.DgvSeguroViaje.TabIndex = 2;
            this.DgvSeguroViaje.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvSeguroViaje_DataError);
            // 
            // FrmSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(692, 426);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeguros";
            this.ShowIcon = false;
            this.Text = "Seguros";
            this.Load += new System.EventHandler(this.FrmSeguros_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeguroVida)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSeguroViaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvSeguroVida;
        private System.Windows.Forms.DataGridView DgvSeguroViaje;
        private System.Windows.Forms.Button BtnNuevoSeguro;
        private System.Windows.Forms.Label LblSeguroViaje;
        private System.Windows.Forms.Label LblSeguroVida;
        private System.Windows.Forms.Button button2;
    }
}