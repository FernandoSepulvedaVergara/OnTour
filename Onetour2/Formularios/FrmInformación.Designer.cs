namespace Onetour2.Formularios
{
    partial class FrmInformación
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
            this.BtnInfoCurso = new System.Windows.Forms.Button();
            this.TxtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.LblInfoColegioDireccion = new System.Windows.Forms.Label();
            this.LblInfoColegioComuna = new System.Windows.Forms.Label();
            this.LblInfoColegioNombre = new System.Windows.Forms.Label();
            this.LblInfoColegioId = new System.Windows.Forms.Label();
            this.LblTituloInfo = new System.Windows.Forms.Label();
            this.TxtInfoNombreColegio = new System.Windows.Forms.TextBox();
            this.TxtInfoColegioDireccion = new System.Windows.Forms.TextBox();
            this.TxtInfoColegioComuna = new System.Windows.Forms.TextBox();
            this.TxtInfoColegioID = new System.Windows.Forms.TextBox();
            this.BtnVerContrato = new System.Windows.Forms.Button();
            this.BtnFichaContrato = new System.Windows.Forms.Button();
            this.DgvInfoCursos = new System.Windows.Forms.DataGridView();
            this.DgvInfoAlumnos = new System.Windows.Forms.DataGridView();
            this.BtnNuevoDepósito = new System.Windows.Forms.Button();
            this.BtnContrato = new System.Windows.Forms.Button();
            this.BtnAtras1 = new System.Windows.Forms.Button();
            this.BtnNuevoContrato = new System.Windows.Forms.Button();
            this.BtnVerCuentaAlumno = new System.Windows.Forms.Button();
            this.BtnNuevoAlumno = new System.Windows.Forms.Button();
            this.BtnGestionarCurso = new System.Windows.Forms.Button();
            this.BtnNuevoCurso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoAlumnos)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnInfoCurso);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCantidadAlumnos);
            this.splitContainer1.Panel1.Controls.Add(this.LblInfoColegioDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.LblInfoColegioComuna);
            this.splitContainer1.Panel1.Controls.Add(this.LblInfoColegioNombre);
            this.splitContainer1.Panel1.Controls.Add(this.LblInfoColegioId);
            this.splitContainer1.Panel1.Controls.Add(this.LblTituloInfo);
            this.splitContainer1.Panel1.Controls.Add(this.TxtInfoNombreColegio);
            this.splitContainer1.Panel1.Controls.Add(this.TxtInfoColegioDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.TxtInfoColegioComuna);
            this.splitContainer1.Panel1.Controls.Add(this.TxtInfoColegioID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.BtnVerContrato);
            this.splitContainer1.Panel2.Controls.Add(this.BtnFichaContrato);
            this.splitContainer1.Panel2.Controls.Add(this.DgvInfoCursos);
            this.splitContainer1.Panel2.Controls.Add(this.DgvInfoAlumnos);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNuevoDepósito);
            this.splitContainer1.Panel2.Controls.Add(this.BtnContrato);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAtras1);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNuevoContrato);
            this.splitContainer1.Panel2.Controls.Add(this.BtnVerCuentaAlumno);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNuevoAlumno);
            this.splitContainer1.Panel2.Controls.Add(this.BtnGestionarCurso);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNuevoCurso);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnInfoCurso
            // 
            this.BtnInfoCurso.Location = new System.Drawing.Point(17, 98);
            this.BtnInfoCurso.Name = "BtnInfoCurso";
            this.BtnInfoCurso.Size = new System.Drawing.Size(127, 43);
            this.BtnInfoCurso.TabIndex = 9;
            this.BtnInfoCurso.Text = "Info Curso";
            this.BtnInfoCurso.UseVisualStyleBackColor = true;
            this.BtnInfoCurso.Visible = false;
            // 
            // TxtCantidadAlumnos
            // 
            this.TxtCantidadAlumnos.Location = new System.Drawing.Point(605, 111);
            this.TxtCantidadAlumnos.Name = "TxtCantidadAlumnos";
            this.TxtCantidadAlumnos.Size = new System.Drawing.Size(128, 20);
            this.TxtCantidadAlumnos.TabIndex = 10;
            this.TxtCantidadAlumnos.Visible = false;
            this.TxtCantidadAlumnos.TextChanged += new System.EventHandler(this.TxtCantidadAlumnos_TextChanged);
            this.TxtCantidadAlumnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadAlumnos_KeyPress);
            // 
            // LblInfoColegioDireccion
            // 
            this.LblInfoColegioDireccion.AutoSize = true;
            this.LblInfoColegioDireccion.Location = new System.Drawing.Point(541, 24);
            this.LblInfoColegioDireccion.Name = "LblInfoColegioDireccion";
            this.LblInfoColegioDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblInfoColegioDireccion.TabIndex = 8;
            this.LblInfoColegioDireccion.Text = "Dirección";
            // 
            // LblInfoColegioComuna
            // 
            this.LblInfoColegioComuna.AutoSize = true;
            this.LblInfoColegioComuna.Location = new System.Drawing.Point(541, 50);
            this.LblInfoColegioComuna.Name = "LblInfoColegioComuna";
            this.LblInfoColegioComuna.Size = new System.Drawing.Size(46, 13);
            this.LblInfoColegioComuna.TabIndex = 7;
            this.LblInfoColegioComuna.Text = "Comuna";
            // 
            // LblInfoColegioNombre
            // 
            this.LblInfoColegioNombre.AutoSize = true;
            this.LblInfoColegioNombre.Location = new System.Drawing.Point(28, 50);
            this.LblInfoColegioNombre.Name = "LblInfoColegioNombre";
            this.LblInfoColegioNombre.Size = new System.Drawing.Size(82, 13);
            this.LblInfoColegioNombre.TabIndex = 6;
            this.LblInfoColegioNombre.Text = "Nombre Colegio";
            // 
            // LblInfoColegioId
            // 
            this.LblInfoColegioId.AutoSize = true;
            this.LblInfoColegioId.Location = new System.Drawing.Point(28, 24);
            this.LblInfoColegioId.Name = "LblInfoColegioId";
            this.LblInfoColegioId.Size = new System.Drawing.Size(53, 13);
            this.LblInfoColegioId.TabIndex = 5;
            this.LblInfoColegioId.Text = "Id colegio";
            // 
            // LblTituloInfo
            // 
            this.LblTituloInfo.AutoSize = true;
            this.LblTituloInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInfo.ForeColor = System.Drawing.Color.MediumBlue;
            this.LblTituloInfo.Location = new System.Drawing.Point(444, 98);
            this.LblTituloInfo.Name = "LblTituloInfo";
            this.LblTituloInfo.Size = new System.Drawing.Size(114, 33);
            this.LblTituloInfo.TabIndex = 4;
            this.LblTituloInfo.Text = "Cursos";
            // 
            // TxtInfoNombreColegio
            // 
            this.TxtInfoNombreColegio.Enabled = false;
            this.TxtInfoNombreColegio.Location = new System.Drawing.Point(116, 47);
            this.TxtInfoNombreColegio.Name = "TxtInfoNombreColegio";
            this.TxtInfoNombreColegio.Size = new System.Drawing.Size(128, 20);
            this.TxtInfoNombreColegio.TabIndex = 3;
            // 
            // TxtInfoColegioDireccion
            // 
            this.TxtInfoColegioDireccion.Enabled = false;
            this.TxtInfoColegioDireccion.Location = new System.Drawing.Point(605, 21);
            this.TxtInfoColegioDireccion.Name = "TxtInfoColegioDireccion";
            this.TxtInfoColegioDireccion.Size = new System.Drawing.Size(130, 20);
            this.TxtInfoColegioDireccion.TabIndex = 2;
            // 
            // TxtInfoColegioComuna
            // 
            this.TxtInfoColegioComuna.Enabled = false;
            this.TxtInfoColegioComuna.Location = new System.Drawing.Point(605, 47);
            this.TxtInfoColegioComuna.Name = "TxtInfoColegioComuna";
            this.TxtInfoColegioComuna.Size = new System.Drawing.Size(130, 20);
            this.TxtInfoColegioComuna.TabIndex = 1;
            // 
            // TxtInfoColegioID
            // 
            this.TxtInfoColegioID.Enabled = false;
            this.TxtInfoColegioID.Location = new System.Drawing.Point(116, 21);
            this.TxtInfoColegioID.Name = "TxtInfoColegioID";
            this.TxtInfoColegioID.Size = new System.Drawing.Size(128, 20);
            this.TxtInfoColegioID.TabIndex = 0;
            this.TxtInfoColegioID.TextChanged += new System.EventHandler(this.TxtInfoColegioID_TextChanged);
            // 
            // BtnVerContrato
            // 
            this.BtnVerContrato.Location = new System.Drawing.Point(18, 141);
            this.BtnVerContrato.Name = "BtnVerContrato";
            this.BtnVerContrato.Size = new System.Drawing.Size(83, 30);
            this.BtnVerContrato.TabIndex = 10;
            this.BtnVerContrato.Text = "Ver Contrato";
            this.BtnVerContrato.UseVisualStyleBackColor = true;
            this.BtnVerContrato.Visible = false;
            this.BtnVerContrato.Click += new System.EventHandler(this.BtnVerContrato_Click);
            // 
            // BtnFichaContrato
            // 
            this.BtnFichaContrato.Location = new System.Drawing.Point(17, 104);
            this.BtnFichaContrato.Name = "BtnFichaContrato";
            this.BtnFichaContrato.Size = new System.Drawing.Size(92, 31);
            this.BtnFichaContrato.TabIndex = 9;
            this.BtnFichaContrato.Text = "Ficha Contrato";
            this.BtnFichaContrato.UseVisualStyleBackColor = true;
            this.BtnFichaContrato.Visible = false;
            this.BtnFichaContrato.Click += new System.EventHandler(this.BtnFichaContrato_Click);
            // 
            // DgvInfoCursos
            // 
            this.DgvInfoCursos.AllowUserToAddRows = false;
            this.DgvInfoCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInfoCursos.Location = new System.Drawing.Point(123, 6);
            this.DgvInfoCursos.Name = "DgvInfoCursos";
            this.DgvInfoCursos.ReadOnly = true;
            this.DgvInfoCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInfoCursos.Size = new System.Drawing.Size(677, 295);
            this.DgvInfoCursos.TabIndex = 0;
            this.DgvInfoCursos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvInfoCursos_DataError);
            // 
            // DgvInfoAlumnos
            // 
            this.DgvInfoAlumnos.AllowUserToAddRows = false;
            this.DgvInfoAlumnos.BackgroundColor = System.Drawing.Color.LightGreen;
            this.DgvInfoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInfoAlumnos.Location = new System.Drawing.Point(123, 6);
            this.DgvInfoAlumnos.Name = "DgvInfoAlumnos";
            this.DgvInfoAlumnos.ReadOnly = true;
            this.DgvInfoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInfoAlumnos.Size = new System.Drawing.Size(677, 295);
            this.DgvInfoAlumnos.TabIndex = 1;
            this.DgvInfoAlumnos.Visible = false;
            this.DgvInfoAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInfoAlumnos_CellContentClick);
            this.DgvInfoAlumnos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvInfoAlumnos_DataError_1);
            // 
            // BtnNuevoDepósito
            // 
            this.BtnNuevoDepósito.Location = new System.Drawing.Point(17, 55);
            this.BtnNuevoDepósito.Name = "BtnNuevoDepósito";
            this.BtnNuevoDepósito.Size = new System.Drawing.Size(83, 43);
            this.BtnNuevoDepósito.TabIndex = 2;
            this.BtnNuevoDepósito.Text = "Nuevo Depósito";
            this.BtnNuevoDepósito.UseVisualStyleBackColor = true;
            this.BtnNuevoDepósito.Visible = false;
            this.BtnNuevoDepósito.Click += new System.EventHandler(this.BtnNuevoDepósito_Click);
            // 
            // BtnContrato
            // 
            this.BtnContrato.Location = new System.Drawing.Point(17, 104);
            this.BtnContrato.Name = "BtnContrato";
            this.BtnContrato.Size = new System.Drawing.Size(83, 43);
            this.BtnContrato.TabIndex = 8;
            this.BtnContrato.Text = "Contrato";
            this.BtnContrato.UseVisualStyleBackColor = true;
            this.BtnContrato.Visible = false;
            this.BtnContrato.Click += new System.EventHandler(this.BtnContrato_Click);
            // 
            // BtnAtras1
            // 
            this.BtnAtras1.Location = new System.Drawing.Point(17, 261);
            this.BtnAtras1.Name = "BtnAtras1";
            this.BtnAtras1.Size = new System.Drawing.Size(83, 28);
            this.BtnAtras1.TabIndex = 7;
            this.BtnAtras1.Text = "Atrás";
            this.BtnAtras1.UseVisualStyleBackColor = true;
            this.BtnAtras1.Visible = false;
            this.BtnAtras1.Click += new System.EventHandler(this.BtnAtras1_Click_1);
            // 
            // BtnNuevoContrato
            // 
            this.BtnNuevoContrato.Location = new System.Drawing.Point(17, 104);
            this.BtnNuevoContrato.Name = "BtnNuevoContrato";
            this.BtnNuevoContrato.Size = new System.Drawing.Size(83, 43);
            this.BtnNuevoContrato.TabIndex = 6;
            this.BtnNuevoContrato.Text = "Ingresar Contrato";
            this.BtnNuevoContrato.UseVisualStyleBackColor = true;
            this.BtnNuevoContrato.Visible = false;
            this.BtnNuevoContrato.Click += new System.EventHandler(this.BtnNuevoContrato_Click);
            // 
            // BtnVerCuentaAlumno
            // 
            this.BtnVerCuentaAlumno.Location = new System.Drawing.Point(18, 218);
            this.BtnVerCuentaAlumno.Name = "BtnVerCuentaAlumno";
            this.BtnVerCuentaAlumno.Size = new System.Drawing.Size(83, 30);
            this.BtnVerCuentaAlumno.TabIndex = 5;
            this.BtnVerCuentaAlumno.Text = "Ver cuenta";
            this.BtnVerCuentaAlumno.UseVisualStyleBackColor = true;
            this.BtnVerCuentaAlumno.Visible = false;
            this.BtnVerCuentaAlumno.Click += new System.EventHandler(this.BtnVerCuentaAlumno_Click_1);
            // 
            // BtnNuevoAlumno
            // 
            this.BtnNuevoAlumno.Location = new System.Drawing.Point(18, 177);
            this.BtnNuevoAlumno.Name = "BtnNuevoAlumno";
            this.BtnNuevoAlumno.Size = new System.Drawing.Size(83, 35);
            this.BtnNuevoAlumno.TabIndex = 4;
            this.BtnNuevoAlumno.Text = "Nuevo Alumno";
            this.BtnNuevoAlumno.UseVisualStyleBackColor = true;
            this.BtnNuevoAlumno.Visible = false;
            this.BtnNuevoAlumno.Click += new System.EventHandler(this.BtnNuevoAlumno_Click_1);
            // 
            // BtnGestionarCurso
            // 
            this.BtnGestionarCurso.Location = new System.Drawing.Point(17, 55);
            this.BtnGestionarCurso.Name = "BtnGestionarCurso";
            this.BtnGestionarCurso.Size = new System.Drawing.Size(83, 43);
            this.BtnGestionarCurso.TabIndex = 2;
            this.BtnGestionarCurso.Text = "Gestionar Curso";
            this.BtnGestionarCurso.UseVisualStyleBackColor = true;
            this.BtnGestionarCurso.Click += new System.EventHandler(this.BtnGestionarCurso_Click_1);
            // 
            // BtnNuevoCurso
            // 
            this.BtnNuevoCurso.Location = new System.Drawing.Point(17, 6);
            this.BtnNuevoCurso.Name = "BtnNuevoCurso";
            this.BtnNuevoCurso.Size = new System.Drawing.Size(83, 43);
            this.BtnNuevoCurso.TabIndex = 1;
            this.BtnNuevoCurso.Text = "Nuevo Curso";
            this.BtnNuevoCurso.UseVisualStyleBackColor = true;
            this.BtnNuevoCurso.Click += new System.EventHandler(this.BtnNuevoCurso_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FrmInformación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmInformación";
            this.Text = "FrmInformación";
            this.Load += new System.EventHandler(this.FrmInformación_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInfoAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TxtInfoNombreColegio;
        private System.Windows.Forms.TextBox TxtInfoColegioDireccion;
        private System.Windows.Forms.TextBox TxtInfoColegioComuna;
        private System.Windows.Forms.TextBox TxtInfoColegioID;
        private System.Windows.Forms.Button BtnGestionarCurso;
        private System.Windows.Forms.Button BtnNuevoCurso;
        private System.Windows.Forms.Button BtnNuevoAlumno;
        private System.Windows.Forms.Button BtnAtras1;
        private System.Windows.Forms.Button BtnNuevoContrato;
        private System.Windows.Forms.Button BtnVerCuentaAlumno;
        private System.Windows.Forms.Button BtnContrato;
        private System.Windows.Forms.Label LblTituloInfo;
        private System.Windows.Forms.Label LblInfoColegioDireccion;
        private System.Windows.Forms.Label LblInfoColegioComuna;
        private System.Windows.Forms.Label LblInfoColegioNombre;
        private System.Windows.Forms.Label LblInfoColegioId;
        private System.Windows.Forms.Button BtnNuevoDepósito;
        private System.Windows.Forms.TextBox TxtCantidadAlumnos;
        private System.Windows.Forms.DataGridView DgvInfoCursos;
        private System.Windows.Forms.DataGridView DgvInfoAlumnos;
        private System.Windows.Forms.Button BtnInfoCurso;
        private System.Windows.Forms.Button BtnVerContrato;
        private System.Windows.Forms.Button BtnFichaContrato;
        private System.Windows.Forms.Button button1;
    }
}