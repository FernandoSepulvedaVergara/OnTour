namespace Onetour2.Formularios
{
    partial class FrmModificarUsuario
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
            this.TxtNuevoNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtNuevaContraseñUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnActualizar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtNuevaContraseñUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.TxtNuevoNombreUsuario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvFuncionarios);
            this.splitContainer1.Size = new System.Drawing.Size(593, 450);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // TxtNuevoNombreUsuario
            // 
            this.TxtNuevoNombreUsuario.Location = new System.Drawing.Point(166, 39);
            this.TxtNuevoNombreUsuario.MaxLength = 50;
            this.TxtNuevoNombreUsuario.Name = "TxtNuevoNombreUsuario";
            this.TxtNuevoNombreUsuario.Size = new System.Drawing.Size(163, 20);
            this.TxtNuevoNombreUsuario.TabIndex = 0;
            this.TxtNuevoNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TxtNuevaContraseñUsuario
            // 
            this.TxtNuevaContraseñUsuario.Location = new System.Drawing.Point(166, 76);
            this.TxtNuevaContraseñUsuario.MaxLength = 50;
            this.TxtNuevaContraseñUsuario.Name = "TxtNuevaContraseñUsuario";
            this.TxtNuevaContraseñUsuario.Size = new System.Drawing.Size(163, 20);
            this.TxtNuevaContraseñUsuario.TabIndex = 1;
            this.TxtNuevaContraseñUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Nombre Usuario";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(432, 52);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva contraseña";
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.ReadOnly = true;
            this.DgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionarios.Size = new System.Drawing.Size(593, 328);
            this.DgvFuncionarios.TabIndex = 0;
            this.DgvFuncionarios.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvFuncionarios_DataError);
            // 
            // FrmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarUsuario";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.FrmModificarUsuario_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNuevaContraseñUsuario;
        private System.Windows.Forms.TextBox TxtNuevoNombreUsuario;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
    }
}