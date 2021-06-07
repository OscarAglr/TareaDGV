using PooApps2m1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooApps2m1
{
    public partial class FrmMdi : Form
    {
        private ActivoFijoModel activoFijoModel;
        public FrmMdi()
        {
            InitializeComponent();
            activoFijoModel = new ActivoFijoModel();
        }

        private void ActivosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmActivos = new Form1();
            frmActivos.ActivoFijoModel = activoFijoModel;
            frmActivos.MdiParent = this;
            frmActivos.Show();
        }

        private void DepreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepreciacion frmDepreciacion = new FrmDepreciacion();
            frmDepreciacion.ActivoFijoModel = activoFijoModel;
            frmDepreciacion.MdiParent = this;
            frmDepreciacion.Show();

        }
    }
}
