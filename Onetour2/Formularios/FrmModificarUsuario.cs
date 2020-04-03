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
using Onetour2.Reportes;

namespace Onetour2.Formularios
{
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }
        Validacion v = new Validacion();

        private void DgvFuncionarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        public void ActualizarFuncionarios()

        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

            {

                var list = from d in Base.funcionario

                           select d;
                DgvFuncionarios.DataSource = list.ToList();



            }

        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            ActualizarFuncionarios();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatNombreUsuario(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatNombreUsuario(e);
        }

        public void ActualizarUsuario(int id_usuario, string nombre_usuario, string contraseña)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

            {
                Base.Sp_actualizarUsuario(id_usuario, nombre_usuario, contraseña);
            }
        }


        public string GetId_Usuario()
        {
            try
            {

                return DgvFuncionarios.Rows[DgvFuncionarios.CurrentRow.Index].Cells[3].Value.ToString();

            }
            catch { return null; }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarUsuario(Convert.ToInt32(GetId_Usuario()),TxtNuevoNombreUsuario.Text,TxtNuevaContraseñUsuario.Text);
                MessageBox.Show("Se ha modificado al usuario");
                limpiar();
            }
            catch { MessageBox.Show("Error, verifique los datos"); }
        }

        public void limpiar()
        {
            TxtNuevaContraseñUsuario.Clear();
            TxtNuevoNombreUsuario.Clear();
        }
    }
}
