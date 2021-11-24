
namespace Calendario_Pago.Forms
{
    partial class FrmCalendario
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
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblTerminos = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.dtgvMostrarCalendarios = new System.Windows.Forms.DataGridView();
            this.btnAgg = new System.Windows.Forms.Button();
            this.nudMontoDePrestamo = new System.Windows.Forms.NumericUpDown();
            this.nudInteres = new System.Windows.Forms.NumericUpDown();
            this.nudTerminos = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarCalendarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoDePrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMontoPago
            // 
            this.lblMontoPago.AutoSize = true;
            this.lblMontoPago.Location = new System.Drawing.Point(33, 56);
            this.lblMontoPago.Name = "lblMontoPago";
            this.lblMontoPago.Size = new System.Drawing.Size(135, 17);
            this.lblMontoPago.TabIndex = 0;
            this.lblMontoPago.Text = "Monto de Prestamo:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(33, 107);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(77, 17);
            this.lblInteres.TabIndex = 2;
            this.lblInteres.Text = "Interés(%):";
            // 
            // lblTerminos
            // 
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.Location = new System.Drawing.Point(33, 154);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new System.Drawing.Size(112, 17);
            this.lblTerminos.TabIndex = 4;
            this.lblTerminos.Text = "Términos(años):";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(33, 197);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(108, 17);
            this.lblFechaPago.TabIndex = 6;
            this.lblFechaPago.Text = "Fecha de Pago:";
            // 
            // dtpFechaDePago
            // 
            this.dtpFechaDePago.Location = new System.Drawing.Point(198, 197);
            this.dtpFechaDePago.Name = "dtpFechaDePago";
            this.dtpFechaDePago.Size = new System.Drawing.Size(245, 22);
            this.dtpFechaDePago.TabIndex = 7;
            // 
            // dtgvMostrarCalendarios
            // 
            this.dtgvMostrarCalendarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostrarCalendarios.Location = new System.Drawing.Point(1, 278);
            this.dtgvMostrarCalendarios.Name = "dtgvMostrarCalendarios";
            this.dtgvMostrarCalendarios.RowHeadersWidth = 51;
            this.dtgvMostrarCalendarios.RowTemplate.Height = 24;
            this.dtgvMostrarCalendarios.Size = new System.Drawing.Size(1038, 221);
            this.dtgvMostrarCalendarios.TabIndex = 8;
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(482, 51);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(121, 28);
            this.btnAgg.TabIndex = 9;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // nudMontoDePrestamo
            // 
            this.nudMontoDePrestamo.Location = new System.Drawing.Point(198, 51);
            this.nudMontoDePrestamo.Name = "nudMontoDePrestamo";
            this.nudMontoDePrestamo.Size = new System.Drawing.Size(245, 22);
            this.nudMontoDePrestamo.TabIndex = 10;
            // 
            // nudInteres
            // 
            this.nudInteres.Location = new System.Drawing.Point(198, 102);
            this.nudInteres.Name = "nudInteres";
            this.nudInteres.Size = new System.Drawing.Size(245, 22);
            this.nudInteres.TabIndex = 11;
            // 
            // nudTerminos
            // 
            this.nudTerminos.Location = new System.Drawing.Point(198, 152);
            this.nudTerminos.Name = "nudTerminos";
            this.nudTerminos.Size = new System.Drawing.Size(245, 22);
            this.nudTerminos.TabIndex = 12;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(198, 232);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(245, 22);
            this.dtpFechaPago.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha Pago:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(482, 100);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 23);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Pendiente",
            "Pagado"});
            this.cmbSelect.Location = new System.Drawing.Point(482, 145);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(121, 24);
            this.cmbSelect.TabIndex = 16;
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 701);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTerminos);
            this.Controls.Add(this.nudInteres);
            this.Controls.Add(this.nudMontoDePrestamo);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.dtgvMostrarCalendarios);
            this.Controls.Add(this.dtpFechaDePago);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblTerminos);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.lblMontoPago);
            this.Name = "FrmCalendario";
            this.Text = "Calendario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarCalendarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoDePrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoPago;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblTerminos;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaDePago;
        private System.Windows.Forms.DataGridView dtgvMostrarCalendarios;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.NumericUpDown nudMontoDePrestamo;
        private System.Windows.Forms.NumericUpDown nudInteres;
        private System.Windows.Forms.NumericUpDown nudTerminos;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbSelect;
    }
}