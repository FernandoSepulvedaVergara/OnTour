namespace Onetour2
{
    partial class FrmBuscarGestionar
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
            this.Dgv1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnGestionar = new System.Windows.Forms.Button();
            this.BtnNuevoRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv1
            // 
            this.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv1.Location = new System.Drawing.Point(0, 0);
            this.Dgv1.Name = "Dgv1";
            this.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv1.Size = new System.Drawing.Size(595, 295);
            this.Dgv1.TabIndex = 0;
            this.Dgv1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dgv1_DataError);
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
            this.splitContainer1.Panel1.Controls.Add(this.BtnGestionar);
            this.splitContainer1.Panel1.Controls.Add(this.BtnNuevoRegistro);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Dgv1);
            this.splitContainer1.Size = new System.Drawing.Size(595, 354);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 1;
            // 
            // BtnGestionar
            // 
            this.BtnGestionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGestionar.Location = new System.Drawing.Point(149, 9);
            this.BtnGestionar.Name = "BtnGestionar";
            this.BtnGestionar.Size = new System.Drawing.Size(107, 38);
            this.BtnGestionar.TabIndex = 1;
            this.BtnGestionar.Text = "Gestionar";
            this.BtnGestionar.UseVisualStyleBackColor = true;
            this.BtnGestionar.Click += new System.EventHandler(this.BtnGestionar_Click_1);
            // 
            // BtnNuevoRegistro
            // 
            this.BtnNuevoRegistro.Location = new System.Drawing.Point(12, 3);
            this.BtnNuevoRegistro.Name = "BtnNuevoRegistro";
            this.BtnNuevoRegistro.Size = new System.Drawing.Size(107, 48);
            this.BtnNuevoRegistro.TabIndex = 0;
            this.BtnNuevoRegistro.Text = "Nuevo Registro";
            this.BtnNuevoRegistro.UseVisualStyleBackColor = true;
            this.BtnNuevoRegistro.Click += new System.EventHandler(this.BtnNuevoRegistro_Click_1);
            // 
            // FrmBuscarGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(595, 354);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarGestionar";
            this.ShowIcon = false;
            this.Text = "Buscar Gestionar";
            this.Load += new System.EventHandler(this.FrmBuscarGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnGestionar;
        private System.Windows.Forms.Button BtnNuevoRegistro;
    }
}

