namespace SGC_MINIMARKET
{
    partial class frmHistorialVentas
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
            this.txtBusquedaHistorial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarHistorialVentas = new System.Windows.Forms.Button();
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Ventas";
            // 
            // txtBusquedaHistorial
            // 
            this.txtBusquedaHistorial.Location = new System.Drawing.Point(116, 125);
            this.txtBusquedaHistorial.Name = "txtBusquedaHistorial";
            this.txtBusquedaHistorial.Size = new System.Drawing.Size(274, 22);
            this.txtBusquedaHistorial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(458, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rango";
            // 
            // btnBuscarHistorialVentas
            // 
            this.btnBuscarHistorialVentas.BackColor = System.Drawing.Color.Lime;
            this.btnBuscarHistorialVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistorialVentas.Location = new System.Drawing.Point(757, 120);
            this.btnBuscarHistorialVentas.Name = "btnBuscarHistorialVentas";
            this.btnBuscarHistorialVentas.Size = new System.Drawing.Size(107, 30);
            this.btnBuscarHistorialVentas.TabIndex = 5;
            this.btnBuscarHistorialVentas.Text = "Consultar";
            this.btnBuscarHistorialVentas.UseVisualStyleBackColor = false;
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(62, 163);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.RowHeadersWidth = 51;
            this.dgvHistorialVentas.RowTemplate.Height = 24;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(802, 233);
            this.dgvHistorialVentas.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(757, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.Yellow;
            this.btnVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.Location = new System.Drawing.Point(62, 415);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(124, 35);
            this.btnVerDetalles.TabIndex = 8;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            // 
            // frmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 597);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvHistorialVentas);
            this.Controls.Add(this.btnBuscarHistorialVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusquedaHistorial);
            this.Controls.Add(this.label1);
            this.Name = "frmHistorialVentas";
            this.Text = "frmHistorialVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaHistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarHistorialVentas;
        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDetalles;
    }
}