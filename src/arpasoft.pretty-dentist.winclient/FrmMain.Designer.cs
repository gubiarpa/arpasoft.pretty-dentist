namespace arpasoft.pretty_dentist.winclient
{
    partial class FrmMain
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
            this.btnOptionPatients = new System.Windows.Forms.Button();
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.grpMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptionPatients
            // 
            this.btnOptionPatients.Location = new System.Drawing.Point(34, 54);
            this.btnOptionPatients.Name = "btnOptionPatients";
            this.btnOptionPatients.Size = new System.Drawing.Size(266, 34);
            this.btnOptionPatients.TabIndex = 0;
            this.btnOptionPatients.Text = "Pacientes";
            this.btnOptionPatients.UseVisualStyleBackColor = true;
            this.btnOptionPatients.Click += new System.EventHandler(this.btnOptionPatients_Click);
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnOptionPatients);
            this.grpMaintenance.Location = new System.Drawing.Point(12, 12);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(831, 178);
            this.grpMaintenance.TabIndex = 1;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Mantenimiento";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 213);
            this.Controls.Add(this.grpMaintenance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOptionPatients;
        private GroupBox grpMaintenance;
    }
}