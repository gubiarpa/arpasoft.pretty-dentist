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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.optionSession = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSession_CloseSession = new System.Windows.Forms.ToolStripMenuItem();
            this.optionView = new System.Windows.Forms.ToolStripMenuItem();
            this.optionView_Patients = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSession,
            this.optionView});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // optionSession
            // 
            this.optionSession.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSession_CloseSession});
            this.optionSession.Name = "optionSession";
            this.optionSession.Size = new System.Drawing.Size(53, 20);
            this.optionSession.Text = "&Sesión";
            // 
            // optionSession_CloseSession
            // 
            this.optionSession_CloseSession.Name = "optionSession_CloseSession";
            this.optionSession_CloseSession.Size = new System.Drawing.Size(180, 22);
            this.optionSession_CloseSession.Text = "&Cerrar Sesión";
            this.optionSession_CloseSession.Click += new System.EventHandler(this.optionSession_CloseSession_Click);
            // 
            // optionView
            // 
            this.optionView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionView_Patients});
            this.optionView.Name = "optionView";
            this.optionView.Size = new System.Drawing.Size(35, 20);
            this.optionView.Text = "&Ver";
            // 
            // optionView_Patients
            // 
            this.optionView_Patients.Name = "optionView_Patients";
            this.optionView_Patients.Size = new System.Drawing.Size(124, 22);
            this.optionView_Patients.Text = "&Pacientes";
            this.optionView_Patients.Click += new System.EventHandler(this.optionView_Patients_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem optionSession;
        private ToolStripMenuItem optionView;
        private ToolStripMenuItem optionView_Patients;
        private ToolStripMenuItem optionSession_CloseSession;
    }
}