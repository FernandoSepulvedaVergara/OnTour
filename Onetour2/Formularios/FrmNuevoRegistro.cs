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
    
    public partial class FrmNuevoRegistro : Form
    {
        Validacion v = new Validacion();
        public FrmNuevoRegistro()
        {
            InitializeComponent();
        }
        public string nivel;
        public int curso;




        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        public void Limpiar()
        {
            TxtIdColegio.Clear();
            TxtNombreColegio.Clear();
            TxtDireccionColegio.Clear();
            TxtComunaColegio.Clear();





        }

        private void FrmNuevoRegistro_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarNuevoRegistro_Click_1(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                try
                {
                    //NUEVO COLEGIO
                    colegio nuevoColegio = new colegio();

                    nuevoColegio.nombre_colegio = TxtNombreColegio.Text;
                    nuevoColegio.direccion_colegio = TxtDireccionColegio.Text;
                    nuevoColegio.comuna_colegio = TxtComunaColegio.Text;


                    Base.colegio.Add(nuevoColegio);



                    try
                    {
                        DialogResult opcion;
                        DialogResult opcion2;

                        opcion = MessageBox.Show("¿Guardar datos?", " Nuevo colegio ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (opcion == DialogResult.Yes)
                        {
                            Base.SaveChanges();

                            opcion2 = MessageBox.Show("¿Insertar cursos?", "Nuevo curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (opcion2 == DialogResult.Yes)
                            {
                                MessageBox.Show("Colegio guardado con éxito" + ("\nId colegio: " + nuevoColegio.id_colegio));
                                this.Close();
                                FrmNuevoCurso nuevoCurso = new FrmNuevoCurso(GetIdColegio());
                                nuevoCurso.ShowDialog();


                            }
                            else

                            {
                                MessageBox.Show("Guardado con éxito" + ("\nId colegio: " + nuevoColegio.id_colegio));

                            }
                        }
                    }
                    catch (Exception) { MessageBox.Show("error"); };







                }

                catch { MessageBox.Show("   Error, compruebe todos los datos"); }





            }
        }

        public int GetIdColegio()

        {
            return Convert.ToInt32(TxtIdColegio.Text);
        }

        private void TxtIdColegio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreColegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatTextbox_1(e);
        }

        private void TxtDireccionColegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatTextbox_1(e);
        }

        private void TxtComunaColegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.ValidatTextbox_3(e);
        }
    }
}


