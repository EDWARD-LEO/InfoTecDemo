using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;

namespace DESIGNER.Modales
{
    public partial class frmBuscadorProducto : Form
    {
        Producto producto = new Producto();
        DataTable dt = new DataTable();
        DataView dataView;

        //Estos datos se pasarán al formulario de venta
        public int idproducto = -1;
        public string datosProducto = "";
        public decimal precio = 0;
        public int stock = 0;

        public frmBuscadorProducto()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = producto.listar();
            gridProductos.DataSource = dt;
            dataView = dt.DefaultView;

            gridProductos.Refresh();
        }

        private void frmBuscadorProducto_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            gridProductos.Columns[0].Visible = false; //idproducto oculto
            gridProductos.Columns[1].Width = 540;
            gridProductos.Columns[2].Width = 100;
            gridProductos.Columns[3].Width = 100;

            //Alineación derecha las columnas 2-3
            gridProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            gridProductos.ClearSelection();
        }

        private void frmBuscadorProducto_Activated(object sender, EventArgs e)
        {
            txtBuscadorProducto.Focus();
        }

        private void btnReiniciarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscadorProducto.Clear();
            obtenerDatos();
            txtBuscadorProducto.Focus();
        }

        private void txtBuscadorProducto_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "descripcion LIKE '%" + txtBuscadorProducto.Text.Trim() + "%'";
        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.Rows.Count > 0)
            {
                idproducto = Convert.ToInt32(gridProductos.CurrentRow.Cells[0].Value);
                datosProducto = gridProductos.CurrentRow.Cells[1].Value.ToString();
                stock = Convert.ToInt32(gridProductos.CurrentRow.Cells[2].Value);
                precio = Convert.ToDecimal(gridProductos.CurrentRow.Cells[3].Value);

                this.Close();
            }
            else
            {
                idproducto = -1;
                datosProducto = "";
                precio = 0;
                stock = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            idproducto = -1;
            datosProducto = "";
            precio = 0;
            stock = 0;
            this.Close();
        }
    }
}
