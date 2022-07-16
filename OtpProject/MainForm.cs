using OtpProject.Shared;

namespace OtpProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Guid key;
        private void button1_Click(object sender, EventArgs e)
        {
            key = Guid.NewGuid();
            txtSecrectKey.Text = OtpUtility.GenerateKey(key);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecrectKey.Text))
            {
                MessageBox.Show("Create SecretKey first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            imgPreview.Image = OtpUtility.GenerateOtpQrcode(new OtpParamater()
            {
                Account = txtAccountName.Text,
                Issuer = txtIssuer.Text,
                Secret = txtSecrectKey.Text,
                Digit = (OtpParamDigit)Convert.ToInt64(cmbTime.Text),
                Hash = Enum.Parse<OtpParamHash>(cmbHash.Text),
                Time = (OtpParamTime)Convert.ToInt64(cmbTime.Text)
            });
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (OtpUtility.VerifyOtp(key, txtVerify.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}