namespace SGC_MINIMARKET.Parametros_y_Configuracion
{
    partial class frmPantallaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.imgIconos = new System.Windows.Forms.ImageList(this.components);
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmTransicion = new System.Windows.Forms.Timer(this.components);
            this.btnCompras = new System.Windows.Forms.Button();
            this.flpTransacciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.tmMenuLateral = new System.Windows.Forms.Timer(this.components);
            this.flpMenuLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInventario = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.flpPersonas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.flpAdministracion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.flpReportes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentasFechas = new System.Windows.Forms.Button();
            this.btnComprasProveedor = new System.Windows.Forms.Button();
            this.btnInventarioActual = new System.Windows.Forms.Button();
            this.flpConfiguracion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPreferenciasSistema = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.flpTransacciones.SuspendLayout();
            this.flpMenuLateral.SuspendLayout();
            this.flpInventario.SuspendLayout();
            this.flpPersonas.SuspendLayout();
            this.flpAdministracion.SuspendLayout();
            this.flpReportes.SuspendLayout();
            this.flpConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIconos
            // 
            this.imgIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIconos.ImageStream")));
            this.imgIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIconos.Images.SetKeyName(0, "panel.png");
            this.imgIconos.Images.SetKeyName(1, "iconBuscar.png");
            this.imgIconos.Images.SetKeyName(2, "carrito-de-compras.png");
            this.imgIconos.Images.SetKeyName(3, "bolsa-de-la-compra.png");
            this.imgIconos.Images.SetKeyName(4, "inventario.png");
            this.imgIconos.Images.SetKeyName(5, "usuario.png");
            this.imgIconos.Images.SetKeyName(6, "camion-de-reparto.png");
            this.imgIconos.Images.SetKeyName(7, "informe-seo.png");
            this.imgIconos.Images.SetKeyName(8, "engranaje.png");
            this.imgIconos.Images.SetKeyName(9, "perfil.png");
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(150)))), ((int)(((byte)(179)))));
            this.pnlCabecera.Controls.Add(this.label1);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1000, 60);
            this.pnlCabecera.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "GESTIÓN COMERCIAL";
            // 
            // tmTransicion
            // 
            this.tmTransicion.Interval = 10;
            this.tmTransicion.Tick += new System.EventHandler(this.mnTransicion_Tick);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 100);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(220, 50);
            this.btnCompras.TabIndex = 13;
            this.btnCompras.Text = "          Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // flpTransacciones
            // 
            this.flpTransacciones.BackColor = System.Drawing.Color.Transparent;
            this.flpTransacciones.Controls.Add(this.btnTransacciones);
            this.flpTransacciones.Controls.Add(this.btnVentas);
            this.flpTransacciones.Controls.Add(this.btnCompras);
            this.flpTransacciones.Location = new System.Drawing.Point(3, 53);
            this.flpTransacciones.Name = "flpTransacciones";
            this.flpTransacciones.Size = new System.Drawing.Size(220, 50);
            this.flpTransacciones.TabIndex = 11;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 50);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(220, 50);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "          Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // tmMenuLateral
            // 
            this.tmMenuLateral.Interval = 10;
            this.tmMenuLateral.Tick += new System.EventHandler(this.tmMenuLateral_Tick);
            // 
            // flpMenuLateral
            // 
            this.flpMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(112)))), ((int)(((byte)(151)))));
            this.flpMenuLateral.Controls.Add(this.btnDashboard);
            this.flpMenuLateral.Controls.Add(this.flpTransacciones);
            this.flpMenuLateral.Controls.Add(this.flpInventario);
            this.flpMenuLateral.Controls.Add(this.flpPersonas);
            this.flpMenuLateral.Controls.Add(this.flpAdministracion);
            this.flpMenuLateral.Controls.Add(this.flpReportes);
            this.flpMenuLateral.Controls.Add(this.flpConfiguracion);
            this.flpMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenuLateral.Location = new System.Drawing.Point(0, 60);
            this.flpMenuLateral.Name = "flpMenuLateral";
            this.flpMenuLateral.Size = new System.Drawing.Size(220, 540);
            this.flpMenuLateral.TabIndex = 10;
            // 
            // flpInventario
            // 
            this.flpInventario.BackColor = System.Drawing.Color.Transparent;
            this.flpInventario.Controls.Add(this.btnInventario);
            this.flpInventario.Controls.Add(this.btnProductos);
            this.flpInventario.Controls.Add(this.btnCategorias);
            this.flpInventario.Location = new System.Drawing.Point(3, 109);
            this.flpInventario.Name = "flpInventario";
            this.flpInventario.Size = new System.Drawing.Size(220, 50);
            this.flpInventario.TabIndex = 11;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 50);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(220, 50);
            this.btnProductos.TabIndex = 12;
            this.btnProductos.Text = "          Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(0, 100);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(220, 50);
            this.btnCategorias.TabIndex = 13;
            this.btnCategorias.Text = "          Categorías";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // flpPersonas
            // 
            this.flpPersonas.BackColor = System.Drawing.Color.Transparent;
            this.flpPersonas.Controls.Add(this.btnPersonas);
            this.flpPersonas.Controls.Add(this.btnClientes);
            this.flpPersonas.Controls.Add(this.btnProveedores);
            this.flpPersonas.Location = new System.Drawing.Point(3, 165);
            this.flpPersonas.Name = "flpPersonas";
            this.flpPersonas.Size = new System.Drawing.Size(220, 50);
            this.flpPersonas.TabIndex = 11;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 50);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(220, 50);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "          Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 100);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(220, 50);
            this.btnProveedores.TabIndex = 12;
            this.btnProveedores.Text = "          Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // flpAdministracion
            // 
            this.flpAdministracion.BackColor = System.Drawing.Color.Transparent;
            this.flpAdministracion.Controls.Add(this.btnAdministracion);
            this.flpAdministracion.Controls.Add(this.btnUsuarios);
            this.flpAdministracion.Controls.Add(this.btnRoles);
            this.flpAdministracion.Controls.Add(this.btnParametros);
            this.flpAdministracion.Location = new System.Drawing.Point(3, 221);
            this.flpAdministracion.Name = "flpAdministracion";
            this.flpAdministracion.Size = new System.Drawing.Size(220, 50);
            this.flpAdministracion.TabIndex = 14;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 50);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(220, 50);
            this.btnUsuarios.TabIndex = 18;
            this.btnUsuarios.Text = "          Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.Transparent;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 100);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(220, 50);
            this.btnRoles.TabIndex = 16;
            this.btnRoles.Text = "          Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.BackColor = System.Drawing.Color.Transparent;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametros.ForeColor = System.Drawing.Color.White;
            this.btnParametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametros.Location = new System.Drawing.Point(0, 150);
            this.btnParametros.Margin = new System.Windows.Forms.Padding(0);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnParametros.Size = new System.Drawing.Size(220, 50);
            this.btnParametros.TabIndex = 17;
            this.btnParametros.Text = "          Parametros";
            this.btnParametros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametros.UseVisualStyleBackColor = false;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // flpReportes
            // 
            this.flpReportes.BackColor = System.Drawing.Color.Transparent;
            this.flpReportes.Controls.Add(this.btnReportes);
            this.flpReportes.Controls.Add(this.btnVentasFechas);
            this.flpReportes.Controls.Add(this.btnComprasProveedor);
            this.flpReportes.Controls.Add(this.btnInventarioActual);
            this.flpReportes.Location = new System.Drawing.Point(3, 277);
            this.flpReportes.Name = "flpReportes";
            this.flpReportes.Size = new System.Drawing.Size(220, 50);
            this.flpReportes.TabIndex = 15;
            // 
            // btnVentasFechas
            // 
            this.btnVentasFechas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentasFechas.FlatAppearance.BorderSize = 0;
            this.btnVentasFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasFechas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasFechas.ForeColor = System.Drawing.Color.White;
            this.btnVentasFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasFechas.Location = new System.Drawing.Point(0, 50);
            this.btnVentasFechas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentasFechas.Name = "btnVentasFechas";
            this.btnVentasFechas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVentasFechas.Size = new System.Drawing.Size(220, 50);
            this.btnVentasFechas.TabIndex = 18;
            this.btnVentasFechas.Text = "          Ventas por fechas";
            this.btnVentasFechas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasFechas.UseVisualStyleBackColor = false;
            this.btnVentasFechas.Click += new System.EventHandler(this.btnVentasFechas_Click);
            // 
            // btnComprasProveedor
            // 
            this.btnComprasProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnComprasProveedor.FlatAppearance.BorderSize = 0;
            this.btnComprasProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprasProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprasProveedor.ForeColor = System.Drawing.Color.White;
            this.btnComprasProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasProveedor.Location = new System.Drawing.Point(0, 100);
            this.btnComprasProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprasProveedor.Name = "btnComprasProveedor";
            this.btnComprasProveedor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnComprasProveedor.Size = new System.Drawing.Size(220, 50);
            this.btnComprasProveedor.TabIndex = 17;
            this.btnComprasProveedor.Text = "          Compras realizadas";
            this.btnComprasProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprasProveedor.UseVisualStyleBackColor = false;
            this.btnComprasProveedor.Click += new System.EventHandler(this.btnComprasProveedor_Click);
            // 
            // btnInventarioActual
            // 
            this.btnInventarioActual.BackColor = System.Drawing.Color.Transparent;
            this.btnInventarioActual.FlatAppearance.BorderSize = 0;
            this.btnInventarioActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarioActual.ForeColor = System.Drawing.Color.White;
            this.btnInventarioActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventarioActual.Location = new System.Drawing.Point(0, 150);
            this.btnInventarioActual.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventarioActual.Name = "btnInventarioActual";
            this.btnInventarioActual.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventarioActual.Size = new System.Drawing.Size(220, 50);
            this.btnInventarioActual.TabIndex = 17;
            this.btnInventarioActual.Text = "          Inventario actual";
            this.btnInventarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventarioActual.UseVisualStyleBackColor = false;
            this.btnInventarioActual.Click += new System.EventHandler(this.btnInventarioActual_Click);
            // 
            // flpConfiguracion
            // 
            this.flpConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.flpConfiguracion.Controls.Add(this.btnConfiguracion);
            this.flpConfiguracion.Controls.Add(this.btnPreferenciasSistema);
            this.flpConfiguracion.Controls.Add(this.btnSeguridad);
            this.flpConfiguracion.Location = new System.Drawing.Point(3, 333);
            this.flpConfiguracion.Name = "flpConfiguracion";
            this.flpConfiguracion.Size = new System.Drawing.Size(220, 50);
            this.flpConfiguracion.TabIndex = 16;
            // 
            // btnPreferenciasSistema
            // 
            this.btnPreferenciasSistema.BackColor = System.Drawing.Color.Transparent;
            this.btnPreferenciasSistema.FlatAppearance.BorderSize = 0;
            this.btnPreferenciasSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferenciasSistema.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreferenciasSistema.ForeColor = System.Drawing.Color.White;
            this.btnPreferenciasSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreferenciasSistema.Location = new System.Drawing.Point(0, 50);
            this.btnPreferenciasSistema.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreferenciasSistema.Name = "btnPreferenciasSistema";
            this.btnPreferenciasSistema.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPreferenciasSistema.Size = new System.Drawing.Size(220, 50);
            this.btnPreferenciasSistema.TabIndex = 17;
            this.btnPreferenciasSistema.Text = "          Preferencias";
            this.btnPreferenciasSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreferenciasSistema.UseVisualStyleBackColor = false;
            this.btnPreferenciasSistema.Click += new System.EventHandler(this.btnPreferenciasSistema_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 100);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSeguridad.Size = new System.Drawing.Size(220, 50);
            this.btnSeguridad.TabIndex = 13;
            this.btnSeguridad.Text = "          Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(220, 60);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(780, 540);
            this.pnlFormularios.TabIndex = 11;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::SGC_MINIMARKET.Properties.Resources.iconDashBoard_24px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.BackColor = System.Drawing.Color.Transparent;
            this.btnTransacciones.FlatAppearance.BorderSize = 0;
            this.btnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacciones.ForeColor = System.Drawing.Color.White;
            this.btnTransacciones.Image = global::SGC_MINIMARKET.Properties.Resources.iconTransacciones_24px;
            this.btnTransacciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacciones.Location = new System.Drawing.Point(0, 0);
            this.btnTransacciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTransacciones.Size = new System.Drawing.Size(220, 50);
            this.btnTransacciones.TabIndex = 3;
            this.btnTransacciones.Text = "          Transacciones";
            this.btnTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacciones.UseVisualStyleBackColor = false;
            this.btnTransacciones.Click += new System.EventHandler(this.btnTransacciones_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::SGC_MINIMARKET.Properties.Resources.iconInventario_24px;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 0);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(220, 50);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "          Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonas.FlatAppearance.BorderSize = 0;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.ForeColor = System.Drawing.Color.White;
            this.btnPersonas.Image = global::SGC_MINIMARKET.Properties.Resources.iconPersonas_24px;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(0, 0);
            this.btnPersonas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPersonas.Size = new System.Drawing.Size(220, 50);
            this.btnPersonas.TabIndex = 8;
            this.btnPersonas.Text = "          Personas";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.ForeColor = System.Drawing.Color.White;
            this.btnAdministracion.Image = global::SGC_MINIMARKET.Properties.Resources.iconAdministracion_24px;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 0);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(220, 50);
            this.btnAdministracion.TabIndex = 6;
            this.btnAdministracion.Text = "          Administración";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::SGC_MINIMARKET.Properties.Resources.iconReportes_24px;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 0);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(220, 50);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "          Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = global::SGC_MINIMARKET.Properties.Resources.iconConfiguracion_24px;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 50);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "          Configuracion";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlFormularios);
            this.Controls.Add(this.flpMenuLateral);
            this.Controls.Add(this.pnlCabecera);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracionPC";
            this.Load += new System.EventHandler(this.frmConfiguracionPC_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.flpTransacciones.ResumeLayout(false);
            this.flpMenuLateral.ResumeLayout(false);
            this.flpInventario.ResumeLayout(false);
            this.flpPersonas.ResumeLayout(false);
            this.flpAdministracion.ResumeLayout(false);
            this.flpReportes.ResumeLayout(false);
            this.flpConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgIconos;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Timer tmTransicion;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.FlowLayoutPanel flpTransacciones;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Timer tmMenuLateral;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.FlowLayoutPanel flpMenuLateral;
        private System.Windows.Forms.FlowLayoutPanel flpInventario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.FlowLayoutPanel flpPersonas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.FlowLayoutPanel flpAdministracion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.FlowLayoutPanel flpReportes;
        private System.Windows.Forms.Button btnVentasFechas;
        private System.Windows.Forms.Button btnComprasProveedor;
        private System.Windows.Forms.FlowLayoutPanel flpConfiguracion;
        private System.Windows.Forms.Button btnInventarioActual;
        private System.Windows.Forms.Button btnPreferenciasSistema;
        private System.Windows.Forms.Panel pnlFormularios;
    }
}