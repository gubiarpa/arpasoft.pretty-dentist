namespace arpasoft.pretty_dentist.winclient.Patient
{
    public partial class FrmPatient : Form
    {
        private readonly Form _parentForm;

        public FrmPatient(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {

        }

        private void FrmPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parentForm.Show();
        }
    }
}
