namespace Onetour2.Formularios
{
    partial class FrmNuevoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRutFuncionario = new System.Windows.Forms.TextBox();
            this.TxtDvFuncionario = new System.Windows.Forms.TextBox();
            this.LblFuncionario = new System.Windows.Forms.Label();
            this.TxtNombreFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtNombreusuario = new System.Windows.Forms.TextBox();
            this.BtnGuardarUsuario = new System.Windows.Forms.Button();
            this.LblTipo_funcionario = new System.Windows.Forms.Label();
            this.CmbTipoFuncionario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            // 
            // TxtRutFuncionario
            // 
            this.TxtRutFuncionario.Location = new System.Drawing.Point(158, 62);
            this.TxtRutFuncionario.MaxLength = 8;
            this.TxtRutFuncionario.Name = "TxtRutFuncionario";
            this.TxtRutFuncionario.Size = new System.Drawing.Size(100, 20);
            this.TxtRutFuncionario.TabIndex = 1;
            this.TxtRutFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRutFuncionario_KeyPress);
            // 
            // TxtDvFuncionario
            // 
            this.TxtDvFuncionario.Location = new System.Drawing.Point(280, 62);
            this.TxtDvFuncionario.MaxLength = 1;
            this.TxtDvFuncionario.Name = "TxtDvFuncionario";
            this.TxtDvFuncionario.Size = new System.Drawing.Size(26, 20);
            this.TxtDvFuncionario.TabIndex = 2;
            this.TxtDvFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDvFuncionario_KeyPress);
            // 
            // LblFuncionario
            // 
            this.LblFuncionario.AutoSize = true;
            this.LblFuncionario.Location = new System.Drawing.Point(106, 28);
            this.LblFuncionario.Name = "LblFuncionario";
            this.LblFuncionario.Size = new System.Drawing.Size(78, 13);
            this.LblFuncionario.TabIndex = 3;
            this.LblFuncionario.Text = "Nuevo Usuario";
            // 
            // TxtNombreFuncionario
            // 
            this.TxtNombreFuncionario.Location = new System.Drawing.Point(158, 100);
            this.TxtNombreFuncionario.MaxLength = 50;
            this.TxtNombreFuncionario.Name = "TxtNombreFuncionario";
            this.TxtNombreFuncionario.Size = new System.Drawing.Size(148, 20);
            this.TxtNombreFuncionario.TabIndex = 4;
            this.TxtNombreFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreFuncionario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre De Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(158, 225);
            this.TxtContraseña.MaxLength = 50;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(148, 20);
            this.TxtContraseña.TabIndex = 11;
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            // 
            // TxtNombreusuario
            // 
            this.TxtNombreusuario.Location = new System.Drawing.Point(158, 185);
            this.TxtNombreusuario.MaxLength = 50;
            this.TxtNombreusuario.Name = "TxtNombreusuario";
            this.TxtNombreusuario.Size = new System.Drawing.Size(148, 20);
            this.TxtNombreusuario.TabIndex = 14;
            this.TxtNombreusuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.TxtNombreusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // BtnGuardarUsuario
            // 
            this.BtnGuardarUsuario.Location = new System.Drawing.Point(313, 272);
            this.BtnGuardarUsuario.Name = "BtnGuardarUsuario";
            this.BtnGuardarUsuario.Size = new System.Drawing.Size(92, 38);
            this.BtnGuardarUsuario.TabIndex = 15;
            this.BtnGuardarUsuario.Text = "Guardar Usuario";
            this.BtnGuardarUsuario.UseVisualStyleBackColor = true;
            this.BtnGuardarUsuario.Click += new System.EventHandler(this.BtnGuardarUsuario_Click);
            // 
            // LblTipo_funcionario
            // 
            this.LblTipo_funcionario.AutoSize = true;
            this.LblTipo_funcionario.Location = new System.Drawing.Point(54, 140);
            this.LblTipo_funcionario.Name = "LblTipo_funcionario";
            this.LblTipo_funcionario.Size = new System.Drawing.Size(93, 13);
            this.LblTipo_funcionario.TabIndex = 17;
            this.LblTipo_funcionario.Text = "Rol de funcionario";
            // 
            // CmbTipoFuncionario
            // 
            this.CmbTipoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoFuncionario.FormattingEnabled = true;
            this.CmbTipoFuncionario.Items.AddRange(new object[] {
            "Ejecutivo de ventas",
            "Dueño",
            "Administrador"});
            this.CmbTipoFuncionario.Location = new System.Drawing.Point(158, 137);
            this.CmbTipoFuncionario.Name = "CmbTipoFuncionario";
            this.CmbTipoFuncionario.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoFuncionario.TabIndex = 18;
            // 
            // FrmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 332);
            this.Controls.Add(this.CmbTipoFuncionario);
            this.Controls.Add(this.LblTipo_funcionario);
            this.Controls.Add(this.BtnGuardarUsuario);
            this.Controls.Add(this.TxtNombreusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreFuncionario);
            this.Controls.Add(this.LblFuncionario);
            this.Controls.Add(this.TxtDvFuncionario);
            this.Controls.Add(this.TxtRutFuncionario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoUsuario";
            this.ShowIcon = false;
            this.Text = "FrmNuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRutFuncionario;
        private System.Windows.Forms.TextBox TxtDvFuncionario;
        private System.Windows.Forms.Label LblFuncionario;
        private System.Windows.Forms.TextBox TxtNombreFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtNombreusuario;
        private System.Windows.Forms.Button BtnGuardarUsuario;
        private System.Windows.Forms.Label LblTipo_funcionario;
        private System.Windows.Forms.ComboBox CmbTipoFuncionario;
    }
}