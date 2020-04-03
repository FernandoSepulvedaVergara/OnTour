namespace Onetour2.Formularios
{
    partial class FrmPrincipal
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
            this.BtnMenuBuscarGestionaar = new System.Windows.Forms.MenuStrip();
            this.BtnMenuBuscarYGestionaar = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMenuBuscarGestionaar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMenuBuscarGestionaar
            // 
            this.BtnMenuBuscarGestionaar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMenuBuscarYGestionaar,
            this.segurosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.BtnMenuBuscarGestionaar.Location = new System.Drawing.Point(0, 0);
            this.BtnMenuBuscarGestionaar.Name = "BtnMenuBuscarGestionaar";
            this.BtnMenuBuscarGestionaar.Size = new System.Drawing.Size(800, 24);
            this.BtnMenuBuscarGestionaar.TabIndex = 0;
            this.BtnMenuBuscarGestionaar.Text = "menuStrip1";
            // 
            // BtnMenuBuscarYGestionaar
            // 
            this.BtnMenuBuscarYGestionaar.Name = "BtnMenuBuscarYGestionaar";
            this.BtnMenuBuscarYGestionaar.Size = new System.Drawing.Size(117, 20);
            this.BtnMenuBuscarYGestionaar.Text = "Buscar Y Gestionar";
            this.BtnMenuBuscarYGestionaar.Click += new System.EventHandler(this.BtnMenuBuscarYGestionaar_Click_1);
            // 
            // segurosToolStripMenuItem
            // 
            this.segurosToolStripMenuItem.Name = "segurosToolStripMenuItem";
            this.segurosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.segurosToolStripMenuItem.Text = "Seguros";
            this.segurosToolStripMenuItem.Click += new System.EventHandler(this.segurosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Visible = false;
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem1
            // 
            this.modificarUsuarioToolStripMenuItem1.Name = "modificarUsuarioToolStripMenuItem1";
            this.modificarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.modificarUsuarioToolStripMenuItem1.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenuBuscarGestionaar);
            this.MainMenuStrip = this.BtnMenuBuscarGestionaar;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.BtnMenuBuscarGestionaar.ResumeLayout(false);
            this.BtnMenuBuscarGestionaar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BtnMenuBuscarGestionaar;
        private System.Windows.Forms.ToolStripMenuItem BtnMenuBuscarYGestionaar;
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem1;
    }
}