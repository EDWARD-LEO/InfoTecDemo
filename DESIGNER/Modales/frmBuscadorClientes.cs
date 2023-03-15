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
    public partial class frmBuscadorClientes : Form
    {
        Cliente cliente = new Cliente();
        DataTable dt = new DataTable();
        DataView dataView;

        //Estos datos se pasarán al formulario de venta
        public int idcliente = -1;
        public string datosCliente = "";

        public frmBuscadorClientes()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = cliente.listar();
            gridClientes.DataSource = dt;
            dataView = dt.DefaultView;

            gridClientes.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Si se pulsa este botón, no se enviará nada al proceso VENTA
            idcliente = -1;
            datosCliente = "";

            this.Close();
        }

        private void frmBuscadorClientes_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            //Personalizando apariencia del datagridview
            gridClientes.Columns[0].Visible = false;
            gridClientes.Columns[1].Width = 300;
            gridClientes.Columns[2].Width = 300;
            gridClientes.Columns[3].Width = 130;

            gridClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            gridClientes.ClearSelection();
        }

        private void frmBuscadorClientes_Activated(object sender, EventArgs e)
        {
            txtBuscadorCliente.Focus();
        }

        private void txtBuscadorCliente_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "apellidos like '%" + txtBuscadorCliente.Text.Trim() + "%'";
        }

        private void btnReiniciarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscadorCliente.Clear();
            obtenerDatos();
            txtBuscadorCliente.Focus();
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridClientes.Rows.Count > 0)
            {
                idcliente = Convert.ToInt32(gridClientes.CurrentRow.Cells[0].Value);
                datosCliente = gridClientes.CurrentRow.Cells[1].Value.ToString() + " " + gridClientes.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                idcliente = -1;
                datosCliente = "";
            }
        }
    }
}
