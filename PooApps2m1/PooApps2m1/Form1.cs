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
    public partial class Form1 : Form
    {
        public ActivoFijoModel ActivoFijoModel { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.AddRange(Enum.GetValues(typeof(TipoActivo))
                                       .Cast<object>()
                                       .ToArray());
            cmbTipo.SelectedIndex = 0;            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;               
                string nombre = txtNombre.Text;
                ValidateActivoFijo(codigo, nombre, out decimal valor, out decimal valorR);
                int index = cmbTipo.SelectedIndex;
                TipoActivo tipo = (TipoActivo)Enum.GetValues(typeof(TipoActivo))
                                                  .GetValue(index);
                ActivoFijo af = new ActivoFijo()
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Valor = valor,
                    ValorResidual = valorR,
                    TipoActivo = tipo                    
                };

                ActivoFijoModel.AddElement(af);
                dgvActivos.DataSource = ActivoFijoModel.GetAll();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateActivoFijo(string codigo, string nombre, out decimal valor, 
            out decimal valorR)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new ArgumentException("El valor de Codigo es requerido!");
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El valor de Nombre es requerido!");
            }

            if (!decimal.TryParse(txtValor.Text, out decimal v))
            {
                throw new ArgumentException($"El valor {txtValor.Text} no es correcto!");
            }
            valor = v;
            if (!decimal.TryParse(txtValorR.Text, out decimal vR))
            {
                throw new ArgumentException($"El valor {txtValorR.Text} no es correcto!");
            }
            valorR = vR;

            if(valor <= 0 || valorR < 0)
            {
                throw new ArgumentException("El valor no puede ser menor o igual a cero.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvActivos.Rows.Count == 0)
            {
                return;
            }
            int index = dgvActivos.CurrentCell.RowIndex;
            ActivoFijoModel.Remove(index);

            dgvActivos.DataSource = ActivoFijoModel.GetAll();
        }
    }
}
