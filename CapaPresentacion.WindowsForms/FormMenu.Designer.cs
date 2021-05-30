namespace CapaPresentacion.WindowsForms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarContratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarContratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPeriodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratosToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarContratoToolStripMenuItem,
            this.listarContratoToolStripMenuItem});
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // registrarContratoToolStripMenuItem
            // 
            this.registrarContratoToolStripMenuItem.Name = "registrarContratoToolStripMenuItem";
            this.registrarContratoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarContratoToolStripMenuItem.Text = "Registrar Contrato";
            this.registrarContratoToolStripMenuItem.Click += new System.EventHandler(this.registrarContratoToolStripMenuItem_Click);
            // 
            // listarContratoToolStripMenuItem
            // 
            this.listarContratoToolStripMenuItem.Name = "listarContratoToolStripMenuItem";
            this.listarContratoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listarContratoToolStripMenuItem.Text = "Listar Contratos";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesarPagosToolStripMenuItem,
            this.listarPeriodosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // procesarPagosToolStripMenuItem
            // 
            this.procesarPagosToolStripMenuItem.Name = "procesarPagosToolStripMenuItem";
            this.procesarPagosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.procesarPagosToolStripMenuItem.Text = "Procesar Pagos";
            // 
            // listarPeriodosToolStripMenuItem
            // 
            this.listarPeriodosToolStripMenuItem.Name = "listarPeriodosToolStripMenuItem";
            this.listarPeriodosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listarPeriodosToolStripMenuItem.Text = "Listar Periodos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 386);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarContratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarContratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPeriodosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}