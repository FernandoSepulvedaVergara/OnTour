namespace Onetour2.Formularios
{
    partial class FrmNuevoCurso
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
            this.RdbBasica = new System.Windows.Forms.RadioButton();
            this.RdbMedia = new System.Windows.Forms.RadioButton();
            this.CmbxNivelMedia = new System.Windows.Forms.ComboBox();
            this.CmbxNivelBasica = new System.Windows.Forms.ComboBox();
            this.LblTituloCurso = new System.Windows.Forms.Label();
            this.LblNivel = new System.Windows.Forms.Label();
            this.LblCurso = new System.Windows.Forms.Label();
            this.LblTituloRepresentante = new System.Windows.Forms.Label();
            this.TxtRutRepresentante = new System.Windows.Forms.TextBox();
            this.TxtEmailRepresentante = new System.Windows.Forms.TextBox();
            this.TxtNombreRepresentante = new System.Windows.Forms.TextBox();
            this.LblNombreRepresentante = new System.Windows.Forms.Label();
            this.LblEmailRepresentante = new System.Windows.Forms.Label();
            this.LblRutRepresentante = new System.Windows.Forms.Label();
            this.BtnGuardarCurso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtDvRepresentante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RdbBasica
            // 
            this.RdbBasica.AutoSize = true;
            this.RdbBasica.Location = new System.Drawing.Point(119, 60);
            this.RdbBasica.Name = "RdbBasica";
            this.RdbBasica.Size = new System.Drawing.Size(57, 17);
            this.RdbBasica.TabIndex = 1;
            this.RdbBasica.TabStop = true;
            this.RdbBasica.Text = "Básica";
            this.RdbBasica.UseVisualStyleBackColor = true;
            this.RdbBasica.CheckedChanged += new System.EventHandler(this.RdbBasica_CheckedChanged_1);
            // 
            // RdbMedia
            // 
            this.RdbMedia.AutoSize = true;
            this.RdbMedia.Location = new System.Drawing.Point(191, 60);
            this.RdbMedia.Name = "RdbMedia";
            this.RdbMedia.Size = new System.Drawing.Size(54, 17);
            this.RdbMedia.TabIndex = 2;
            this.RdbMedia.TabStop = true;
            this.RdbMedia.Text = "Media";
            this.RdbMedia.UseVisualStyleBackColor = true;
            this.RdbMedia.CheckedChanged += new System.EventHandler(this.RdbMedia_CheckedChanged_1);
            // 
            // CmbxNivelMedia
            // 
            this.CmbxNivelMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxNivelMedia.FormattingEnabled = true;
            this.CmbxNivelMedia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CmbxNivelMedia.Location = new System.Drawing.Point(124, 94);
            this.CmbxNivelMedia.Name = "CmbxNivelMedia";
            this.CmbxNivelMedia.Size = new System.Drawing.Size(121, 21);
            this.CmbxNivelMedia.TabIndex = 2;
            this.CmbxNivelMedia.SelectedIndexChanged += new System.EventHandler(this.CmbxNivelMedia_SelectedIndexChanged_1);
            // 
            // CmbxNivelBasica
            // 
            this.CmbxNivelBasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxNivelBasica.FormattingEnabled = true;
            this.CmbxNivelBasica.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CmbxNivelBasica.Location = new System.Drawing.Point(124, 94);
            this.CmbxNivelBasica.Name = "CmbxNivelBasica";
            this.CmbxNivelBasica.Size = new System.Drawing.Size(121, 21);
            this.CmbxNivelBasica.TabIndex = 3;
            this.CmbxNivelBasica.SelectedIndexChanged += new System.EventHandler(this.CmbxNivelBasica_SelectedIndexChanged_1);
            // 
            // LblTituloCurso
            // 
            this.LblTituloCurso.AutoSize = true;
            this.LblTituloCurso.Location = new System.Drawing.Point(156, 24);
            this.LblTituloCurso.Name = "LblTituloCurso";
            this.LblTituloCurso.Size = new System.Drawing.Size(34, 13);
            this.LblTituloCurso.TabIndex = 4;
            this.LblTituloCurso.Text = "Curso";
            // 
            // LblNivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Location = new System.Drawing.Point(41, 62);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(34, 13);
            this.LblNivel.TabIndex = 5;
            this.LblNivel.Text = "Nivel:";
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Location = new System.Drawing.Point(41, 97);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(34, 13);
            this.LblCurso.TabIndex = 6;
            this.LblCurso.Text = "Curso";
            // 
            // LblTituloRepresentante
            // 
            this.LblTituloRepresentante.AutoSize = true;
            this.LblTituloRepresentante.Location = new System.Drawing.Point(501, 24);
            this.LblTituloRepresentante.Name = "LblTituloRepresentante";
            this.LblTituloRepresentante.Size = new System.Drawing.Size(77, 13);
            this.LblTituloRepresentante.TabIndex = 7;
            this.LblTituloRepresentante.Text = "Representante";
            // 
            // TxtRutRepresentante
            // 
            this.TxtRutRepresentante.Location = new System.Drawing.Point(504, 60);
            this.TxtRutRepresentante.MaxLength = 8;
            this.TxtRutRepresentante.Name = "TxtRutRepresentante";
            this.TxtRutRepresentante.Size = new System.Drawing.Size(101, 20);
            this.TxtRutRepresentante.TabIndex = 4;
            this.TxtRutRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRutRepresentante_KeyPress);
            // 
            // TxtEmailRepresentante
            // 
            this.TxtEmailRepresentante.Location = new System.Drawing.Point(504, 116);
            this.TxtEmailRepresentante.MaxLength = 50;
            this.TxtEmailRepresentante.Name = "TxtEmailRepresentante";
            this.TxtEmailRepresentante.Size = new System.Drawing.Size(164, 20);
            this.TxtEmailRepresentante.TabIndex = 7;
            this.TxtEmailRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailRepresentante_KeyPress);
            // 
            // TxtNombreRepresentante
            // 
            this.TxtNombreRepresentante.Location = new System.Drawing.Point(504, 87);
            this.TxtNombreRepresentante.MaxLength = 50;
            this.TxtNombreRepresentante.Name = "TxtNombreRepresentante";
            this.TxtNombreRepresentante.Size = new System.Drawing.Size(164, 20);
            this.TxtNombreRepresentante.TabIndex = 6;
            this.TxtNombreRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreRepresentante_KeyPress);
            // 
            // LblNombreRepresentante
            // 
            this.LblNombreRepresentante.AutoSize = true;
            this.LblNombreRepresentante.Location = new System.Drawing.Point(425, 90);
            this.LblNombreRepresentante.Name = "LblNombreRepresentante";
            this.LblNombreRepresentante.Size = new System.Drawing.Size(44, 13);
            this.LblNombreRepresentante.TabIndex = 11;
            this.LblNombreRepresentante.Text = "Nombre";
            // 
            // LblEmailRepresentante
            // 
            this.LblEmailRepresentante.AutoSize = true;
            this.LblEmailRepresentante.Location = new System.Drawing.Point(425, 119);
            this.LblEmailRepresentante.Name = "LblEmailRepresentante";
            this.LblEmailRepresentante.Size = new System.Drawing.Size(41, 13);
            this.LblEmailRepresentante.TabIndex = 12;
            this.LblEmailRepresentante.Text = "E - mail";
            // 
            // LblRutRepresentante
            // 
            this.LblRutRepresentante.AutoSize = true;
            this.LblRutRepresentante.Location = new System.Drawing.Point(425, 63);
            this.LblRutRepresentante.Name = "LblRutRepresentante";
            this.LblRutRepresentante.Size = new System.Drawing.Size(24, 13);
            this.LblRutRepresentante.TabIndex = 13;
            this.LblRutRepresentante.Text = "Rut";
            // 
            // BtnGuardarCurso
            // 
            this.BtnGuardarCurso.Location = new System.Drawing.Point(551, 256);
            this.BtnGuardarCurso.Name = "BtnGuardarCurso";
            this.BtnGuardarCurso.Size = new System.Drawing.Size(95, 49);
            this.BtnGuardarCurso.TabIndex = 8;
            this.BtnGuardarCurso.Text = "Guardar Curso";
            this.BtnGuardarCurso.UseVisualStyleBackColor = true;
            this.BtnGuardarCurso.Click += new System.EventHandler(this.BtnGuardarCurso_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtDvRepresentante
            // 
            this.TxtDvRepresentante.Location = new System.Drawing.Point(623, 61);
            this.TxtDvRepresentante.MaxLength = 1;
            this.TxtDvRepresentante.Name = "TxtDvRepresentante";
            this.TxtDvRepresentante.Size = new System.Drawing.Size(23, 20);
            this.TxtDvRepresentante.TabIndex = 5;
            this.TxtDvRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDvRepresentante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "-";
            // 
            // FrmNuevoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(703, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDvRepresentante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGuardarCurso);
            this.Controls.Add(this.LblRutRepresentante);
            this.Controls.Add(this.LblEmailRepresentante);
            this.Controls.Add(this.LblNombreRepresentante);
            this.Controls.Add(this.TxtNombreRepresentante);
            this.Controls.Add(this.TxtEmailRepresentante);
            this.Controls.Add(this.TxtRutRepresentante);
            this.Controls.Add(this.LblTituloRepresentante);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.LblNivel);
            this.Controls.Add(this.LblTituloCurso);
            this.Controls.Add(this.CmbxNivelBasica);
            this.Controls.Add(this.CmbxNivelMedia);
            this.Controls.Add(this.RdbMedia);
            this.Controls.Add(this.RdbBasica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoCurso";
            this.ShowIcon = false;
            this.Text = "FrmNuevoCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbBasica;
        private System.Windows.Forms.RadioButton RdbMedia;
        private System.Windows.Forms.ComboBox CmbxNivelMedia;
        private System.Windows.Forms.ComboBox CmbxNivelBasica;
        private System.Windows.Forms.Label LblTituloCurso;
        private System.Windows.Forms.Label LblNivel;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.Label LblTituloRepresentante;
        private System.Windows.Forms.TextBox TxtRutRepresentante;
        private System.Windows.Forms.TextBox TxtEmailRepresentante;
        private System.Windows.Forms.TextBox TxtNombreRepresentante;
        private System.Windows.Forms.Label LblNombreRepresentante;
        private System.Windows.Forms.Label LblEmailRepresentante;
        private System.Windows.Forms.Label LblRutRepresentante;
        private System.Windows.Forms.Button BtnGuardarCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtDvRepresentante;
        private System.Windows.Forms.Label label1;
    }
}