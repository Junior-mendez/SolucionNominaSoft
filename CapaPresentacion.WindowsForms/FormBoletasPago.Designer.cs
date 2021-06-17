namespace CapaPresentacion.WindowsForms
{
    partial class FormBoletasPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridBoletas = new System.Windows.Forms.DataGridView();
            this.dniEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoBasico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBoletas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBoletas
            // 
            this.dataGridBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniEmpleado,
            this.nombre,
            this.totalHora,
            this.valorHora,
            this.sueldoBasico,
            this.totalIngresos,
            this.totalDescuentos,
            this.sueldoNeto});
            this.dataGridBoletas.Location = new System.Drawing.Point(27, 30);
            this.dataGridBoletas.Name = "dataGridBoletas";
            this.dataGridBoletas.Size = new System.Drawing.Size(838, 240);
            this.dataGridBoletas.TabIndex = 0;
            this.dataGridBoletas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dniEmpleado
            // 
            this.dniEmpleado.HeaderText = "Dni Empleado";
            this.dniEmpleado.Name = "dniEmpleado";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // totalHora
            // 
            this.totalHora.HeaderText = "Total Horas";
            this.totalHora.Name = "totalHora";
            this.totalHora.ReadOnly = true;
            // 
            // valorHora
            // 
            this.valorHora.HeaderText = "Valor Hora";
            this.valorHora.Name = "valorHora";
            // 
            // sueldoBasico
            // 
            dataGridViewCellStyle5.Format = "S/ ###,##0.00";
            dataGridViewCellStyle5.NullValue = "0";
            this.sueldoBasico.DefaultCellStyle = dataGridViewCellStyle5;
            this.sueldoBasico.HeaderText = "Sueldo Basico";
            this.sueldoBasico.Name = "sueldoBasico";
            this.sueldoBasico.ReadOnly = true;
            // 
            // totalIngresos
            // 
            dataGridViewCellStyle6.Format = "S/ ###,##0.00";
            dataGridViewCellStyle6.NullValue = "0";
            this.totalIngresos.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalIngresos.HeaderText = "Total Ingresos";
            this.totalIngresos.Name = "totalIngresos";
            this.totalIngresos.ReadOnly = true;
            // 
            // totalDescuentos
            // 
            dataGridViewCellStyle7.Format = "S/ ###,##0.00";
            dataGridViewCellStyle7.NullValue = "0";
            this.totalDescuentos.DefaultCellStyle = dataGridViewCellStyle7;
            this.totalDescuentos.HeaderText = "Total Descuentos";
            this.totalDescuentos.Name = "totalDescuentos";
            this.totalDescuentos.ReadOnly = true;
            // 
            // sueldoNeto
            // 
            dataGridViewCellStyle8.Format = "S/ ###,##0.00";
            dataGridViewCellStyle8.NullValue = "0";
            this.sueldoNeto.DefaultCellStyle = dataGridViewCellStyle8;
            this.sueldoNeto.HeaderText = "Sueldo Neto";
            this.sueldoNeto.Name = "sueldoNeto";
            this.sueldoNeto.ReadOnly = true;
            // 
            // FormBoletasPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.dataGridBoletas);
            this.Name = "FormBoletasPago";
            this.Text = "FormBoletasPago";
            this.Load += new System.EventHandler(this.FormBoletasPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBoletas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBoletas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoBasico;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoNeto;
    }
}