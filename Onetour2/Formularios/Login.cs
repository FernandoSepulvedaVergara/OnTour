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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string usuario;
        string clave;
        int ingreso;

        string tipo_usuario;
        int puesto;

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            usuario = TxtUsuarioIngreso.Text;
            clave = TxtClaveIngreso.Text;

            ingreso = ValidarIngreso(usuario, clave);

            if (ingreso >= 1)
            {
                
                FrmPrincipal nuevoPrincipal = new FrmPrincipal(tipo_usuario);
                nuevoPrincipal.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }

        }


        public int ValidarIngreso(string a, string b)
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                int contador =0;
                var validarsuario = from d in Base.usuarios 

                                    select d;
                foreach (var n in validarsuario)
                {
                    
                    if (n.nombre_usuario == a && n.contraseña == b)
                    {
                        puesto = n.id_usuario;

                        var validarfun = from f in Base.funcionario

                                         select f;
                        foreach (var m in validarfun)
                        {

                            if (m.id_usuario == puesto)
                            {
                                tipo_usuario = m.rol;
                                break;
                            }
                        }
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



        public int ValidarPuesto(string a, string b)
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                int contador = 0;
                var validarsuario = from d in Base.usuarios

                                    select d;
                foreach (var n in validarsuario)
                {

                    if (n.nombre_usuario == a && n.contraseña == b)
                    {
                        
                        puesto = n.id_usuario;

                        var validarfun = from f in Base.funcionario 

                                            select f;
                        foreach (var m in validarfun)
                        {

                            if (m.id_usuario == puesto)
                            {
                                tipo_usuario = m.rol;
                                break;
                            }
                        }
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
    }
}
