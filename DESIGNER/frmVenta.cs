using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;
using DESIGNER.Modales;
using DESIGNER.Herramientas;
using ENTITIES;

namespace DESIGNER
{
    public partial class frmVenta : Form
    {
        //Lógica de negocio (BOL)
        Venta venta = new Venta();
        Producto producto = new Producto();

        //Entidades (ENTITIES)
        EVenta entidadVenta = new EVenta();
        EDetalleventa entidadDV = new EDetalleventa();

        //Objetos
        DataTable dtBuscadorProducto = new DataTable();
        Moneda moneda = new Moneda();

        int idproducto = -1;
        
        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Modales.frmBuscadorClientes formBusqueda = new Modales.frmBuscadorClientes();
            formBusqueda.ShowDialog();

            if (formBusqueda.idcliente != -1)
            {
                //Pasamos el idclietne del modal a la variable declara a nivel de formulario
                entidadVenta.idcliente = formBusqueda.idcliente;

                //Mostramos los datos del cliente en la caja de texto
                txtDatosCliente.Text = formBusqueda.datosCliente;
                lblQuitarCliente.Visible = true;
            }
        }

        private void lblQuitarCliente_Click(object sender, EventArgs e)
        {
            entidadVenta.idcliente = -1;
            txtDatosCliente.Clear();
            lblQuitarCliente.Visible = false;
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la caja no está vacía y además, si se pulso enter...
            if (txtBarCode.Text.Trim() != String.Empty && e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtBuscadorProducto = producto.buscarCodigoBarra(txtBarCode.Text);
                
                if (dtBuscadorProducto.Rows.Count > 0)
                {
                    idproducto = Convert.ToInt32(dtBuscadorProducto.Rows[0][0].ToString());
                    txtDatosProducto.Text = dtBuscadorProducto.Rows[0][1].ToString();
                    txtStock.Text = dtBuscadorProducto.Rows[0][2].ToString();
                    txtPrecio.Text = dtBuscadorProducto.Rows[0][3].ToString();

                    txtCantidad.Maximum = Convert.ToDecimal(txtStock.Text);
                    btnAgregar.Focus();
                }
                else
                {
                    resetCamposProducto();
                }
            }
        }

        private void resetCamposProducto()
        {
            txtBarCode.Clear();
            txtDatosProducto.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtCantidad.Value = 1;
        }

        private bool existeDuplicado(int idtmp)
        {
            int i = 0;
            int cantidadSolicitada = 0;
            decimal nuevoImporte = 0;
            bool encontrado = false;

            //Recorremos todo el datagridview, buscando en la segunda columna si el "idproducto" ya existe
            if (gridProductos.Rows.Count > 0)
            {
                while (i < gridProductos.Rows.Count && !encontrado)
                {
                    //Si lo encontramos verificamos si podemos la cantidad comprada no supera el stock
                    if (Convert.ToInt32(gridProductos.Rows[i].Cells[1].Value) == idtmp)
                    {
                        //Se calcula el total solicitado sumando la cantidad del grid + cantidad ingresada en la caja de texto
                        cantidadSolicitada = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value) + Convert.ToInt32(txtCantidad.Value);

                        if (cantidadSolicitada > Convert.ToInt32(txtStock.Text))
                        {
                            MessageBox.Show(
                                "No podemos atender su pedido porque sobrepasa el stock",
                                "Infotec ventas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtCantidad.Focus();
                        }
                        else
                        {
                            //Si la cantidad que se va a agregar + la cantidad que ya se solicitó, NO sobrepasa el stock, se procede a la actualización
                            gridProductos.Rows[i].Cells[0].Value = cantidadSolicitada;
                            
                            //Calculando nuevo importe
                            nuevoImporte = Convert.ToDecimal(txtPrecio.Text) * cantidadSolicitada;
                            gridProductos.Rows[i].Cells[4].Value = nuevoImporte;

                            resetCamposProducto();
                            txtBarCode.Focus();
                        }

                        encontrado = true;
                    }

                    i++;
                }
            }

            return encontrado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Debemos saber si hemos encontrado un producto
            if (idproducto != -1)
            {
                if (!existeDuplicado(idproducto))
                {
                    decimal importe = Convert.ToDecimal(txtPrecio.Text) * txtCantidad.Value;

                    gridProductos.Rows.Add(txtCantidad.Value.ToString(), idproducto.ToString(), txtDatosProducto.Text, txtPrecio.Text, importe.ToString());
                    actualizarTotales();
                    idproducto = -1;

                    resetCamposProducto();
                    txtBarCode.Focus();
                }
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            //Personalizando ancho de columnas del grid
            gridProductos.Columns[0].Width = 100;
            //gridProductos.Columns[1].Width = 50; * idproducto no está visible *
            gridProductos.Columns[2].Width = 600;
            gridProductos.Columns[3].Width = 100;
            gridProductos.Columns[4].Width = 100;

            //Agregando una columna con botones para quitar producto
            DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
            colBoton.Name = "colQuitar";
            colBoton.Text = "Quitar";
            colBoton.HeaderText = "Quitar";
            colBoton.UseColumnTextForButtonValue = true;
            gridProductos.Columns.Add(colBoton);

            //Valores predeterminados de la entidad
            entidadVenta.tipocomprobante = 'B';
            entidadVenta.numcomprobante = 1; //Para efectos de prueba siempre será 1
            entidadVenta.idcliente = -1;
            entidadVenta.tipopago = "efectivo";

            //Ancho de la última columna agregada
            gridProductos.Columns[5].Width = 100;
        }

        private void actualizarTotales()
        {
            double neto = 0, igv = 0, subtotal = 0;

            if (gridProductos.Rows.Count > 0)
            {
                for (int i = 0; i < gridProductos.Rows.Count; i++)
                {
                    neto += Convert.ToDouble(gridProductos.Rows[i].Cells[4].Value);
                }

                subtotal = neto / 1.18;
                igv = neto - subtotal;
            }

            txtSubTotal.Text = subtotal.ToString("0.00");
            txtIGV.Text = igv.ToString("0.00");
            txtNeto.Text = neto.ToString("0.00");

            lblMontoLetras.Text = moneda.enLetras(txtNeto.Text);
        }

        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.Columns[e.ColumnIndex].Name == "colQuitar")
            {
                string descripcion = gridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (MessageBox.Show(
                    "¿Confirma retirar este producto de la lista?\n" + descripcion, 
                    "Infotec Ventas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridProductos.Rows.RemoveAt(e.RowIndex);
                    actualizarTotales();
                }
            }
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            frmBuscadorProducto frmBuscadorProducto = new frmBuscadorProducto();
            frmBuscadorProducto.ShowDialog();

            if (frmBuscadorProducto.idproducto != -1)
            {
                int stock = frmBuscadorProducto.stock;
                decimal precio = frmBuscadorProducto.precio;

                idproducto = frmBuscadorProducto.idproducto;
                txtDatosProducto.Text = frmBuscadorProducto.datosProducto;
                txtStock.Text = stock.ToString();
                txtPrecio.Text = precio.ToString();
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "efectivo";
        }

        private void optYape_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "yape";
        }

        private void optPlin_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "plin";
        }

        private void optVisa_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "visa";
        }

        private void optDeposito_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "deposito";
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciarProductos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Está seguro de reiniciar la lista de productos actual?",
                "Infotec Ventas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridProductos.Rows.Clear();
                txtSubTotal.Clear();
                txtIGV.Clear();
                txtNeto.Clear();

                txtBarCode.Focus();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Validación #01: Debemos tener al menos un producto en la lista
            if (gridProductos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No ha indicado productos",
                    "Infotec Ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBarCode.Focus();
            }
            else
            {
                //Validación #02: El usuario debe confirmar la intención de guardar
                if (MessageBox.Show(
                    "¿Desea dar por finalizar esta venta?",
                    "Infotec Ventas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Validación #03: Si no se pudo guardar la venta (id = -1), no guardamos el detalle
                    int idVentaObtenido = venta.registrar(entidadVenta);

                    if (idVentaObtenido == -1)
                    {
                        MessageBox.Show(
                            "Existen errores, consulte al administrador del sistema",
                            "Infotec Ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Enviamos todos los datos del datagridview
                        enviarTodosProductos(idVentaObtenido);
                    }
                }
            }
        }

        private void enviarTodosProductos(int idventa)
        {
            for (int i = 0; i < gridProductos.Rows.Count; i++)
            {
                entidadDV.idventa = idventa;
                entidadDV.cantidad = Convert.ToInt32(gridProductos.Rows[i].Cells[0].Value);
                entidadDV.idproducto = Convert.ToInt32(gridProductos.Rows[i].Cells[1].Value);
                entidadDV.precioventa = Convert.ToDecimal(gridProductos.Rows[i].Cells[3].Value);

                venta.registrarDetalle(entidadDV);
            }

            //Al terminar, reiniciará toda la interfaz...
            txtDatosCliente.Clear();
            lblQuitarCliente.Visible = false;

            resetCamposProducto();
            gridProductos.Rows.Clear();

            optBoleta.Checked = true;
            optEfectivo.Checked = true;

            entidadVenta.tipocomprobante = 'B';
            entidadVenta.numcomprobante = 1;
            entidadVenta.idcliente = -1;
            entidadVenta.tipopago = "efectivo";

            lblMontoLetras.Text = "";
            txtSubTotal.Clear();
            txtIGV.Clear();
            txtNeto.Clear();

            MessageBox.Show(
                "Se registró una venta y su detalle correctamente",
                "Infotec Ventas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void optBoleta_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipocomprobante = 'B';
        }

        private void optFactura_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipocomprobante = 'F';
        }
    }
}
