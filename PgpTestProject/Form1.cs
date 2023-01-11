using Org.BouncyCastle;


namespace PgpTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            PgpManager.EncryptFile(@"C:\temp\test.xml", @"C:\temp\encrypted.xml", @"C:\temp\PublicKey.asc", true, false);
        }
    }
}