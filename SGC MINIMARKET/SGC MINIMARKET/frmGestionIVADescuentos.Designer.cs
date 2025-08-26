namespace SGC_MINIMARKET
{
    partial class frmGestionIVADescuentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDescripcionDeDescuento = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRegistrosActualizarEliminar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarNuevoIVADescuento = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosActualizarEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "IVA 15%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestión de IVA y Descuentos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje";
            // 
            // txtNombreDescripcionDeDescuento
            // 
            this.txtNombreDescripcionDeDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDescripcionDeDescuento.Location = new System.Drawing.Point(183, 156);
            this.txtNombreDescripcionDeDescuento.Name = "txtNombreDescripcionDeDescuento";
            this.txtNombreDescripcionDeDescuento.Size = new System.Drawing.Size(281, 28);
            this.txtNombreDescripcionDeDescuento.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(183, 212);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sección de Datos del IVA / Descuentos";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Descuento"});
            this.comboBox1.Location = new System.Drawing.Point(183, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "IVA";
            // 
            // dgvRegistrosActualizarEliminar
            // 
            this.dgvRegistrosActualizarEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosActualizarEliminar.Location = new System.Drawing.Point(56, 339);
            this.dgvRegistrosActualizarEliminar.Name = "dgvRegistrosActualizarEliminar";
            this.dgvRegistrosActualizarEliminar.RowHeadersWidth = 51;
            this.dgvRegistrosActualizarEliminar.RowTemplate.Height = 24;
            this.dgvRegistrosActualizarEliminar.Size = new System.Drawing.Size(858, 168);
            this.dgvRegistrosActualizarEliminar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tabla de registros para actualizar o eliminar.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRegistrarNuevoIVADescuento
            // 
            this.btnRegistrarNuevoIVADescuento.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrarNuevoIVADescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNuevoIVADescuento.Location = new System.Drawing.Point(56, 529);
            this.btnRegistrarNuevoIVADescuento.Name = "btnRegistrarNuevoIVADescuento";
            this.btnRegistrarNuevoIVADescuento.Size = new System.Drawing.Size(112, 36);
            this.btnRegistrarNuevoIVADescuento.TabIndex = 11;
            this.btnRegistrarNuevoIVADescuento.Text = "Registrar";
            this.btnRegistrarNuevoIVADescuento.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(213, 529);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(389, 529);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 36);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(558, 529);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 36);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Consultar / Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(774, 529);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(140, 36);
            this.btnLimpiarPantalla.TabIndex = 15;
            this.btnLimpiarPantalla.Text = "Limpiar campos";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SGC_MINIMARKET.Properties.Resources._3868335;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(839, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 130);
            this.panel1.TabIndex = 16;
            // 
            // frmGestionIVADescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrarNuevoIVADescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRegistrosActualizarEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtNombreDescripcionDeDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionIVADescuentos";
            this.Text = "frmGestionIVADescuentos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosActualizarEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDescripcionDeDescuento;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRegistrosActualizarEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarNuevoIVADescuento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarPantalla;
        private System.Windows.Forms.Panel panel1;
    }
}