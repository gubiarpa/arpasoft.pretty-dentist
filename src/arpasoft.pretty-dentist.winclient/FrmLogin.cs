using arpasoft.pretty_dentist.abstractions.Domain;

namespace arpasoft.pretty_dentist.winclient
{
    public partial class FrmLogin : Form
    {
        #region Attributtes
        private Credentials? _credentials;

        private FrmMain _frmMain;
        #endregion

        #region Constructor
        public FrmLogin()
        {
            InitializeComponent();
            _frmMain = new FrmMain(this);
        }
        #endregion

        #region Events
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                AuthenticateForm();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                AuthenticateForm();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthenticateForm();
        }
        #endregion

        #region Operations
        private void AuthenticateForm()
        {
            LoadCredentials();

            if (ValidateCredentials())
            {
                _frmMain.Show();
                this.Hide();
            }
        }
        #endregion

        #region FormManagement
        private void LoadCredentials()
        {
            var username = txtUser.Text;
            var password = txtPassword.Text;

            if ((string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)))
                _credentials = null;
            else
                _credentials = new Credentials()
                {
                    Username = username,
                    Password = password
                };
        }
        #endregion

        #region ServicesManagement
        private bool ValidateCredentials()
        {
            return ( // Provitional Hardcode
                (_credentials?.Username == "garredondo") &&
                (_credentials?.Password == "123456")
                );
        }
        #endregion
    }
}