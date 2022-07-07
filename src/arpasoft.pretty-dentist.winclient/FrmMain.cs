using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arpasoft.pretty_dentist.winclient
{
    public partial class FrmMain : Form
    {
        private Form _parentForm;

        public FrmMain(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void optionSession_CloseSession_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Close();
        }

        private void optionView_Patients_Click(object sender, EventArgs e)
        {

        }
    }
}
