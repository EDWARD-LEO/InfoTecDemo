namespace DESIGNER
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optFactura = new System.Windows.Forms.RadioButton();
            this.optBoleta = new System.Windows.Forms.RadioButton();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatosCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDatosProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReiniciarProductos = new System.Windows.Forms.Button();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDeposito = new System.Windows.Forms.RadioButton();
            this.optVisa = new System.Windows.Forms.RadioButton();
            this.optPlin = new System.Windows.Forms.RadioButton();
            this.optYape = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblQuitarCliente = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMontoLetras = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToResizeRows = false;
            this.gridProductos.BackgroundColor = System.Drawing.Color.White;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colIdProducto,
            this.colDescripcion,
            this.colPrecio,
            this.colImporte});
            this.gridProductos.Location = new System.Drawing.Point(12, 223);
            this.gridProductos.MultiSelect = false;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(1043, 258);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellClick);
            // 
            // colCantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colPrecio
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle11;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colImporte
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle12;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optFactura);
            this.groupBox2.Controls.Add(this.optBoleta);
            this.groupBox2.Controls.Add(this.txtNumDocumento);
            this.groupBox2.Controls.Add(this.lblComprobante);
            this.groupBox2.Location = new System.Drawing.Point(811, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 166);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de comprobante";
            // 
            // optFactura
            // 
            this.optFactura.AutoSize = true;
            this.optFactura.Location = new System.Drawing.Point(116, 126);
            this.optFactura.Name = "optFactura";
            this.optFactura.Size = new System.Drawing.Size(75, 21);
            this.optFactura.TabIndex = 3;
            this.optFactura.Text = "Factura";
            this.optFactura.UseVisualStyleBackColor = true;
            this.optFactura.CheckedChanged += new System.EventHandler(this.optFactura_CheckedChanged);
            // 
            // optBoleta
            // 
            this.optBoleta.AutoSize = true;
            this.optBoleta.Checked = true;
            this.optBoleta.Location = new System.Drawing.Point(37, 126);
            this.optBoleta.Name = "optBoleta";
            this.optBoleta.Size = new System.Drawing.Size(67, 21);
            this.optBoleta.TabIndex = 2;
            this.optBoleta.TabStop = true;
            this.optBoleta.Text = "Boleta";
            this.optBoleta.UseVisualStyleBackColor = true;
            this.optBoleta.CheckedChanged += new System.EventHandler(this.optBoleta_CheckedChanged);
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocumento.Location = new System.Drawing.Point(37, 72);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.ReadOnly = true;
            this.txtNumDocumento.Size = new System.Drawing.Size(154, 37);
            this.txtNumDocumento.TabIndex = 1;
            this.txtNumDocumento.Text = "0000001";
            this.txtNumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobante.Location = new System.Drawing.Point(59, 37);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(110, 32);
            this.lblComprobante.TabIndex = 0;
            this.lblComprobante.Text = "BOLETA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Producto:";
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.Location = new System.Drawing.Point(12, 41);
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.ReadOnly = true;
            this.txtDatosCliente.Size = new System.Drawing.Size(687, 23);
            this.txtDatosCliente.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(705, 41);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(64, 23);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDatosProducto
            // 
            this.txtDatosProducto.Location = new System.Drawing.Point(94, 36);
            this.txtDatosProducto.Name = "txtDatosProducto";
            this.txtDatosProducto.ReadOnly = true;
            this.txtDatosProducto.Size = new System.Drawing.Size(392, 23);
            this.txtDatosProducto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(94, 72);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(71, 23);
            this.txtStock.TabIndex = 4;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(245, 72);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(69, 23);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad:";
            // 
            // btnReiniciarProductos
            // 
            this.btnReiniciarProductos.BackColor = System.Drawing.Color.White;
            this.btnReiniciarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarProductos.ForeColor = System.Drawing.Color.Red;
            this.btnReiniciarProductos.Location = new System.Drawing.Point(17, 11);
            this.btnReiniciarProductos.Name = "btnReiniciarProductos";
            this.btnReiniciarProductos.Size = new System.Drawing.Size(148, 25);
            this.btnReiniciarProductos.TabIndex = 0;
            this.btnReiniciarProductos.Text = "Reiniciar productos";
            this.btnReiniciarProductos.UseVisualStyleBackColor = false;
            this.btnReiniciarProductos.Click += new System.EventHandler(this.btnReiniciarProductos_Click);
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.BackColor = System.Drawing.Color.White;
            this.btnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVenta.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarVenta.Location = new System.Drawing.Point(171, 11);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(148, 25);
            this.btnCerrarVenta.TabIndex = 1;
            this.btnCerrarVenta.Text = "Cerrar venta";
            this.btnCerrarVenta.UseVisualStyleBackColor = false;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFinalizar.Location = new System.Drawing.Point(910, 11);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(148, 25);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(885, 488);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(84, 23);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(973, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subtotal";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(885, 514);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(84, 23);
            this.txtIGV.TabIndex = 12;
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(973, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "IGV 18%";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(885, 540);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(84, 23);
            this.txtNeto.TabIndex = 14;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(973, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Neto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDeposito);
            this.groupBox1.Controls.Add(this.optVisa);
            this.groupBox1.Controls.Add(this.optPlin);
            this.groupBox1.Controls.Add(this.optYape);
            this.groupBox1.Controls.Add(this.optEfectivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 57);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidad de pago";
            // 
            // optDeposito
            // 
            this.optDeposito.AutoSize = true;
            this.optDeposito.Location = new System.Drawing.Point(292, 25);
            this.optDeposito.Name = "optDeposito";
            this.optDeposito.Size = new System.Drawing.Size(84, 21);
            this.optDeposito.TabIndex = 5;
            this.optDeposito.Text = "Depósito";
            this.optDeposito.UseVisualStyleBackColor = true;
            this.optDeposito.CheckedChanged += new System.EventHandler(this.optDeposito_CheckedChanged);
            // 
            // optVisa
            // 
            this.optVisa.AutoSize = true;
            this.optVisa.Location = new System.Drawing.Point(235, 25);
            this.optVisa.Name = "optVisa";
            this.optVisa.Size = new System.Drawing.Size(52, 21);
            this.optVisa.TabIndex = 4;
            this.optVisa.Text = "Visa";
            this.optVisa.UseVisualStyleBackColor = true;
            this.optVisa.CheckedChanged += new System.EventHandler(this.optVisa_CheckedChanged);
            // 
            // optPlin
            // 
            this.optPlin.AutoSize = true;
            this.optPlin.Location = new System.Drawing.Point(177, 25);
            this.optPlin.Name = "optPlin";
            this.optPlin.Size = new System.Drawing.Size(48, 21);
            this.optPlin.TabIndex = 3;
            this.optPlin.Text = "Plin";
            this.optPlin.UseVisualStyleBackColor = true;
            this.optPlin.CheckedChanged += new System.EventHandler(this.optPlin_CheckedChanged);
            // 
            // optYape
            // 
            this.optYape.AutoSize = true;
            this.optYape.Location = new System.Drawing.Point(107, 25);
            this.optYape.Name = "optYape";
            this.optYape.Size = new System.Drawing.Size(59, 21);
            this.optYape.TabIndex = 2;
            this.optYape.Text = "Yape";
            this.optYape.UseVisualStyleBackColor = true;
            this.optYape.CheckedChanged += new System.EventHandler(this.optYape_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Location = new System.Drawing.Point(23, 25);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(78, 21);
            this.optEfectivo.TabIndex = 1;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnCerrarVenta);
            this.panel1.Controls.Add(this.btnReiniciarProductos);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Location = new System.Drawing.Point(-5, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 58);
            this.panel1.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(422, 72);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(64, 23);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuitarCliente
            // 
            this.lblQuitarCliente.AutoSize = true;
            this.lblQuitarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitarCliente.ForeColor = System.Drawing.Color.Red;
            this.lblQuitarCliente.Location = new System.Drawing.Point(603, 22);
            this.lblQuitarCliente.Name = "lblQuitarCliente";
            this.lblQuitarCliente.Size = new System.Drawing.Size(96, 16);
            this.lblQuitarCliente.TabIndex = 2;
            this.lblQuitarCliente.Text = "Quitar cliente";
            this.lblQuitarCliente.Visible = false;
            this.lblQuitarCliente.Click += new System.EventHandler(this.lblQuitarCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBarCode);
            this.groupBox4.Location = new System.Drawing.Point(12, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 120);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscador producto";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("barcode font", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(8, 28);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(177, 73);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(492, 36);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(64, 23);
            this.btnListarProductos.TabIndex = 2;
            this.btnListarProductos.Text = "Listar";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnListarProductos);
            this.groupBox3.Controls.Add(this.txtDatosProducto);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.txtStock);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(213, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 120);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(493, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMontoLetras
            // 
            this.lblMontoLetras.Location = new System.Drawing.Point(430, 517);
            this.lblMontoLetras.Name = "lblMontoLetras";
            this.lblMontoLetras.Size = new System.Drawing.Size(416, 35);
            this.lblMontoLetras.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "En letras:";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 636);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMontoLetras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblQuitarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtDatosCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta productos informáticos";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optFactura;
        private System.Windows.Forms.RadioButton optBoleta;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDatosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatosProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnReiniciarProductos;
        private System.Windows.Forms.Button btnCerrarVenta;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDeposito;
        private System.Windows.Forms.RadioButton optVisa;
        private System.Windows.Forms.RadioButton optPlin;
        private System.Windows.Forms.RadioButton optYape;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label lblQuitarCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Label lblMontoLetras;
        private System.Windows.Forms.Label label9;
    }
}