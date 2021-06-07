using PooApps2m1.Depreciacion;
using PooApps2m1.enums;
using PooApps2m1.model;
using PooApps2m1.poco;
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
    public partial class FrmDepreciacion : Form
    {
        public ActivoFijoModel ActivoFijoModel { get; set; }
        public Util util = new Util();
        
        public FrmDepreciacion()
        {
            InitializeComponent();
        }

        private void FrmDepreciacion_Load(object sender, EventArgs e)
        {
            cmbMetodos.Items.AddRange(Enum.GetValues(typeof(MetodoDepreciacion))
                                          .Cast<object>().ToArray());
            cmbMetodos.SelectedIndex = 0;
            cmbMetodos.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDepreciacion();
        }

        private void LoadDepreciacion()
        {
            if(ActivoFijoModel.GetAll() == null)
            {
                return;
            }
            DataTable dt = new DataTable();
            int columns = ActivoFijoModel.GetGreaterVidaUtil();
            for(int j = 0; j <= columns; j++)
            {
                if (j == 0)
                {
                    dt.Columns.Add("Nombre_Activo");
                    continue;
                }
                dt.Columns.Add($"{j}");

            }
            dt.Columns.Add("Total");

            int index = cmbMetodos.SelectedIndex;

            IDepreciacion depreciacion = new DepreciacionFactory()
                .CreateInstance((MetodoDepreciacion)Enum.GetValues(typeof(MetodoDepreciacion))
                                                        .GetValue(index));
            dt.Rows.Clear();
            int k = 0;
            foreach(ActivoFijo af in ActivoFijoModel.GetAll())
            {
                decimal[] deps = depreciacion.Calcular(af.Valor, af.ValorResidual,
                                                        (int)af.TipoActivo);
                string[] rowData = new string[deps.Length + 1];
                DataRow dr = dt.NewRow();
                for (int i = 0; i <= deps.Length; i++)
                {
                    if(i == 0)
                    {
                        dr["Nombre_Activo"] = af.Nombre;
                        //dt.Rows[k].Add(af.Nombre);
                        continue;
                    }
                    //dt.Rows[k].Cells[i].Value = deps[i - 1];
                    dr[$"{i}"] = deps[i - 1];
                }
                dr["Total"] = util.sumatoria(deps);
                dt.Rows.Add(dr);
                k++;
            }
            dgvDepreciacion.DataSource = dt;
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            //if (txtFinder.Text == "")
            //{
            //    dgvDepreciacion.fil
            //}
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDepreciacion.DataSource;
            bs.Filter = "Nombre_Activo like '%" + txtFinder.Text + "%'";
            dgvDepreciacion.DataSource = bs;
        }

        private void cmbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDepreciacion();
        }
    }
}
