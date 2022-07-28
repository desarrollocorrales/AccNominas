using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia;
using AccSettings;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmConsultarChecadas : Form
    {
        private int IdInterno;
        private DateTime Fecha;
        
        public FrmConsultarChecadas(DateTime pFecha, int pIdInterno)
        {
            InitializeComponent();
            this.Fecha = pFecha;
            this.IdInterno = pIdInterno;
        }

        private void FrmConsultarChecadas_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            
            lblFecha.Text = this.Fecha.ToShortDateString();
            
            ChecadasDAL oChecadasDAL = new ChecadasDAL();
            gridControl1.DataSource = null;
            gridControl1.DataSource = oChecadasDAL.ObtenerChecadas(IdInterno, this.Fecha, this.Fecha.AddDays(1));
        }

    }
}
