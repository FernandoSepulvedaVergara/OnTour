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
using System.IO;
using Onetour2.Properties;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Onetour2.Formularios
{
    public partial class FrmCuentaAlumno : Form
    {
        int numero_cuenta;
        public FrmCuentaAlumno(int numero_cuenta)
        {
            InitializeComponent();
            this.numero_cuenta = numero_cuenta;
        }


        public void ActualizarCuentaAlumno(int a)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

                try
                {

                    var list = from c in Base.depositos where c.numero_cuenta == a  
                               select c;
                    DgvDepositosAlumno.DataSource = list.ToList();
                }
                catch { ; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DgvDepositosAlumno.Rows.Count > 0)
            {
                int comprobante = int.Parse(DgvDepositosAlumno.Rows[DgvDepositosAlumno.CurrentRow.Index].Cells[0].Value.ToString());

                using (LaboratorioEntities Base = new LaboratorioEntities())
                {
                    var Document = Base.depositos.Find(comprobante);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullfilepath = folder + Document.id_depósito;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    try
                    {
                        if (File.Exists(fullfilepath))
                            Directory.Delete(fullfilepath);
                    }
                    catch { }
                    File.WriteAllBytes(fullfilepath,Document.comprobante);

                    Process.Start(fullfilepath);
                }
            }
        }

        private void FrmCuentaAlumno_Load(object sender, EventArgs e)
        {
            ActualizarCuentaAlumno(numero_cuenta);
        }

        private void DgvDepositosAlumno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        
    }

    
}
