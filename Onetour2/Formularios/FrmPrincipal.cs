using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Onetour2.Formularios;
using Onetour2.Modelo;

namespace Onetour2.Formularios
{
    public partial class FrmPrincipal : Form
    {
        string tipo_usuario;
        public FrmPrincipal(string tipo_usuario)
        {
            InitializeComponent();
            this.tipo_usuario = tipo_usuario;


        }

        

        private void BtnMenuBuscarYGestionaar_Click_1(object sender, EventArgs e)
        {
            FrmBuscarGestionar nuevoBuscar = new FrmBuscarGestionar(tipo_usuario);
            nuevoBuscar.Show();



        }

        private void segurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeguros gestionarSeguros = new FrmSeguros();
            gestionarSeguros.ShowDialog();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario nuevoUsuario = new FrmNuevoUsuario();
            nuevoUsuario.ShowDialog();
        }

        private void modificarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmModificarUsuario modificarUsuario = new FrmModificarUsuario();
            modificarUsuario.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (tipo_usuario == "Administrador")

            {
                usuariosToolStripMenuItem.Visible = true;

            }
            else
            {
                usuariosToolStripMenuItem.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tipo_usuario);
        }
    }
}
