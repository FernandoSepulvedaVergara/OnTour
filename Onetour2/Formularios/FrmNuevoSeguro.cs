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
    public partial class FrmNuevoSeguro : Form
    {
        Validacion v = new Validacion();
        public FrmNuevoSeguro()
        {
            InitializeComponent();
        }

        private void BtnGuardarSeguro_Click(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
                try
                {
                    //NUEVO SEGURO
                    seguros nuevoSeguro = new seguros();
                    nuevoSeguro.Tipo_de_seguro = CmbTipoSeguro.SelectedItem.ToString();
                    nuevoSeguro.descripcion = TxtDescripcionSeguro.Text;
                    nuevoSeguro.valor = Convert.ToInt32(TxtValorSeguro.Text);

                    Base.seguros.Add(nuevoSeguro);

                    DialogResult opcion;

                    opcion = MessageBox.Show("¿Guardar Seguro?", " Nuevo seguro ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == opcion)
                    {
                        Base.SaveChanges();
                        MessageBox.Show("Seguro guardado con éxito" + ("\nNúmero de seguro: " + nuevoSeguro.id_seguro.ToString()));
                        Limpiar();
                    }


                    alumno nuevoalumno = new alumno();
                    nuevoalumno.GetType();

                }
                catch (Exception ex) { MessageBox.Show("Verifique los datos" + "\n" + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbTipoSeguro.SelectedItem.ToString());
        }

        private void Limpiar()
        {
            TxtDescripcionSeguro.Clear();
            TxtValorSeguro.Clear();
        }

        private void TxtValorSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
    }
}
