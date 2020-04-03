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
    public partial class FrmNuevoContrato : Form
    {
        public int? id_colegio;

        public int? id_curso;

        public FrmNuevoContrato(int? id_colegio = null, int? id_curso = null)
        {
            InitializeComponent();
            this.id_colegio = id_colegio;
            this.id_curso = id_curso;
        }

      
        private void BtnAdjuntar_Click_1(object sender, EventArgs e)
        {
            adjuntarContrato();
        }


        public void adjuntarContrato()
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtAdjuntarArchivo.Text = openFileDialog1.SafeFileName;
            }
        }

        private void BtnGuardarContrato_Click_1(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
                
                try{
                    if (TxtAdjuntarArchivo.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Se debe adjuntar el contrato");
                    }
                    else
                    {

                        int validacionContrato = Convert.ToInt32(ValidarContratoExistente(Convert.ToInt32(id_colegio), Convert.ToInt32(id_curso)));

                        if (validacionContrato == 0)
                        {

                            byte[] documento = null;
                            Stream myStream = openFileDialog1.OpenFile();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                myStream.CopyTo(ms);
                                documento = ms.ToArray();
                            }

                            //NUEVO CONTRATO
                            contrato nuevoContrato = new contrato();
                            nuevoContrato.id_colegio = Convert.ToInt32(id_colegio);
                            nuevoContrato.id_curso = Convert.ToInt32(id_curso);
                            nuevoContrato.fecha_viaje = DtpFechaViaje.Value;
                            nuevoContrato.fecha_tope = DtpFechaTope.Value;
                            nuevoContrato.cantidad_alumnos = Convert.ToInt32(TxtCantidadAlumnos.Text);
                            nuevoContrato.destino = TxtDestino.Text.Trim();
                            nuevoContrato.monto_final = Convert.ToInt32(TxtMontoFinal.Text);
                            nuevoContrato.contrato1 = documento;

                            Base.contrato.Add(nuevoContrato);

                            DialogResult opcion;

                            opcion = MessageBox.Show("¿Guardar contrato?", " Nuevo Contrato ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (DialogResult.Yes == opcion)
                            {
                                Base.SaveChanges();

                                MessageBox.Show("Contrato guardado con éxito" + ("\nId Contrato: " + nuevoContrato.id_contrato));
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Curso mantiene contrato");
                            }
                        }
                        else { MessageBox.Show("Error desconocido"); }
                    }
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error, verifique todos los datos");
                }

        }
        

        private int? ValidarContratoExistente(int v_id_colegio, int v_id_curso)
        {
            using (LaboratorioEntities Base_m = new LaboratorioEntities())
            {
                int contador = 0;

                var validarContrato = from d in Base_m.contrato
                                      select d;
                foreach (var n in validarContrato)
                {
                    if (n.id_colegio == v_id_colegio && n.id_curso == v_id_curso)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ValidarContratoExistente(Convert.ToInt32(id_colegio), Convert.ToInt32(id_curso)).ToString());
        }

        private void BtnAgregarSeguro_Click(object sender, EventArgs e)
        {
            AgregarSeguros();
        }

        public void AgregarSeguros()
        {

            
            
        }


        private void ActualizarSeguros()
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

            {

                var listV = from d in Base.seguros
                            where d.Tipo_de_seguro == "Vida"
                            select d;
                DgvVseguroVida.DataSource = listV.ToList();

                var listVj = from d in Base.seguros
                             where d.Tipo_de_seguro == "Viaje"
                             select d;
                DgvVseguroViaje.DataSource = listVj.ToList();

            }
        }

        private void DgvVseguroViaje_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DgvVseguroVida_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FrmNuevoContrato_Load(object sender, EventArgs e)
        {
            ActualizarSeguros();
        }

        private void BtnAgregarSeguro_Click_1(object sender, EventArgs e)
        {
            AgregarSeguroVida();
        }

        public void AgregarSeguroVida()
        {
            if (TxtCantidadAlumnos.Text == "")
            {
                MessageBox.Show("Se debe proporcionar la cantidad de alumnos");
            }

            else {
                if (DgvVseguroVida.Rows.Count == 0)
                {

                    MessageBox.Show("No hay seguros disponibles");
                }
                else { 


                    DgvVseguroVida.CurrentRow.DefaultCellStyle.BackColor = Color.GreenYellow;


                    using (LaboratorioEntities Base = new LaboratorioEntities())
                    {
                        try
                        {
                            Base.Sp_AgregarSeguroVida(id_curso, Convert.ToInt32(GetIdSeguroVida()));
                            MessageBox.Show("Se agrego seguro");
                            TxtMontoFinal.Text = (Convert.ToInt32(TxtMontoFinal.Text) + (Convert.ToInt32(GetMontoSeguroVida()) * Convert.ToInt32(TxtCantidadAlumnos.Text))).ToString();
                        }
                        catch { MessageBox.Show("No se puede ingresar seguro"); }
                    }
                }
            }

        }

        private void BtnSuprimir_Click(object sender, EventArgs e)
        {
            if (DgvVseguroVida.Rows.Count == 0)
            {
                MessageBox.Show("No hay seguros por eliminar");
            }
            else
            {
                DgvVseguroVida.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                using (LaboratorioEntities Base = new LaboratorioEntities())
                {
                    try
                    {
                        Base.Sp_EliminarSeguroVida(Convert.ToInt32(GetIdSeguroVida()), Convert.ToInt32(id_curso));
                        MessageBox.Show("Se eliminó seguro");
                        TxtMontoFinal.Text = (Convert.ToInt32(TxtMontoFinal.Text) - (Convert.ToInt32(GetMontoSeguroVida()) * Convert.ToInt32(TxtCantidadAlumnos.Text))).ToString();
                    }
                    catch { MessageBox.Show("No se puede eliminar seguro"); }
                }
            }
        }

        public void AgregarSeguroViaje()
        {
            if (TxtCantidadAlumnos.Text == "")
            {
                MessageBox.Show("Se debe proporcionar la cantidad de alumnos");
            }

            else
            {
                if (DgvVseguroViaje.Rows.Count == 0)
                {
                    MessageBox.Show("No hay seguros disponibles");
                }
                else {
                    DgvVseguroViaje.CurrentRow.DefaultCellStyle.BackColor = Color.GreenYellow;


                    using (LaboratorioEntities Base = new LaboratorioEntities())
                    {
                        try
                        {
                            Base.Sp_AgregarSeguroVida(id_curso, Convert.ToInt32(GetIdSeguroViaje()));
                            MessageBox.Show("Se agrego seguro");
                            TxtMontoFinal.Text = (Convert.ToInt32(TxtMontoFinal.Text) + (Convert.ToInt32(GetMontoSeguroViaje()) * Convert.ToInt32(TxtCantidadAlumnos.Text))).ToString();
                        }
                        catch { MessageBox.Show("No se puede ingresar seguro"); }
                    }
                }
            }

        }

        public string GetMontoSeguroVida()
        {
            try
            {

                return DgvVseguroVida.Rows[DgvVseguroVida.CurrentRow.Index].Cells[3].Value.ToString();

            }
            catch { return null; }
        }

        public string GetMontoSeguroViaje()
        {
            try
            {

                return DgvVseguroViaje.Rows[DgvVseguroViaje.CurrentRow.Index].Cells[3].Value.ToString();

            }
            catch { return null; }
        }

        public string GetIdSeguroVida()
        {
            try
            {

                return DgvVseguroVida.Rows[DgvVseguroVida.CurrentRow.Index].Cells[0].Value.ToString();

            }
            catch { return null; }
        }

        public string GetIdSeguroViaje()
        {
            try
            {

                return DgvVseguroViaje.Rows[DgvVseguroViaje.CurrentRow.Index].Cells[0].Value.ToString();

            }
            catch { return null; }
        }

        private void BtnSuprimirViaje_Click(object sender, EventArgs e)
        {
            if (DgvVseguroViaje.Rows.Count == 0)
            {
                MessageBox.Show("No hay seguros por eliminar");
            }
            else {
                DgvVseguroViaje.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                using (LaboratorioEntities Base = new LaboratorioEntities())
                {
                    try
                    {
                        Base.Sp_EliminarSeguroVida(Convert.ToInt32(GetIdSeguroViaje()), Convert.ToInt32(id_curso));
                        MessageBox.Show("Se eliminó seguro");
                        TxtMontoFinal.Text = (Convert.ToInt32(TxtMontoFinal.Text) - (Convert.ToInt32(GetMontoSeguroViaje()) * Convert.ToInt32(TxtCantidadAlumnos.Text))).ToString();
                    }
                    catch { MessageBox.Show("No se puede eliminar seguro"); }
                }
            }
        }

        private void BtnAgregarSeguroViaje_Click(object sender, EventArgs e)
        {
            AgregarSeguroViaje();
        }
    }

}

