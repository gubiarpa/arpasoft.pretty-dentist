namespace arpasoft.pretty_dentist.winclient.Patient
{
    partial class FrmPatient
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
            this.tabPatient = new System.Windows.Forms.TabControl();
            this.tabPatientList = new System.Windows.Forms.TabPage();
            this.tabPatientDetail = new System.Windows.Forms.TabPage();
            this.tabPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPatient
            // 
            this.tabPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPatient.Controls.Add(this.tabPatientList);
            this.tabPatient.Controls.Add(this.tabPatientDetail);
            this.tabPatient.Location = new System.Drawing.Point(12, 12);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.SelectedIndex = 0;
            this.tabPatient.Size = new System.Drawing.Size(1112, 761);
            this.tabPatient.TabIndex = 0;
            // 
            // tabPatientList
            // 
            this.tabPatientList.Location = new System.Drawing.Point(4, 34);
            this.tabPatientList.Name = "tabPatientList";
            this.tabPatientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientList.Size = new System.Drawing.Size(1104, 723);
            this.tabPatientList.TabIndex = 0;
            this.tabPatientList.Text = "Detalle";
            this.tabPatientList.UseVisualStyleBackColor = true;
            // 
            // tabPatientDetail
            // 
            this.tabPatientDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPatientDetail.Name = "tabPatientDetail";
            this.tabPatientDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientDetail.Size = new System.Drawing.Size(768, 388);
            this.tabPatientDetail.TabIndex = 1;
            this.tabPatientDetail.Text = "Lista";
            this.tabPatientDetail.UseVisualStyleBackColor = true;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 785);
            this.Controls.Add(this.tabPatient);
            this.Name = "FrmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPatient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPatient_FormClosed);
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.tabPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabPatient;
        private TabPage tabPatientList;
        private TabPage tabPatientDetail;
    }
}