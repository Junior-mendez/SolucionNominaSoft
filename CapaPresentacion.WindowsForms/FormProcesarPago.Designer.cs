namespace CapaPresentacion.WindowsForms
{
    partial class FormProcesarPago
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
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Controls.Add(this.dateFechaFin);
            this.groupBoxPeriodo.Controls.Add(this.dateFechaInicio);
            this.groupBoxPeriodo.Controls.Add(this.btnProcesar);
            this.groupBoxPeriodo.Controls.Add(this.textCodigo);
            this.groupBoxPeriodo.Controls.Add(this.label3);
            this.groupBoxPeriodo.Controls.Add(this.label2);
            this.groupBoxPeriodo.Controls.Add(this.label1);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(58, 40);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(327, 260);
            this.groupBoxPeriodo.TabIndex = 0;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Fin:";
            // 
            // textCodigo
            // 
            this.textCodigo.Enabled = false;
            this.textCodigo.Location = new System.Drawing.Point(105, 58);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 3;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(130, 172);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.Enabled = false;
            this.dateFechaInicio.Location = new System.Drawing.Point(105, 92);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dateFechaInicio.TabIndex = 7;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.Enabled = false;
            this.dateFechaFin.Location = new System.Drawing.Point(105, 121);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dateFechaFin.TabIndex = 8;
            // 
            // FormProcesarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 340);
            this.Controls.Add(this.groupBoxPeriodo);
            this.Name = "FormProcesarPago";
            this.Text = "FormProcesarPago";
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.DateTimePicker dateFechaInicio;
    }
}