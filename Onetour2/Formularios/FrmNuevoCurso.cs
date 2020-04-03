using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Onetour2.Modelo;
using Onetour2.Formularios;

namespace Onetour2.Formularios
{
    public partial class FrmNuevoCurso : Form
    {
        public int id_colegio;
        public FrmNuevoCurso(int id_colegio)
        

        {
            InitializeComponent();
            this.id_colegio = id_colegio;

        }
        string nivel;
        int Curso;
        Validacion v = new Validacion();
        private void FrmNuevoCurso_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGuardarCurso_Click_1(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

                
                try{
                    int validacionCurso = Convert.ToInt32(ValidarCurso(Curso, nivel));

                    if (validacionCurso == 0)
                    {

                        

                        //NUEVO REPRESENTANTE
                        representante nuevoRepresentante = new representante();
                        nuevoRepresentante.Rut_representante = Convert.ToInt32(TxtRutRepresentante.Text);
                        nuevoRepresentante.dv = TxtDvRepresentante.Text;
                        nuevoRepresentante.nombre_representante = TxtNombreRepresentante.Text;
                        nuevoRepresentante.e_mail = TxtEmailRepresentante.Text;
                        nuevoRepresentante.repre_id_curso = Curso;
                        nuevoRepresentante.repre_nivel_curso = nivel;

                        //NUEVO FONDO COMÚN
                        fondo_común nuevoFondo = new fondo_común();
                        nuevoFondo.rut_representante = Convert.ToInt32(TxtRutRepresentante.Text);
                        nuevoFondo.meta = 0;
                        nuevoFondo.monto_actual = 0;

                        //NUEVO CURSO
                        curso nuevoCurso = new curso();
                        nuevoCurso.curso1 = Curso;
                        nuevoCurso.nivel = nivel;
                        nuevoCurso.Colegio_id_colegio = id_colegio;
                        nuevoCurso.rut_representante = Convert.ToInt32(TxtRutRepresentante.Text);
                        nuevoCurso.id_fondo = nuevoFondo.id_fondo;

                        DialogResult opcion;

                        opcion = MessageBox.Show("¿Guardar curso?", " Nuevo Curso ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == opcion)
                        {
                            Base.curso.Add(nuevoCurso);
                            Base.representante.Add(nuevoRepresentante);
                            Base.fondo_común.Add(nuevoFondo);
                            Base.SaveChanges();

                            MessageBox.Show("Curso guardado con éxito" + ("\nId curso: " + nuevoCurso.id_curso));
                           
                        }
                    }
                    else { MessageBox.Show("Curso ya existe"); }
                }

                 catch (Exception ex) { MessageBox.Show("Error, verifique los datos " + "\n" + ex.Message); }

        }




        private void RdbBasica_CheckedChanged_1(object sender, EventArgs e)
        {
            nivel = RdbBasica.Text;

            CmbxNivelMedia.Visible = false;
            CmbxNivelBasica.Visible = true;
            CmbxNivelMedia.Visible = false;

        }

        private void RdbMedia_CheckedChanged_1(object sender, EventArgs e)
        {
            nivel = RdbMedia.Text;

            CmbxNivelBasica.Visible = false;
            CmbxNivelMedia.Visible = true;
            CmbxNivelBasica.Visible = false;

        }

        private void CmbxNivelMedia_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            Curso = Convert.ToInt32(CmbxNivelMedia.SelectedItem);
        }

        private void CmbxNivelBasica_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Curso = Convert.ToInt32(CmbxNivelBasica.SelectedItem);
        }

        private void FrmNuevoCurso_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BtnComparar_Click(object sender, EventArgs e)
        {
            int validacionCurso = Convert.ToInt32(ValidarCurso(Curso, nivel));
            int contador2 = 0;
            if (validacionCurso == 0)
            {
                contador2 = 1;
                MessageBox.Show("El valor del contador 2 = " + contador2);
            }


        }

        #region
        private static int? ValidarCurso(int curso_m, string nivel_m)
        {
            using (LaboratorioEntities Base_m = new LaboratorioEntities())
            {
                int contador = 0;

                var validarCurso = from d in Base_m.curso
                                   select d;
                foreach (var n in validarCurso)
                {
                    if (n.curso1 == curso_m && n.nivel == nivel_m)
                    {
                        contador = 1;
                        return contador;
                    }
                    else
                    {
                        contador = 0;
                        return contador;
                    }
                }
                return contador;

            }


        }

        private int? Gdfdsd(int curso_m)
        {
            using (LaboratorioEntities Base_m = new LaboratorioEntities())
            {
                var validarFondo = from d in Base_m.curso
                                   where d.Colegio_id_colegio == id_colegio && d.curso1 == Curso
                                   select d;

                return Convert.ToInt32(validarFondo);
            }


        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Curso.ToString() + " " + nivel);
        }

        private void TxtRutRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void TxtDvRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidarDVRut(e);
        }

        private void TxtEmailRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Validar_email(TxtEmailRepresentante);
        }

        private void TxtNombreRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }
    }
}


