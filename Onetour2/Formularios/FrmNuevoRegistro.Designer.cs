namespace Onetour2.Formularios
{
    partial class FrmNuevoRegistro
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
            this.TxtNombreColegio = new System.Windows.Forms.TextBox();
            this.TxtComunaColegio = new System.Windows.Forms.TextBox();
            this.TxtDireccionColegio = new System.Windows.Forms.TextBox();
            this.TxtIdColegio = new System.Windows.Forms.TextBox();
            this.BtnGuardarNuevoRegistro = new System.Windows.Forms.Button();
            this.LblTituloNuvoRegistro = new System.Windows.Forms.Label();
            this.LblComunaColegio = new System.Windows.Forms.Label();
            this.LblDirecciónColegio = new System.Windows.Forms.Label();
            this.LblNombreColegio = new System.Windows.Forms.Label();
            this.LblIdColegio = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNombreColegio
            // 
            this.TxtNombreColegio.Location = new System.Drawing.Point(218, 117);
            this.TxtNombreColegio.Name = "TxtNombreColegio";
            this.TxtNombreColegio.Size = new System.Drawing.Size(127, 20);
            this.TxtNombreColegio.TabIndex = 2;
            this.TxtNombreColegio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreColegio_KeyPress);
            // 
            // TxtComunaColegio
            // 
            this.TxtComunaColegio.Location = new System.Drawing.Point(218, 169);
            this.TxtComunaColegio.Name = "TxtComunaColegio";
            this.TxtComunaColegio.Size = new System.Drawing.Size(127, 20);
            this.TxtComunaColegio.TabIndex = 4;
            this.TxtComunaColegio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComunaColegio_KeyPress);
            // 
            // TxtDireccionColegio
            // 
            this.TxtDireccionColegio.Location = new System.Drawing.Point(218, 143);
            this.TxtDireccionColegio.Name = "TxtDireccionColegio";
            this.TxtDireccionColegio.Size = new System.Drawing.Size(127, 20);
            this.TxtDireccionColegio.TabIndex = 3;
            this.TxtDireccionColegio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionColegio_KeyPress);
            // 
            // TxtIdColegio
            // 
            this.TxtIdColegio.Enabled = false;
            this.TxtIdColegio.Location = new System.Drawing.Point(218, 91);
            this.TxtIdColegio.Name = "TxtIdColegio";
            this.TxtIdColegio.Size = new System.Drawing.Size(127, 20);
            this.TxtIdColegio.TabIndex = 1;
            this.TxtIdColegio.Visible = false;
            // 
            // BtnGuardarNuevoRegistro
            // 
            this.BtnGuardarNuevoRegistro.Location = new System.Drawing.Point(412, 244);
            this.BtnGuardarNuevoRegistro.Name = "BtnGuardarNuevoRegistro";
            this.BtnGuardarNuevoRegistro.Size = new System.Drawing.Size(91, 48);
            this.BtnGuardarNuevoRegistro.TabIndex = 5;
            this.BtnGuardarNuevoRegistro.Text = "Guardar";
            this.BtnGuardarNuevoRegistro.UseVisualStyleBackColor = true;
            this.BtnGuardarNuevoRegistro.Click += new System.EventHandler(this.BtnGuardarNuevoRegistro_Click_1);
            // 
            // LblTituloNuvoRegistro
            // 
            this.LblTituloNuvoRegistro.AutoSize = true;
            this.LblTituloNuvoRegistro.Location = new System.Drawing.Point(248, 39);
            this.LblTituloNuvoRegistro.Name = "LblTituloNuvoRegistro";
            this.LblTituloNuvoRegistro.Size = new System.Drawing.Size(42, 13);
            this.LblTituloNuvoRegistro.TabIndex = 6;
            this.LblTituloNuvoRegistro.Text = "Colegio";
            // 
            // LblComunaColegio
            // 
            this.LblComunaColegio.AutoSize = true;
            this.LblComunaColegio.Location = new System.Drawing.Point(147, 172);
            this.LblComunaColegio.Name = "LblComunaColegio";
            this.LblComunaColegio.Size = new System.Drawing.Size(46, 13);
            this.LblComunaColegio.TabIndex = 7;
            this.LblComunaColegio.Text = "Comuna";
            // 
            // LblDirecciónColegio
            // 
            this.LblDirecciónColegio.AutoSize = true;
            this.LblDirecciónColegio.Location = new System.Drawing.Point(147, 146);
            this.LblDirecciónColegio.Name = "LblDirecciónColegio";
            this.LblDirecciónColegio.Size = new System.Drawing.Size(52, 13);
            this.LblDirecciónColegio.TabIndex = 8;
            this.LblDirecciónColegio.Text = "Dirección";
            // 
            // LblNombreColegio
            // 
            this.LblNombreColegio.AutoSize = true;
            this.LblNombreColegio.Location = new System.Drawing.Point(147, 120);
            this.LblNombreColegio.Name = "LblNombreColegio";
            this.LblNombreColegio.Size = new System.Drawing.Size(44, 13);
            this.LblNombreColegio.TabIndex = 9;
            this.LblNombreColegio.Text = "Nombre";
            // 
            // LblIdColegio
            // 
            this.LblIdColegio.AutoSize = true;
            this.LblIdColegio.Location = new System.Drawing.Point(147, 94);
            this.LblIdColegio.Name = "LblIdColegio";
            this.LblIdColegio.Size = new System.Drawing.Size(56, 13);
            this.LblIdColegio.TabIndex = 10;
            this.LblIdColegio.Text = "ID Colegio";
            this.LblIdColegio.Visible = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(254, 262);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(91, 30);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 321);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LblIdColegio);
            this.Controls.Add(this.LblNombreColegio);
            this.Controls.Add(this.LblDirecciónColegio);
            this.Controls.Add(this.LblComunaColegio);
            this.Controls.Add(this.LblTituloNuvoRegistro);
            this.Controls.Add(this.BtnGuardarNuevoRegistro);
            this.Controls.Add(this.TxtIdColegio);
            this.Controls.Add(this.TxtDireccionColegio);
            this.Controls.Add(this.TxtComunaColegio);
            this.Controls.Add(this.TxtNombreColegio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoRegistro";
            this.ShowIcon = false;
            this.Text = "FrmNuevoRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreColegio;
        private System.Windows.Forms.TextBox TxtComunaColegio;
        private System.Windows.Forms.TextBox TxtDireccionColegio;
        private System.Windows.Forms.TextBox TxtIdColegio;
        private System.Windows.Forms.Button BtnGuardarNuevoRegistro;
        private System.Windows.Forms.Label LblTituloNuvoRegistro;
        private System.Windows.Forms.Label LblComunaColegio;
        private System.Windows.Forms.Label LblDirecciónColegio;
        private System.Windows.Forms.Label LblNombreColegio;
        private System.Windows.Forms.Label LblIdColegio;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}