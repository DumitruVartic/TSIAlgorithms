using TSIAlghorithms.Alghorithms;

namespace TSIAlghorithms
{
    public partial class TSIAlgorithmsForm : Form
    {
        public TSIAlgorithmsForm()
        {
            InitializeComponent();
            /*sthis.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;*/

            algorithmComboBox.SelectedIndex = 1;
            modeComboBox.SelectedIndex = 0;
            RSAModeComboBox.SelectedIndex = 0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string response = AlgorithmsAPI.DesAesHandler(keyTextBox.Text, inputTextBox.Text, algorithmComboBox.Text, modeComboBox.Text);
            outputTextBox.Text = response;
        }

        private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedMode = modeComboBox.SelectedItem.ToString();
            this.submitButton.Text = selectedMode;
        }

        private void AlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedAlgorithm = algorithmComboBox.SelectedItem.ToString();
            if (selectedAlgorithm == "AES")
                this.AlgDescription.Text = "AES - Advanced Encryption Standard\nAll data is displayed as Base64String";
            else
                this.AlgDescription.Text = "DES - Data Encryption Standard\nInsecure for modern apps";
        }

        private void RsaSubmitButton_Click(object sender, EventArgs e)
        {
            string? selectedMode = RSAModeComboBox.SelectedItem.ToString();
            string dataToSign = originalTextBox.Text;
            string initialPublicKey = publicKeyTextBox.Text;
            string signature = signatureTextBox.Text;

            (string signedData, string publicKey) = AlgorithmsAPI.RsaHandler(dataToSign, initialPublicKey, signature, selectedMode);
            if (selectedMode == "Sign")
            {
                publicKeyTextBox.Text = publicKey;
                signatureTextBox.Text = signedData;
            }
            else
            {
                responseLabel.Text = "Result -> " + publicKey; // publicKey on option 'Verify' contain the response of the check 
            }
        }

        private void RSAModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedMode = RSAModeComboBox.SelectedItem.ToString();
            RSASubmitButton.Text = selectedMode;
            if (selectedMode == "Verify")
            {
                originalDataLabel.Text = "Data To Verify";
                responseLabel.Visible = true;
                responseLabel.Text = "Result will be here";
                rsaDescriptioknLabel.Text = "To verify a signed data.\nYou can use the public key to verify\nthe signature against the original data.";
            }
            else
            {
                originalDataLabel.Text = "Data To Sign";
                responseLabel.Visible = false;
                rsaDescriptioknLabel.Text = "RSA - Digital Signature";
            }
        }
    }
}