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
            this.chkIsVerified = new System.Windows.Forms.CheckBox();
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
            this.grpManagement = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.tabPatient.SuspendLayout();
            this.tabPatientList.SuspendLayout();
            this.tabPatientDetail.SuspendLayout();
            this.grpManagement.SuspendLayout();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
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
            this.tabPatient.Size = new System.Drawing.Size(1293, 696);
            this.tabPatient.TabIndex = 0;
            // 
            // tabPatientList
            // 
            this.tabPatientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPatientList.Controls.Add(this.chkIsVerified);
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
            this.tabPatientList.Size = new System.Drawing.Size(1285, 658);
            this.tabPatientList.TabIndex = 0;
            this.tabPatientList.Text = "Detalle";
            this.tabPatientList.UseVisualStyleBackColor = true;
            // 
            // chkIsVerified
            // 
            this.chkIsVerified.AutoSize = true;
            this.chkIsVerified.Location = new System.Drawing.Point(432, 285);
            this.chkIsVerified.Name = "chkIsVerified";
            this.chkIsVerified.Size = new System.Drawing.Size(116, 29);
            this.chkIsVerified.TabIndex = 6;
            this.chkIsVerified.Text = "Verificado";
            this.chkIsVerified.UseVisualStyleBackColor = true;
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
            this.txtTelephone.MaxLength = 9;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(163, 31);
            this.txtTelephone.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(250, 183);
            this.txtName.MaxLength = 200;
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
            this.txtMaternalSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaternalSurname.Location = new System.Drawing.Point(250, 133);
            this.txtMaternalSurname.MaxLength = 200;
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
            this.txtPaternalSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaternalSurname.Location = new System.Drawing.Point(250, 83);
            this.txtPaternalSurname.MaxLength = 200;
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
            this.txtDNI.MaxLength = 8;
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
            this.tabPatientDetail.Controls.Add(this.grpManagement);
            this.tabPatientDetail.Controls.Add(this.grpGrid);
            this.tabPatientDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPatientDetail.Name = "tabPatientDetail";
            this.tabPatientDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientDetail.Size = new System.Drawing.Size(1285, 658);
            this.tabPatientDetail.TabIndex = 1;
            this.tabPatientDetail.Text = "Lista";
            this.tabPatientDetail.UseVisualStyleBackColor = true;
            // 
            // grpManagement
            // 
            this.grpManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpManagement.Controls.Add(this.btnRemove);
            this.grpManagement.Controls.Add(this.btnEdit);
            this.grpManagement.Controls.Add(this.btnNew);
            this.grpManagement.Location = new System.Drawing.Point(6, 6);
            this.grpManagement.Name = "grpManagement";
            this.grpManagement.Size = new System.Drawing.Size(1273, 99);
            this.grpManagement.TabIndex = 3;
            this.grpManagement.TabStop = false;
            this.grpManagement.Text = "Acciones";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(280, 42);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "&Eliminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(150, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(20, 42);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 34);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // grpGrid
            // 
            this.grpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrid.Controls.Add(this.dgvPatient);
            this.grpGrid.Location = new System.Drawing.Point(6, 111);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(1273, 541);
            this.grpGrid.TabIndex = 1;
            this.grpGrid.TabStop = false;
            this.grpGrid.Text = "Data";
            // 
            // dgvPatient
            // 
            this.dgvPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(19, 44);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.RowHeadersWidth = 62;
            this.dgvPatient.RowTemplate.Height = 33;
            this.dgvPatient.Size = new System.Drawing.Size(1248, 491);
            this.dgvPatient.TabIndex = 0;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 720);
            this.Controls.Add(this.tabPatient);
            this.Name = "FrmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPatient_FormClosed);
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.tabPatient.ResumeLayout(false);
            this.tabPatientList.ResumeLayout(false);
            this.tabPatientList.PerformLayout();
            this.tabPatientDetail.ResumeLayout(false);
            this.grpManagement.ResumeLayout(false);
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
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
        private GroupBox grpManagement;
        private Button btnNew;
        private GroupBox grpGrid;
        private DataGridView dgvPatient;
        private CheckBox chkIsVerified;
        private Button btnEdit;
        private Button btnRemove;
    }
}