namespace OtpProject
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSecrectKey = new System.Windows.Forms.TextBox();
            this.txtIssuer = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.cmbHash = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbDigit = new System.Windows.Forms.ComboBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Secrect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSecrectKey
            // 
            this.txtSecrectKey.Location = new System.Drawing.Point(12, 12);
            this.txtSecrectKey.Name = "txtSecrectKey";
            this.txtSecrectKey.ReadOnly = true;
            this.txtSecrectKey.Size = new System.Drawing.Size(227, 23);
            this.txtSecrectKey.TabIndex = 1;
            // 
            // txtIssuer
            // 
            this.txtIssuer.Location = new System.Drawing.Point(12, 41);
            this.txtIssuer.Name = "txtIssuer";
            this.txtIssuer.Size = new System.Drawing.Size(227, 23);
            this.txtIssuer.TabIndex = 2;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(12, 70);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(227, 23);
            this.txtAccountName.TabIndex = 3;
            // 
            // cmbHash
            // 
            this.cmbHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHash.FormattingEnabled = true;
            this.cmbHash.Items.AddRange(new object[] {
            "SHA1",
            "SHA256",
            "SHA512"});
            this.cmbHash.Location = new System.Drawing.Point(12, 99);
            this.cmbHash.Name = "cmbHash";
            this.cmbHash.Size = new System.Drawing.Size(227, 23);
            this.cmbHash.TabIndex = 4;
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.cmbTime.Location = new System.Drawing.Point(12, 128);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(227, 23);
            this.cmbTime.TabIndex = 5;
            // 
            // cmbDigit
            // 
            this.cmbDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDigit.FormattingEnabled = true;
            this.cmbDigit.Items.AddRange(new object[] {
            "6",
            "8",
            "9",
            "10"});
            this.cmbDigit.Location = new System.Drawing.Point(12, 157);
            this.cmbDigit.Name = "cmbDigit";
            this.cmbDigit.Size = new System.Drawing.Size(227, 23);
            this.cmbDigit.TabIndex = 6;
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(326, 12);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(168, 168);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreview.TabIndex = 3;
            this.imgPreview.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 213);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtVerify
            // 
            this.txtVerify.Location = new System.Drawing.Point(93, 214);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(146, 23);
            this.txtVerify.TabIndex = 5;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(245, 214);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Issuer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Digit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.cmbDigit);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.cmbHash);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtIssuer);
            this.Controls.Add(this.txtSecrectKey);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Otp Usage";
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox txtSecrectKey;
        private TextBox txtIssuer;
        private TextBox txtAccountName;
        private ComboBox cmbHash;
        private ComboBox cmbTime;
        private ComboBox cmbDigit;
        private PictureBox imgPreview;
        private Button btnGenerate;
        private TextBox txtVerify;
        private Button btnVerify;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}