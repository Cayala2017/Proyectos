namespace InterfacesMatasanos
{
    partial class PruebadeReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MedicoENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pacienteENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MedicoENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicoENBindingSource
            // 
            this.MedicoENBindingSource.DataSource = typeof(InterfacesMatasanos.ServiceReference1.MedicoEN);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MedicoENBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.pacienteENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.Location = new System.Drawing.Point(-5, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(735, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // pacienteENBindingSource
            // 
            this.pacienteENBindingSource.DataSource = typeof(InterfacesMatasanos.ServiceReference1.PacienteEN);
            // 
            // PruebadeReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 490);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PruebadeReporte";
            this.Text = "PruebadeReporte";
            this.Load += new System.EventHandler(this.PruebadeReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicoENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MedicoENBindingSource;
        private System.Windows.Forms.BindingSource pacienteENBindingSource;
    }
}