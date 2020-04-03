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
using System.IO;
using System.Collections;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;
using System.Globalization;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Onetour2.Formularios
{
    public partial class FrmSeguros : Form
    {
        public FrmSeguros()
        {
            InitializeComponent();
        }

        private void DgvSeguroVida_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DgvSeguroViaje_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BtnNuevoSeguro_Click(object sender, EventArgs e)
        {
            FrmNuevoSeguro nuevoSeguro = new FrmNuevoSeguro();
            nuevoSeguro.ShowDialog();
            ActualizarSeguros();
        }

        private void ActualizarSeguros()
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

            {

                var listV = from d in Base.seguros where d.Tipo_de_seguro == "Vida"
                           select d;
                DgvSeguroVida.DataSource = listV.ToList();

                var listVj = from d in Base.seguros
                           where d.Tipo_de_seguro == "Viaje"
                           select d;
                DgvSeguroViaje.DataSource = listVj.ToList();

            }
        }

        private void FrmSeguros_Load(object sender, EventArgs e)
        {
            ActualizarSeguros();

                    }

        private void button1_Click(object sender, EventArgs e)
        {
            Inhabilitar();
        }

        public int? Getmonto_seguros()
        {
            int MontoSeguros = int.Parse(DgvSeguroVida.Rows[DgvSeguroVida.CurrentRow.Index].Cells[3].Value.ToString());
            return MontoSeguros;
        }

        public void Inhabilitar()
        {
            DgvSeguroVida.Rows[DgvSeguroVida.RowCount - 1].Selected = false;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
