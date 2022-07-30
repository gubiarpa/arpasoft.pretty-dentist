using arpasoft.pretty_dentist.winclient.Patient;

namespace arpasoft.pretty_dentist.winclient
{
    public partial class FrmMain : Form
    {
        #region Attributtes
        private Form _loginForm;
        private Form _patientForm;
        #endregion

        public FrmMain(Form parentForm)
        {
            InitializeComponent();
            _loginForm = parentForm;
            _patientForm = new FrmPatient(this);
        }

        #region Events
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _loginForm.Hide();
        }

        private void btnOptionPatients_Click(object sender, EventArgs e)
        {
            _patientForm?.Show();
            this.Hide();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm?.Close();
            _loginForm?.Dispose();
        }
        #endregion
    }
}
