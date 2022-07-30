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
            this.datDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMaternalSurname = new System.Windows.Forms.TextBox();
            this.lblMaternalSurname = new System.Windows.Forms.Label();
            this.txtPaternalSurname = new System.Windows.Forms.TextBox();
            this.lblPaternalSurname = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tabPatientDetail = new System.Windows.Forms.TabPage();
            this.tabPatient.SuspendLayout();
            this.tabPatientList.SuspendLayout();
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
            this.tabPatientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPatientList.Controls.Add(this.datDateOfBirth);
            this.tabPatientList.Controls.Add(this.txtTelephone);
            this.tabPatientList.Controls.Add(this.txtName);
            this.tabPatientList.Controls.Add(this.lblTelephone);
            this.tabPatientList.Controls.Add(this.lblDateOfBirth);
            this.tabPatientList.Controls.Add(this.lblName);
            this.tabPatientList.Controls.Add(this.txtMaternalSurname);
            this.tabPatientList.Controls.Add(this.lblMaternalSurname);
            this.tabPatientList.Controls.Add(this.txtPaternalSurname);
            this.tabPatientList.Controls.Add(this.lblPaternalSurname);
            this.tabPatientList.Controls.Add(this.txtDNI);
            this.tabPatientList.Controls.Add(this.lblDNI);
            this.tabPatientList.Location = new System.Drawing.Point(4, 34);
            this.tabPatientList.Name = "tabPatientList";
            this.tabPatientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientList.Size = new System.Drawing.Size(1104, 723);
            this.tabPatientList.TabIndex = 0;
            this.tabPatientList.Text = "Detalle";
            this.tabPatientList.UseVisualStyleBackColor = true;
            // 
            // datDateOfBirth
            // 
            this.datDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.datDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDateOfBirth.Location = new System.Drawing.Point(250, 233);
            this.datDateOfBirth.Name = "datDateOfBirth";
            this.datDateOfBirth.Size = new System.Drawing.Size(163, 31);
            this.datDateOfBirth.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(250, 283);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(163, 31);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(250, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 31);
            this.txtName.TabIndex = 3;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(25, 283);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(219, 31);
            this.lblTelephone.TabIndex = 0;
            this.lblTelephone.Text = "Teléfono";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(25, 233);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(219, 31);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Fecha Nacimiento";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(25, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(219, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombres";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaternalSurname
            // 
            this.txtMaternalSurname.Location = new System.Drawing.Point(250, 133);
            this.txtMaternalSurname.Name = "txtMaternalSurname";
            this.txtMaternalSurname.Size = new System.Drawing.Size(402, 31);
            this.txtMaternalSurname.TabIndex = 2;
            // 
            // lblMaternalSurname
            // 
            this.lblMaternalSurname.Location = new System.Drawing.Point(25, 133);
            this.lblMaternalSurname.Name = "lblMaternalSurname";
            this.lblMaternalSurname.Size = new System.Drawing.Size(219, 31);
            this.lblMaternalSurname.TabIndex = 0;
            this.lblMaternalSurname.Text = "Apellido Materno";
            this.lblMaternalSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaternalSurname
            // 
            this.txtPaternalSurname.Location = new System.Drawing.Point(250, 83);
            this.txtPaternalSurname.Name = "txtPaternalSurname";
            this.txtPaternalSurname.Size = new System.Drawing.Size(402, 31);
            this.txtPaternalSurname.TabIndex = 1;
            // 
            // lblPaternalSurname
            // 
            this.lblPaternalSurname.Location = new System.Drawing.Point(25, 83);
            this.lblPaternalSurname.Name = "lblPaternalSurname";
            this.lblPaternalSurname.Size = new System.Drawing.Size(219, 31);
            this.lblPaternalSurname.TabIndex = 0;
            this.lblPaternalSurname.Text = "Apellido Paterno";
            this.lblPaternalSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(250, 33);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(402, 31);
            this.txtDNI.TabIndex = 0;
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(25, 33);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(219, 31);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPatientDetail
            // 
            this.tabPatientDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPatientDetail.Name = "tabPatientDetail";
            this.tabPatientDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientDetail.Size = new System.Drawing.Size(1104, 723);
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
            this.Text = "Pacientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPatient_FormClosed);
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.tabPatient.ResumeLayout(false);
            this.tabPatientList.ResumeLayout(false);
            this.tabPatientList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabPatient;
        private TabPage tabPatientList;
        private TabPage tabPatientDetail;
        private TextBox txtMaternalSurname;
        private Label lblMaternalSurname;
        private TextBox txtPaternalSurname;
        private Label lblPaternalSurname;
        private TextBox txtDNI;
        private Label lblDNI;
        private DateTimePicker datDateOfBirth;
        private TextBox txtName;
        private Label lblDateOfBirth;
        private Label lblName;
        private TextBox txtTelephone;
        private Label lblTelephone;
    }
}