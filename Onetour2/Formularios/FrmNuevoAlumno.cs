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
    public partial class FrmNuevoAlumno : Form
    {
        Validacion v = new Validacion();
        int? id_curso;
        int? curso;
        string nivel;
        int? cant_alumnos;

        public FrmNuevoAlumno(int? id_curso = null, int? curso = null, string nivel = null, int? cant_alumnos = null)
        {
            InitializeComponent();
            this.id_curso = id_curso;
            this.curso = curso;
            this.nivel = nivel;
            this.cant_alumnos = cant_alumnos;
        }

        private void BtnGuardarNuevoAlumno_Click_1(object sender, EventArgs e)
        {
            using (LaboratorioEntities BaseAlumno = new LaboratorioEntities())
            {

                try
                {
                    if (v.Validar_email(TxtEmailApoderado) == 1)
                    {
                        if (getCalumnos() == cant_alumnos)
                        {
                            MessageBox.Show("Se han ingresado la cantidad correspondiente de alumnos");
                        }
                        else
                        {
                            //Nuevo Alumno
                            alumno nuevoAlumno = new alumno();

                            nuevoAlumno.rut_alumno = Convert.ToInt32(TxtRutAlumno.Text);
                            nuevoAlumno.dv = TxtDvAlumno.Text;
                            nuevoAlumno.nombre_alumno = TxtNombreAlumno.Text;
                            nuevoAlumno.curso = Convert.ToInt32(curso);
                            nuevoAlumno.nivel = nivel;
                            nuevoAlumno.rut_apoderado = Convert.ToInt32(TxtRutApoderado.Text);
                            nuevoAlumno.id_curso = Convert.ToInt32(id_curso);

                            //NUEVA CUENTA ALUMNO
                            cuenta_alumno nuevaCuentaAlumno = new cuenta_alumno();
                            nuevaCuentaAlumno.rut_alumno = Convert.ToInt32(TxtRutAlumno.Text);
                            nuevaCuentaAlumno.id_curso = Convert.ToInt32(id_curso);
                            nuevaCuentaAlumno.saldo = 0;
                            nuevaCuentaAlumno.monto_prorrateado = 0;

                            //NUEVO APODERADO
                            apoderado nuevoApoderado = new apoderado();
                            nuevoApoderado.rut_apoderado = Convert.ToInt32(TxtRutApoderado.Text);
                            nuevoApoderado.dv = TxtDvApoderado.Text;
                            nuevoApoderado.nombre_apoderado = TxtNombreApoderado.Text;
                            nuevoApoderado.e_mail = TxtEmailApoderado.Text;

                            BaseAlumno.cuenta_alumno.Add(nuevaCuentaAlumno);
                            BaseAlumno.alumno.Add(nuevoAlumno);
                            BaseAlumno.apoderado.Add(nuevoApoderado);

                            DialogResult opcion;

                            opcion = MessageBox.Show("¿Guardar nuevo alumno?", " Nuevo alumno ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (DialogResult.Yes == opcion)
                            {
                                BaseAlumno.SaveChanges();
                                MessageBox.Show("Alumno guardado con éxito" + ("\nNúmero de cuenta: " + nuevoAlumno.id_cuenta.ToString()));

                            }
                        }

                    }
                    else { MessageBox.Show("E-mail no válido"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, compruebe todos los datos" + "\n" + ex.Message.AsParallel());
                }






            }
        }

        private void BtnLimpiarNuevoAlumno_Click_1(object sender, EventArgs e)
        {
            TxtRutAlumno.Clear();
            TxtNombreAlumno.Clear();
            TxtRutApoderado.Clear();
            TxtNombreApoderado.Clear();
            TxtEmailApoderado.Clear();
        }

        private void TxtDvAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarDVRut(e);
        }

        private void TxtRutAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void TxtRutApoderado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void TxtNombreAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void TxtDvApoderado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarDVRut(e);
        }

        private void TxtNombreApoderado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void TxtEmailApoderado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Validar_email(TxtEmailApoderado);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getCalumnos().ToString());
        }


        private int getCalumnos()
        {
            int contador = 0;

            using (LaboratorioEntities Base = new LaboratorioEntities())

                
            {

                var listV = from d in Base.alumno
                            where d.id_curso == id_curso && d.nivel == nivel
                            select d;
                foreach (var n in listV)
                {
                    contador = contador + 1;
                }
                return contador;
            }
        }

    }



}
