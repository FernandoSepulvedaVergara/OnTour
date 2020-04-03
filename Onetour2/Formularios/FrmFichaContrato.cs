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
    public partial class FrmFichaContrato : Form
    {
        int v_id_contrato;
        int v_id_curso;

        public FrmFichaContrato(int v_id_contrato , int v_id_curso)
        {
            this.v_id_contrato = v_id_contrato;
            this.v_id_curso = v_id_curso;
            InitializeComponent();
        }


        
        private void FrmFichaContrato_Load(object sender, EventArgs e)
        {
            FichaContrato(this.v_id_contrato, this.v_id_curso, TxtIdCurso, TXtCurso, TxtNivelCurso, TxtIdFondo, TxtIdCOlegio, TxtNombreColegio, TxtDireccion, TxtComuna,
                           TxtId_contrato, TxtMOntoFinal, TxtCAlumnos, TxtDestino, TxtFechaViaje, TXtFechaTope);
        }


        private void FichaContrato(int v_id_contrato, int v_id_curso, TextBox id_curso, TextBox ncurso, TextBox nivel, TextBox id_fondo,
                                   TextBox vid_colegio, TextBox nombre_colegio, TextBox direccion, TextBox comuna,
                                   TextBox vid_contrato, TextBox monto_final, TextBox cantidad_alumnos, TextBox destino, TextBox fecha_viaje, TextBox fecha_tope)
        {
            int id_colegio = 0;

            using (LaboratorioEntities Base = new LaboratorioEntities())
            {
                var curso = from b in Base.curso where b.id_curso == v_id_curso select b;

                       foreach (var t in curso)
                    {

                    id_colegio = t.Colegio_id_colegio;

                    id_curso.Text = t.id_curso.ToString();
                    ncurso.Text = t.curso1.ToString();
                    nivel.Text = t.nivel;
                    id_fondo.Text = t.id_fondo.ToString();


                    break;
                    };

                var colegio = from b in Base.colegio where b.id_colegio == id_colegio select b;

                      foreach (var c in colegio)
                {
                    vid_colegio.Text = c.id_colegio.ToString();
                    nombre_colegio.Text = c.nombre_colegio;
                    direccion.Text = c.direccion_colegio;
                    comuna.Text = c.comuna_colegio;
                    


                    break;
                };

                var contrato = from b in Base.contrato where b.id_curso == v_id_curso select b;

                    foreach (var co in contrato)
                {
                    vid_contrato.Text = co.id_contrato.ToString();
                    monto_final.Text = co.monto_final.ToString();
                    cantidad_alumnos.Text = co.cantidad_alumnos.ToString();
                    destino.Text = co.destino;
                    fecha_viaje.Text = co.fecha_viaje.ToString();
                    fecha_tope.Text = co.fecha_tope.ToString();



                    break;
                };
                //var segurosContratado = from b in Base.seguros_contratados where b.id_curso == v_id_curso select b;

                // var seguros = from b in Base.seguros where b.id_curso == v_id_curso select b;


            }

        }
    }
}
