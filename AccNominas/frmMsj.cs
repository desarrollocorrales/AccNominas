using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccNominas
{
    public partial class frmMsj : Form
    {
        string mensaje;
        public frmMsj()
        {
            InitializeComponent();
        }

        public frmMsj(string msj)
        {
            InitializeComponent();
            mensaje = msj;
        }

        private void frmMsj_Load(object sender, EventArgs e)
        {
            if (mensaje != "")
                txtMsj.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
