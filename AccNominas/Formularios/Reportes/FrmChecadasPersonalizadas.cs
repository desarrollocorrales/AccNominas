using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia.DAL;
using AccAsistencia;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmChecadasPersonalizadas : Form
    {
        private class NumeroChecada
        {
            public int numeroDeChecada { set; get; }
            public string nombreChecada { set; get; }

            public NumeroChecada(int num, string nom)
            {
                numeroDeChecada = num;
                nombreChecada = nom;
            }
        }

        public FrmChecadasPersonalizadas()
        {
            InitializeComponent();
        }

        private void FrmChecadasPersonalizadas_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ChecadasDAL DAL = new ChecadasDAL();
            DataTable Resultado = DAL.ObtenerChecadasSelectivas(dtpFecha.Value);

            List<ReporteSelectivo> lstRegistro = new List<ReporteSelectivo>();
            foreach (DataRow row in Resultado.Rows)
            {
                ReporteSelectivo r = new ReporteSelectivo();
                r.id_interno = Convert.ToInt32(row["id_interno"]);
                r.nombre = Convert.ToString(row["nombre"]);
                r.checada = Convert.ToDateTime(row["fecha_hora"]);
                lstRegistro.Add(r);
            }

            var query = from x in lstRegistro select x.id_interno;
            List<int> lstIdesInternos = query.Distinct().ToList();

            List<ReporteSelectivo> lstReporteFinal = new List<ReporteSelectivo>();
            foreach (int id in lstIdesInternos)
            {
                string nombre = lstRegistro.Find(o => o.id_interno == id).nombre;
                ReporteSelectivo nuevo = new ReporteSelectivo();
                nuevo.id_interno = id;
                nuevo.nombre = nombre;
                nuevo.checada = null;

                List<ReporteSelectivo> lstAuxiliar = lstRegistro.FindAll(o => o.id_interno == id);
                lstReporteFinal.AddRange(lstAuxiliar);
                switch (lstAuxiliar.Count)
                {
                    case 1:
                        lstReporteFinal.Add(nuevo);
                        lstReporteFinal.Add(nuevo);
                        lstReporteFinal.Add(nuevo);
                        break;
                    case 2:
                        lstReporteFinal.Add(nuevo);
                        lstReporteFinal.Add(nuevo);
                        break;
                    case 3:
                        lstReporteFinal.Add(nuevo);
                        break;
                    case 4: break;
                }
            }

            List<ReporteSelectivo> lstReporteTotal = new List<ReporteSelectivo>();
            foreach (int id in lstIdesInternos)
            {
                ReporteSelectivo rs0 = new ReporteSelectivo();
                rs0.id_interno = id;
                rs0.nombre = lstReporteFinal.Find(o => o.id_interno == id).nombre;
                for (int i = 0; i < 4; i++)
                {
                    ReporteSelectivo rs = lstReporteFinal.FindAll(o => o.id_interno == id)[i];
                    switch (i)
                    {
                        case 0: rs0.checada1 = rs.checada; break;
                        case 1: rs0.checada2 = rs.checada; break;
                        case 2: rs0.checada3 = rs.checada; break;
                        case 3: rs0.checada4 = rs.checada; break;
                    }                    
                }
                lstReporteTotal.Add(rs0);
            }

            gridControl1.DataSource = lstReporteTotal;
            gridView1.BestFitColumns();
        }
    }
}
