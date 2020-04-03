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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }
        Validacion v = new Validacion();

        private void TxtRutFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void TxtDvFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarDVRut(e);
        }

        private void TxtNombreFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetrasNombre(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatNombreUsuario(e);
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatNombreUsuario(e);
        }

        private void BtnGuardarUsuario_Click(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

            {
                
                try{ int validarf;
                    validarf = ValidarFuncionario(Convert.ToInt32(TxtRutFuncionario.Text), TxtDvFuncionario.Text);

                    if (validarf == 0)
                    {
                        usuarios nuevoUsuario = new usuarios();
                        nuevoUsuario.nombre_usuario = TxtNombreusuario.Text ;
                        nuevoUsuario.contraseña = TxtContraseña.Text;

                        funcionario nuevoFuncionario = new funcionario();
                        nuevoFuncionario.rut_funcionario = Convert.ToInt32(TxtRutFuncionario.Text);
                        nuevoFuncionario.dv_funcionario = TxtDvFuncionario.Text;
                        nuevoFuncionario.nombre_funcionario = TxtNombreFuncionario.Text;
                        nuevoFuncionario.id_usuario = nuevoUsuario.id_usuario;
                        nuevoFuncionario.rol = CmbTipoFuncionario.SelectedItem.ToString();

                        DialogResult opcion;

                        opcion = MessageBox.Show("¿Guardar usuario?", " Nuevo Usuario ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == opcion)
                        {
                            Base.funcionario.Add(nuevoFuncionario);
                            Base.usuarios.Add(nuevoUsuario);
                            Base.SaveChanges();

                            MessageBox.Show("Usuario guardado con éxito" + ("\nId usuario: " + nuevoUsuario.id_usuario));

                            LimpiarUsuario();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Funcionario existe");
                    }
                }
                catch { MessageBox.Show("Verifique los datos"); }

            }
        }


        public int ValidarFuncionario(int a, string b)
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                int contador = 0;
                var validarFuncionario = from d in Base.funcionario
                                     select d;

                foreach (var n in validarFuncionario)
                {
                    if (n.rut_funcionario == a && n.dv_funcionario == b)
                    {
                        contador = 1;
                        break;
                    }
                    else
                    {
                        contador = 0;
                        
                    }
                }
                return contador;
            }
        }

        public void LimpiarUsuario()
        {
            TxtContraseña.Clear();
            TxtDvFuncionario.Clear();
            TxtNombreFuncionario.Clear();
            TxtRutFuncionario.Clear();
            TxtNombreusuario.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbTipoFuncionario.SelectedItem.ToString());
        }
    }
}
