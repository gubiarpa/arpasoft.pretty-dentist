namespace arpasoft.pretty_dentist.winclient
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                MessageBox.Show("Se intent� ingresar con Enter desde el user");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                MessageBox.Show("Se intent� ingresar con Enter desde el password");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se intent� ingresar mediante el bot�n");
        }
    }
}