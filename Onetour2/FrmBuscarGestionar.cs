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

namespace Onetour2
{
    public partial class FrmBuscarGestionar : Form
    {
        string tipo_usuario;
        public FrmBuscarGestionar(string tipo_usuario)
        {
            InitializeComponent();
            this.tipo_usuario = tipo_usuario;
        }

        private void FrmBuscarGestionar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        #region
        public void Actualizar()
        {

            using (LaboratorioEntities Base = new LaboratorioEntities())

            {

                var list = from d in Base.colegio
                           select d;
                Dgv1.DataSource = list.ToList();


            }

        }

        public int? GetID()
        {
            try
            {
                return int.Parse(Dgv1.Rows[Dgv1.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch { return null; }
        }



        #endregion


        private void Actualizando(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

       

        private void SplitContenedor1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBuscarygestionar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmBuscarygestionar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNuevoRegistro_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmNuevoRegistro nuevoRegistro = new Formularios.FrmNuevoRegistro();
            nuevoRegistro.ShowDialog();



            Actualizar();
        }

        private void BtnGestionar_Click_1(object sender, EventArgs e)
        {
            int? id = GetID();
            if (id != null)
            {

                FrmInformación nuevoInfo = new FrmInformación(tipo_usuario, GetID());
                this.Visible = false;
                nuevoInfo.ShowDialog();


                this.Visible = true;



            }
        }

        private void Dgv1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        
    }
}
