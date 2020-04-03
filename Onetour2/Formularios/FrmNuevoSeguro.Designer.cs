namespace Onetour2.Formularios
{
    partial class FrmNuevoSeguro
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
            this.CmbTipoSeguro = new System.Windows.Forms.ComboBox();
            this.LblTipoSeguro = new System.Windows.Forms.Label();
            this.LblValorSeguro = new System.Windows.Forms.Label();
            this.TxtValorSeguro = new System.Windows.Forms.TextBox();
            this.TxtDescripcionSeguro = new System.Windows.Forms.TextBox();
            this.LblDescripcionSeguro = new System.Windows.Forms.Label();
            this.BtnGuardarSeguro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbTipoSeguro
            // 
            this.CmbTipoSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoSeguro.FormattingEnabled = true;
            this.CmbTipoSeguro.Items.AddRange(new object[] {
            "Vida",
            "Viaje"});
            this.CmbTipoSeguro.Location = new System.Drawing.Point(28, 61);
            this.CmbTipoSeguro.Name = "CmbTipoSeguro";
            this.CmbTipoSeguro.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoSeguro.TabIndex = 0;
            // 
            // LblTipoSeguro
            // 
            this.LblTipoSeguro.AutoSize = true;
            this.LblTipoSeguro.Location = new System.Drawing.Point(48, 33);
            this.LblTipoSeguro.Name = "LblTipoSeguro";
            this.LblTipoSeguro.Size = new System.Drawing.Size(80, 13);
            this.LblTipoSeguro.TabIndex = 1;
            this.LblTipoSeguro.Text = "Tipo de Seguro";
            // 
            // LblValorSeguro
            // 
            this.LblValorSeguro.AutoSize = true;
            this.LblValorSeguro.Location = new System.Drawing.Point(358, 33);
            this.LblValorSeguro.Name = "LblValorSeguro";
            this.LblValorSeguro.Size = new System.Drawing.Size(68, 13);
            this.LblValorSeguro.TabIndex = 2;
            this.LblValorSeguro.Text = "Valor Seguro";
            // 
            // TxtValorSeguro
            // 
            this.TxtValorSeguro.Location = new System.Drawing.Point(343, 61);
            this.TxtValorSeguro.MaxLength = 10;
            this.TxtValorSeguro.Name = "TxtValorSeguro";
            this.TxtValorSeguro.Size = new System.Drawing.Size(100, 20);
            this.TxtValorSeguro.TabIndex = 3;
            this.TxtValorSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorSeguro_KeyPress);
            // 
            // TxtDescripcionSeguro
            // 
            this.TxtDescripcionSeguro.Location = new System.Drawing.Point(27, 137);
            this.TxtDescripcionSeguro.Name = "TxtDescripcionSeguro";
            this.TxtDescripcionSeguro.Size = new System.Drawing.Size(359, 20);
            this.TxtDescripcionSeguro.TabIndex = 4;
            // 
            // LblDescripcionSeguro
            // 
            this.LblDescripcionSeguro.AutoSize = true;
            this.LblDescripcionSeguro.Location = new System.Drawing.Point(39, 110);
            this.LblDescripcionSeguro.Name = "LblDescripcionSeguro";
            this.LblDescripcionSeguro.Size = new System.Drawing.Size(100, 13);
            this.LblDescripcionSeguro.TabIndex = 5;
            this.LblDescripcionSeguro.Text = "Descripción Seguro";
            // 
            // BtnGuardarSeguro
            // 
            this.BtnGuardarSeguro.Location = new System.Drawing.Point(343, 210);
            this.BtnGuardarSeguro.Name = "BtnGuardarSeguro";
            this.BtnGuardarSeguro.Size = new System.Drawing.Size(100, 43);
            this.BtnGuardarSeguro.TabIndex = 6;
            this.BtnGuardarSeguro.Text = "Guardar";
            this.BtnGuardarSeguro.UseVisualStyleBackColor = true;
            this.BtnGuardarSeguro.Click += new System.EventHandler(this.BtnGuardarSeguro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNuevoSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGuardarSeguro);
            this.Controls.Add(this.LblDescripcionSeguro);
            this.Controls.Add(this.TxtDescripcionSeguro);
            this.Controls.Add(this.TxtValorSeguro);
            this.Controls.Add(this.LblValorSeguro);
            this.Controls.Add(this.LblTipoSeguro);
            this.Controls.Add(this.CmbTipoSeguro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoSeguro";
            this.ShowIcon = false;
            this.Text = "Nuevo Seguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTipoSeguro;
        private System.Windows.Forms.Label LblTipoSeguro;
        private System.Windows.Forms.Label LblValorSeguro;
        private System.Windows.Forms.TextBox TxtValorSeguro;
        private System.Windows.Forms.TextBox TxtDescripcionSeguro;
        private System.Windows.Forms.Label LblDescripcionSeguro;
        private System.Windows.Forms.Button BtnGuardarSeguro;
        private System.Windows.Forms.Button button1;
    }
}