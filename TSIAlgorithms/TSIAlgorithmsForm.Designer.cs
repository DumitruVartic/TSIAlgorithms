namespace TSIAlghorithms
{
    partial class TSIAlgorithmsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AlgDescription = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.responseLabel = new System.Windows.Forms.Label();
            this.rsaDescriptioknLabel = new System.Windows.Forms.Label();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RSAModeComboBox = new System.Windows.Forms.ComboBox();
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.RSASubmitButton = new System.Windows.Forms.Button();
            this.signatureLabel = new System.Windows.Forms.Label();
            this.originalDataLabel = new System.Windows.Forms.Label();
            this.signatureTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(47, 189);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(160, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(8, 116);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(239, 23);
            this.inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(8, 233);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(239, 23);
            this.outputTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(271, 319);
            this.tabControl.TabIndex = 6;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AlgDescription);
            this.tabPage1.Controls.Add(this.keyTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.modeComboBox);
            this.tabPage1.Controls.Add(this.algorithmComboBox);
            this.tabPage1.Controls.Add(this.inputTextBox);
            this.tabPage1.Controls.Add(this.submitButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.outputTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(263, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algorithm DES/AES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AlgDescription
            // 
            this.AlgDescription.AutoSize = true;
            this.AlgDescription.Location = new System.Drawing.Point(8, 3);
            this.AlgDescription.Name = "AlgDescription";
            this.AlgDescription.Size = new System.Drawing.Size(201, 15);
            this.AlgDescription.TabIndex = 12;
            this.AlgDescription.Text = "AES - Advanced Encryption Standard";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(9, 160);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(239, 23);
            this.keyTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alghorithm";
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.modeComboBox.Location = new System.Drawing.Point(110, 64);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(121, 23);
            this.modeComboBox.TabIndex = 6;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeComboBox_SelectedIndexChanged);
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Items.AddRange(new object[] {
            "DES",
            "AES"});
            this.algorithmComboBox.Location = new System.Drawing.Point(110, 35);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(120, 23);
            this.algorithmComboBox.TabIndex = 5;
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.responseLabel);
            this.tabPage2.Controls.Add(this.rsaDescriptioknLabel);
            this.tabPage2.Controls.Add(this.publicKeyTextBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.RSAModeComboBox);
            this.tabPage2.Controls.Add(this.originalTextBox);
            this.tabPage2.Controls.Add(this.RSASubmitButton);
            this.tabPage2.Controls.Add(this.signatureLabel);
            this.tabPage2.Controls.Add(this.originalDataLabel);
            this.tabPage2.Controls.Add(this.signatureTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(263, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital Signature";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(75, 146);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(108, 15);
            this.responseLabel.TabIndex = 25;
            this.responseLabel.Text = "Response on check";
            this.responseLabel.Visible = false;
            // 
            // rsaDescriptioknLabel
            // 
            this.rsaDescriptioknLabel.AutoSize = true;
            this.rsaDescriptioknLabel.Location = new System.Drawing.Point(8, 3);
            this.rsaDescriptioknLabel.Name = "rsaDescriptioknLabel";
            this.rsaDescriptioknLabel.Size = new System.Drawing.Size(126, 15);
            this.rsaDescriptioknLabel.TabIndex = 24;
            this.rsaDescriptioknLabel.Text = "RSA - Digital Signature";
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(6, 180);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(239, 23);
            this.publicKeyTextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Public Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mode";
            // 
            // RSAModeComboBox
            // 
            this.RSAModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RSAModeComboBox.FormattingEnabled = true;
            this.RSAModeComboBox.Items.AddRange(new object[] {
            "Sign",
            "Verify"});
            this.RSAModeComboBox.Location = new System.Drawing.Point(105, 49);
            this.RSAModeComboBox.Name = "RSAModeComboBox";
            this.RSAModeComboBox.Size = new System.Drawing.Size(121, 23);
            this.RSAModeComboBox.TabIndex = 19;
            this.RSAModeComboBox.SelectedIndexChanged += new System.EventHandler(this.RSAModeComboBox_SelectedIndexChanged);
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(6, 91);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(239, 23);
            this.originalTextBox.TabIndex = 15;
            // 
            // RSASubmitButton
            // 
            this.RSASubmitButton.Location = new System.Drawing.Point(47, 120);
            this.RSASubmitButton.Name = "RSASubmitButton";
            this.RSASubmitButton.Size = new System.Drawing.Size(160, 23);
            this.RSASubmitButton.TabIndex = 13;
            this.RSASubmitButton.Text = "Submit";
            this.RSASubmitButton.UseVisualStyleBackColor = true;
            this.RSASubmitButton.Click += new System.EventHandler(this.RsaSubmitButton_Click);
            // 
            // signatureLabel
            // 
            this.signatureLabel.AutoSize = true;
            this.signatureLabel.Location = new System.Drawing.Point(9, 215);
            this.signatureLabel.Name = "signatureLabel";
            this.signatureLabel.Size = new System.Drawing.Size(57, 15);
            this.signatureLabel.TabIndex = 17;
            this.signatureLabel.Text = "Signature";
            // 
            // originalDataLabel
            // 
            this.originalDataLabel.AutoSize = true;
            this.originalDataLabel.Location = new System.Drawing.Point(8, 73);
            this.originalDataLabel.Name = "originalDataLabel";
            this.originalDataLabel.Size = new System.Drawing.Size(72, 15);
            this.originalDataLabel.TabIndex = 14;
            this.originalDataLabel.Text = "Data To Sing";
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Location = new System.Drawing.Point(6, 233);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(239, 23);
            this.signatureTextBox.TabIndex = 16;
            // 
            // TSIAlgorithmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 319);
            this.Controls.Add(this.tabControl);
            this.Name = "TSIAlgorithmsForm";
            this.Text = "TSI";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button submitButton;
        private Label label1;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Label label2;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox algorithmComboBox;
        private Label label5;
        private Label label4;
        private ComboBox modeComboBox;
        private TextBox keyTextBox;
        private Label label3;
        private Label AlgDescription;
        private Label rsaDescriptioknLabel;
        private TextBox publicKeyTextBox;
        private Label label7;
        private Label label8;
        private ComboBox RSAModeComboBox;
        private TextBox originalTextBox;
        private Button RSASubmitButton;
        private Label signatureLabel;
        private Label originalDataLabel;
        private TextBox signatureTextBox;
        private Label responseLabel;
    }
}