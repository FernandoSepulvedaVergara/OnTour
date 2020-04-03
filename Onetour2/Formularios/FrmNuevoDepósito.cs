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
using System.IO;

namespace Onetour2.Formularios
{
    public partial class FrmNuevoDepósito : Form
    {
        Validacion v = new Validacion();
        int? id_fondo;
        string tipo_depósito;
        int? id_curso;

        public FrmNuevoDepósito(int? id_fondo = null, int? id_curso = null)
        {
            InitializeComponent();
            this.id_fondo = id_fondo;
            this.id_curso = id_curso;
        }

        private void InsertarDepósito(int a)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
            }
        }



        
        private void button1_Click_1(object sender, EventArgs e)
        {
            AdjuntarComprobante();
            
        }

        public void AdjuntarComprobante()
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtNombreComprobante.Text = openFileDialog1.SafeFileName;
            }
        }

        private void CmbTipoDepósito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RdbDepósitoApoderado_CheckedChanged(object sender, EventArgs e)
        {
            DgvAlumnosDepósito.Visible = true;
            tipo_depósito = RdbDepósitoApoderado.Text;
        }

        private void RdbDepósitoRepresentante_CheckedChanged(object sender, EventArgs e)
        {
            DgvAlumnosDepósito.Visible = false;
            tipo_depósito = RdbDepósitoRepresentante.Text;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(GetMontoProrrateado()) - Convert.ToInt32(Convert.ToInt32(GetSaldoCuenta()))).ToString());
        }

        private void BtnGuardarDepósito_Click(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

            {
                if (TxtNombreComprobante.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Se debe adjuntar el contrato");
                }
                else
                {
                    if (Convert.ToInt32(GetSaldoCuenta()) >= Convert.ToInt32(GetMontoProrrateado()))

                    {
                        MessageBox.Show("El saldo de la cuenta cumple con el monto prorrateado");
                    }


                    else
                    {
                        if (Convert.ToInt32(textBox1.Text) > (Convert.ToInt32(GetMontoProrrateado()) - Convert.ToInt32(GetSaldoCuenta())))
                        {
                            MessageBox.Show("El monto del dpósito no puede superar el monto prorrateado");
                        }
                        else
                        {


                            byte[] documento = null;
                            Stream myStream = openFileDialog1.OpenFile();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                myStream.CopyTo(ms);
                                documento = ms.ToArray();
                            }

                            //NUEVO DEPÓSITO
                            depositos nuevoDepósito = new depositos();
                            nuevoDepósito.monto = Convert.ToInt32(textBox1.Text);
                            nuevoDepósito.comprobante = documento;
                            nuevoDepósito.fecha = DateTime.Now;
                            nuevoDepósito.tipo = tipo_depósito;

                            if (RdbDepósitoApoderado.Checked)
                            {
                                nuevoDepósito.numero_cuenta = Convert.ToInt32(GetIDCuenta());
                                Base.Sp_actualizarSaldoCuentaAlumno(GetIDCuenta(), Convert.ToInt32(textBox1.Text));

                            }
                            else
                            {
                                nuevoDepósito.numero_cuenta = Convert.ToInt32(id_fondo);
                                Base.Sp_actualizarFondoComún(id_fondo, Convert.ToInt32(textBox1.Text));
                            }
                            Base.depositos.Add(nuevoDepósito);

                            DialogResult opcion;

                            opcion = MessageBox.Show("¿Guardar depósito?", " Nuevo Depósito ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (DialogResult.Yes == opcion)
                            {
                                Base.SaveChanges();

                                MessageBox.Show("Depósito guardado con éxito" + ("\nId Depósito: " + nuevoDepósito.id_depósito));
                                ActualizarCuentaAlumno();

                            }
                             }
                        }
                    
                    }
                }
            }


   public void ActualizarCuentaAlumno()
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())

                try
                {
                    

                    var list = from c in Base.cuenta_alumno
                               where c.id_curso == id_curso
                               select c;
                    DgvAlumnosDepósito.DataSource = list.ToList();
                    
                    
                }
                catch { id_curso = 0; }



        }

        public int? GetIDCuenta()
        {
            try
            {

                return int.Parse(DgvAlumnosDepósito.Rows[DgvAlumnosDepósito.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch { return null; }
        }

        public int? GetSaldoCuenta()
        {
            try
            {

                return int.Parse(DgvAlumnosDepósito.Rows[DgvAlumnosDepósito.CurrentRow.Index].Cells[3].Value.ToString());

            }
            catch { return null; }
        }

        public int? GetMontoProrrateado()
        {
            try
            {

                return int.Parse(DgvAlumnosDepósito.Rows[DgvAlumnosDepósito.CurrentRow.Index].Cells[4].Value.ToString());

            }
            catch { return null; }
        }

        private void FrmNuevoDepósito_Load(object sender, EventArgs e)
        {
            ActualizarCuentaAlumno();
        }

        private void DgvAlumnosDepósito_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

