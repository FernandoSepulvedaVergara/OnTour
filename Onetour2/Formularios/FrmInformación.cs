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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Onetour2.Formularios
{
    public partial class FrmInformación : Form
    {
        Validacion v = new Validacion();

        public int? id;
        colegio infoColegio = null;
        contrato infoContrato = null;
        int curso_id;
        int contrato =0;
        int monto;
        int id_curso;
        int id_contrato;
        int c_alumnos;
        string tipo_usuario;
        int v_id_contrato;

        public FrmInformación(string tipo_usuario, int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            this.tipo_usuario = tipo_usuario;
            
                Datos_colegio();
                ValidarContrato();
                
            

        }



        public void Datos_colegio()

        {

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {

                infoColegio = Base.colegio.Find(id);

                TxtInfoColegioID.Text = infoColegio.id_colegio.ToString();
                TxtInfoNombreColegio.Text = infoColegio.nombre_colegio;
                TxtInfoColegioDireccion.Text = infoColegio.direccion_colegio;
                TxtInfoColegioComuna.Text = infoColegio.comuna_colegio;


            }


        }

        public void MontoContrato(int v_idcolegio, int v_idcurso)

        {

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {


                var ValidacionContrato = from d in Base.contrato
                                         select d;
                foreach (var n in ValidacionContrato)
                {
                    if (n.id_colegio == v_idcolegio && n.id_curso == v_idcurso)
                    {
                        monto = n.monto_final/c_alumnos;
                        break;
                    }
                        monto = 0;

                }
            }


        }

        private void BtnNuevoCurso_Click_1(object sender, EventArgs e)
        {
            FrmNuevoCurso nuevoCurso = new FrmNuevoCurso(GetIdColegio());
            nuevoCurso.ShowDialog();

            ActualizarCurso();
            ActualizarCuentaAlumno(curso_id, monto);
            ValidarBtnGes(DgvInfoCursos, BtnGestionarCurso);

        }

        private void FrmInformación_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void FrmInformación_Load_1(object sender, EventArgs e)
        {
            ActualizarCurso();
            ActualizarAlumno();
            ValidarContrato();
            BtnNuevoContrato.Visible = false;

            ValidarBtnGes(DgvInfoCursos, BtnGestionarCurso);

            if (tipo_usuario == "Dueño")

            {
                BtnInfoCurso.Visible = true;

            }
            else
            {
                BtnInfoCurso.Visible = false;
            }
        }





        //Region
        #region
        public void ActualizarCurso()
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())

            {

                var list = from d in Base.curso
                           where d.Colegio_id_colegio == id
                           select d;
                DgvInfoCursos.DataSource = list.ToList();



            }



        }

        public void ActualizarAlumno()
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())

                try
                {
                    curso_id = Convert.ToInt32(GetIDCurso().Value.ToString());

                    var list = from c in Base.alumno
                               where c.id_curso == curso_id
                               select c;
                    DgvInfoAlumnos.DataSource = list.ToList();
                    ActualizarCuentaAlumno(curso_id, monto);

                }
                catch { curso_id = 0; }



        }

        private void Contrato()
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())

                try
                {
                    id_contrato = Convert.ToInt32(GetIDCurso().Value.ToString());

                    var list = from c in Base.contrato
                               where c.id_curso == id_curso
                               select c;
                   
                }
                catch { curso_id = 0; }
        }


        #endregion

        public int? GetIDCurso()
        {
            try
            {

                id_curso = int.Parse(DgvInfoCursos.Rows[DgvInfoCursos.CurrentRow.Index].Cells[0].Value.ToString());
                return int.Parse(DgvInfoCursos.Rows[DgvInfoCursos.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch { return null; }
        }

        public int? GetCurso()
        {
            try
            {

                return int.Parse(DgvInfoCursos.Rows[DgvInfoCursos.CurrentRow.Index].Cells[1].Value.ToString());

            }
            catch { return null; }
        }

        public string GetNivel()
        {
            try
            {

                return DgvInfoCursos.Rows[DgvInfoCursos.CurrentRow.Index].Cells[2].Value.ToString();

            }
            catch { return null; }
        }

        public string GetIDCursoRepre()
        {
            try
            {
                return (DgvInfoCursos.Rows[DgvInfoCursos.CurrentRow.Index].Cells[2].Value.ToString());

            }
            catch { return null; }
        }

        public string GetIDCuentaAlumno()
        {
            try
            {
                return (DgvInfoAlumnos.Rows[DgvInfoAlumnos.CurrentRow.Index].Cells[6].Value.ToString());

            }
            catch { return null; }
        }

        public int GetIdColegio()

        {
            return Convert.ToInt32(TxtInfoColegioID.Text);
        }

        public int? GetIDFondoComún()
        {
            try
            {

                return int.Parse(DgvInfoCursos.Rows[DgvInfoCursos.CurrentRow.Index].Cells[5].Value.ToString());

            }
            catch { return null; }
        }



        private void BtnGestionarCurso_Click_1(object sender, EventArgs e)
        {
            int? id = GetIDCurso();
            string id_repre = GetIDCursoRepre();
            if (id != null)
                M_cantidadAlumnos(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));
            ActualizarAlumno();
            {

                DgvInfoCursos.Visible = false;
                DgvInfoAlumnos.Visible = true;

                BtnNuevoCurso.Visible = false;
                BtnGestionarCurso.Visible = false;
                BtnAtras1.Visible = true;
                
                LblTituloInfo.Text = "Alumnos";
                               

                if (this.contrato >= 1)
                {

                    BtnContrato.Visible = true;
                    BtnNuevoContrato.Visible = false;


                    CantidadAlumnos(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));

                    if (DgvInfoAlumnos.RowCount == c_alumnos)
                    {
                        MontoContrato(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));
                        ActualizarCuentaAlumno(curso_id, monto);
                        BtnNuevoAlumno.Visible = false;
                        BtnNuevoDepósito.Visible = true;
                        BtnVerCuentaAlumno.Visible = true;
                    }
                    else
                    {
                        BtnNuevoAlumno.Visible = true;
                        BtnNuevoDepósito.Visible = false;
                    }
                }
                else
                {
                    BtnNuevoContrato.Visible = true;
                    BtnContrato.Visible = false;
                }



            }

            
            
            Contrato();
            ValidarContrato();


        }
        private void BtnAtras1_Click_1(object sender, EventArgs e)
        {

            DgvInfoCursos.Visible = true;
            DgvInfoAlumnos.Visible = false;
            BtnVerCuentaAlumno.Visible = false;

            BtnNuevoCurso.Visible = true;
            BtnGestionarCurso.Visible = true;
            BtnAtras1.Visible = false;
            BtnNuevoAlumno.Visible = false;
            BtnContrato.Visible = false;
            BtnNuevoContrato.Visible = false;
            BtnNuevoDepósito.Visible = false;
            BtnFichaContrato.Visible = false;
            BtnVerContrato.Visible = false;

            LblTituloInfo.Text = "Cursos";

            ActualizarCurso();
        }




        private void BtnVerCuentaAlumno_Click_1(object sender, EventArgs e)
        {
            FrmCuentaAlumno cuentaAlumno = new FrmCuentaAlumno(Convert.ToInt32(GetIDCuentaAlumno()));
            cuentaAlumno.ShowDialog();
        }

        private void BtnAtrasMeniInfo2_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(id_curso + monto.ToString());
            ActualizarCuentaAlumno(id_curso,monto);

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                var id_contrato = d in Base.contrato 
            }*/

            MessageBox.Show(GetIDCurso().ToString());
        }

        private void BtnNuevoAlumno_Click_1(object sender, EventArgs e)
        {

            FrmNuevoAlumno nuevoAlumno = new FrmNuevoAlumno(GetIDCurso(), GetCurso(), GetNivel(), c_alumnos);
            nuevoAlumno.ShowDialog();
            ActualizarAlumno();

            CantidadAlumnos(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));

            if (DgvInfoAlumnos.RowCount == c_alumnos)
            {
                MontoContrato(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));
                ActualizarCuentaAlumno(curso_id, monto);
                BtnNuevoAlumno.Visible = false;
                BtnNuevoDepósito.Visible = true;
            }
        }

        private void BtnNuevoContrato_Click(object sender, EventArgs e)
        {
            FrmNuevoContrato nuevoContrato = new FrmNuevoContrato(id, GetIDCurso());
            nuevoContrato.Show();

            ValidarContrato();

        }

        private int ValidarContrato()
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                int contador = 0;

                var ValidarContrato = from d in Base.contrato
                                      select d;
                foreach (var n in ValidarContrato)
                {
                    if (n.id_colegio == id && n.id_curso == id_curso)
                    {
                        contador = 1;
                        
                    }
                    else
                    {
                        contador = 0;
                        
                    }
                }
                return contador;

            }


        }

        private void BtnContrato_Click(object sender, EventArgs e)
        {
            BtnFichaContrato.Visible = true;
            BtnVerContrato.Visible = true;
            BtnContrato.Visible = false;
            
                /*using (LaboratorioEntities Base = new LaboratorioEntities())
                {
                    var Document = Base.contrato.Find(v_id_contrato);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullfilepath = folder + Document.id_contrato;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);
                    try
                    {
                        if (File.Exists(fullfilepath))
                            Directory.Delete(fullfilepath);
                    }
                    catch { }
                    File.WriteAllBytes(fullfilepath, Document.contrato1);

                    Process.Start(fullfilepath);
                }*/
            
        }

        private void DgvInfoAlumnos_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DgvInfoCursos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BtnNuevoDepósito_Click(object sender, EventArgs e)
        {
            FrmNuevoDepósito nuevoDepósito = new FrmNuevoDepósito(GetIDFondoComún(), GetIDCurso());
            nuevoDepósito.ShowDialog();
        }

        private void ActualizarCuentaAlumno(int a, int b)
        {
            
            if (DgvInfoAlumnos.RowCount == this.c_alumnos)
            {
                using (LaboratorioEntities Base = new LaboratorioEntities())
                {
                    Base.Sp_actualizarCuentaAlumno(a, b);
                }
            }

        }

        private void DgvContrato_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void TxtCantidadAlumnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCantidadAlumnos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExportarPdf(DgvInfoCursos, "Prueba");
        }

        private void DgvInfoAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*public void ExportarPdf(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250,BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 4;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,10, iTextSharp.text.Font.NORMAL);

            //
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }

            }

            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = filename;
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4,10f,10f,10f,0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            
                    
            }



        }*/

        public void M_cantidadAlumnos(int a, int b)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                

                var ValidacionContrato = from d in Base.contrato
                                      select d;
                foreach (var n in ValidacionContrato)
                {
                    if (n.id_colegio == a && n.id_curso == b)
                    {
                        this.contrato = 1;
                        break;
                    }
                    else
                    {
                        this.contrato = 0;
                        
                    }

                   
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //CantidadAlumnos(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));
            
            CantidadAlumnos(Convert.ToInt32(this.id), Convert.ToInt32(GetIDCurso()));
            MessageBox.Show(c_alumnos.ToString());
        }

        private void TxtInfoColegioID_TextChanged(object sender, EventArgs e)
        {

        }

        public void CantidadAlumnos(int a, int b)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
            {


                var ValidacionContrato = from d in Base.contrato
                                         select d;
                foreach (var n in ValidacionContrato)
                {
                    if (n.id_colegio == a && n.id_curso == b)
                    {
                        c_alumnos = n.cantidad_alumnos;
                        this.v_id_contrato = n.id_contrato;
                        break;
                    }
                    else
                    {
                        

                    }

                    

                }
            }
        }

        public void ValidarBtnGes(DataGridView dgv, Button btnGes)
        {

            if (dgv.RowCount == 0)
            {
                btnGes.Visible = false;
            }

            else
            {
                btnGes.Visible = true;
            }

        }

        private void BtnVerContrato_Click(object sender, EventArgs e)
        {
            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                var Document = Base.contrato.Find(v_id_contrato);

                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                string fullfilepath = folder + Document.id_contrato;

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                try
                {
                    if (File.Exists(fullfilepath))
                        Directory.Delete(fullfilepath);
                }
                catch { }
                File.WriteAllBytes(fullfilepath, Document.contrato1);

                Process.Start(fullfilepath);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(this.v_id_contrato.ToString());
            MessageBox.Show(this.id_curso.ToString());
        }

        

        private void BtnFichaContrato_Click(object sender, EventArgs e)
        {
            FrmFichaContrato fichaContrato = new FrmFichaContrato(this.v_id_contrato, this.id_curso);
            fichaContrato.ShowDialog();
        }
    }


}








