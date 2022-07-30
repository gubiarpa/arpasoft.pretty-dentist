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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPatientDetail = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.tabPatientList.Controls.Add(this.dateTimePicker1);
            this.tabPatientList.Controls.Add(this.textBox5);
            this.tabPatientList.Controls.Add(this.textBox4);
            this.tabPatientList.Controls.Add(this.label6);
            this.tabPatientList.Controls.Add(this.label5);
            this.tabPatientList.Controls.Add(this.label4);
            this.tabPatientList.Controls.Add(this.textBox3);
            this.tabPatientList.Controls.Add(this.label3);
            this.tabPatientList.Controls.Add(this.textBox2);
            this.tabPatientList.Controls.Add(this.label2);
            this.tabPatientList.Controls.Add(this.textBox1);
            this.tabPatientList.Controls.Add(this.label1);
            this.tabPatientList.Location = new System.Drawing.Point(4, 34);
            this.tabPatientList.Name = "tabPatientList";
            this.tabPatientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientList.Size = new System.Drawing.Size(1104, 723);
            this.tabPatientList.TabIndex = 0;
            this.tabPatientList.Text = "Detalle";
            this.tabPatientList.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(250, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(402, 31);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha Nacimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(402, 31);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Materno";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 31);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Paterno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(250, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 31);
            this.textBox5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teléfono";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tabPatientList.ResumeLayout(false);
            this.tabPatientList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabPatient;
        private TabPage tabPatientList;
        private TabPage tabPatientDetail;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
    }
}