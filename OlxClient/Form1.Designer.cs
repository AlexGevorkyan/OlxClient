namespace OlxClient
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btConnect = new Button();
            label4 = new Label();
            tbPort = new TextBox();
            label3 = new Label();
            tbAddress = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            tabPage2 = new TabPage();
            btPSend = new Button();
            rtbPDescription = new RichTextBox();
            tbPStatus = new TextBox();
            tbPUnit = new TextBox();
            tbPPrice = new TextBox();
            lblPStatus = new Label();
            lblPUnit = new Label();
            lblPPrice = new Label();
            lblPDescription = new Label();
            tbPName = new TextBox();
            lblPName = new Label();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(694, 400);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnRegister);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(txtUsername);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(686, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Auth";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(343, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 27);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 179);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(343, 149);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(209, 27);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 126);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btConnect);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbPort);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Location = new Point(9, 5);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 176);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection";
            // 
            // btConnect
            // 
            btConnect.Location = new Point(7, 112);
            btConnect.Margin = new Padding(3, 4, 3, 4);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(215, 45);
            btConnect.TabIndex = 7;
            btConnect.Text = "Connect";
            btConnect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 77);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Port:";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(65, 73);
            tbPort.Margin = new Padding(3, 4, 3, 4);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(156, 27);
            tbPort.TabIndex = 9;
            tbPort.Text = "12000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 37);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "Adress:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(65, 33);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(156, 27);
            tbAddress.TabIndex = 7;
            tbAddress.Text = "127.0.0.1";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(343, 249);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(73, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(475, 249);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(77, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 16);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(343, 95);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(209, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(343, 40);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(209, 27);
            txtUsername.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btPSend);
            tabPage2.Controls.Add(rtbPDescription);
            tabPage2.Controls.Add(tbPStatus);
            tabPage2.Controls.Add(tbPUnit);
            tabPage2.Controls.Add(tbPPrice);
            tabPage2.Controls.Add(lblPStatus);
            tabPage2.Controls.Add(lblPUnit);
            tabPage2.Controls.Add(lblPPrice);
            tabPage2.Controls.Add(lblPDescription);
            tabPage2.Controls.Add(tbPName);
            tabPage2.Controls.Add(lblPName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(686, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sell";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btPSend
            // 
            btPSend.Font = new Font("Segoe UI", 12F);
            btPSend.Location = new Point(538, 13);
            btPSend.Margin = new Padding(3, 4, 3, 4);
            btPSend.Name = "btPSend";
            btPSend.Size = new Size(122, 92);
            btPSend.TabIndex = 21;
            btPSend.Text = "Send to marketplace";
            btPSend.UseVisualStyleBackColor = true;
            // 
            // rtbPDescription
            // 
            rtbPDescription.Font = new Font("Segoe UI", 20F);
            rtbPDescription.Location = new Point(121, 113);
            rtbPDescription.Margin = new Padding(3, 4, 3, 4);
            rtbPDescription.Name = "rtbPDescription";
            rtbPDescription.Size = new Size(539, 224);
            rtbPDescription.TabIndex = 20;
            rtbPDescription.Text = "";
            // 
            // tbPStatus
            // 
            tbPStatus.Font = new Font("Segoe UI", 12F);
            tbPStatus.Location = new Point(358, 63);
            tbPStatus.Margin = new Padding(3, 4, 3, 4);
            tbPStatus.Name = "tbPStatus";
            tbPStatus.Size = new Size(173, 34);
            tbPStatus.TabIndex = 19;
            // 
            // tbPUnit
            // 
            tbPUnit.Font = new Font("Segoe UI", 12F);
            tbPUnit.Location = new Point(358, 13);
            tbPUnit.Margin = new Padding(3, 4, 3, 4);
            tbPUnit.Name = "tbPUnit";
            tbPUnit.Size = new Size(173, 34);
            tbPUnit.TabIndex = 18;
            // 
            // tbPPrice
            // 
            tbPPrice.Font = new Font("Segoe UI", 12F);
            tbPPrice.Location = new Point(79, 63);
            tbPPrice.Margin = new Padding(3, 4, 3, 4);
            tbPPrice.Name = "tbPPrice";
            tbPPrice.Size = new Size(202, 34);
            tbPPrice.TabIndex = 17;
            // 
            // lblPStatus
            // 
            lblPStatus.AutoSize = true;
            lblPStatus.Font = new Font("Segoe UI", 12F);
            lblPStatus.Location = new Point(288, 67);
            lblPStatus.Name = "lblPStatus";
            lblPStatus.Size = new Size(69, 28);
            lblPStatus.TabIndex = 16;
            lblPStatus.Text = "Status:";
            // 
            // lblPUnit
            // 
            lblPUnit.AutoSize = true;
            lblPUnit.Font = new Font("Segoe UI", 12F);
            lblPUnit.Location = new Point(288, 17);
            lblPUnit.Name = "lblPUnit";
            lblPUnit.Size = new Size(53, 28);
            lblPUnit.TabIndex = 15;
            lblPUnit.Text = "Unit:";
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 12F);
            lblPPrice.Location = new Point(9, 67);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(58, 28);
            lblPPrice.TabIndex = 14;
            lblPPrice.Text = "Price:";
            // 
            // lblPDescription
            // 
            lblPDescription.AutoSize = true;
            lblPDescription.Font = new Font("Segoe UI", 12F);
            lblPDescription.Location = new Point(9, 111);
            lblPDescription.Name = "lblPDescription";
            lblPDescription.Size = new Size(116, 28);
            lblPDescription.TabIndex = 13;
            lblPDescription.Text = "Description:";
            // 
            // tbPName
            // 
            tbPName.Font = new Font("Segoe UI", 12F);
            tbPName.Location = new Point(79, 13);
            tbPName.Margin = new Padding(3, 4, 3, 4);
            tbPName.Name = "tbPName";
            tbPName.Size = new Size(202, 34);
            tbPName.TabIndex = 12;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Font = new Font("Segoe UI", 12F);
            lblPName.Location = new Point(9, 13);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(68, 28);
            lblPName.TabIndex = 11;
            lblPName.Text = "Name:";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(686, 367);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Buy";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 400);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btnLogin;
        private Button btPSend;
        private RichTextBox rtbPDescription;
        private TextBox tbPStatus;
        private TextBox tbPUnit;
        private TextBox tbPPrice;
        private Label lblPStatus;
        private Label lblPUnit;
        private Label lblPPrice;
        private Label lblPDescription;
        private TextBox tbPName;
        private Label lblPName;
        private GroupBox groupBox1;
        private Button btConnect;
        private Label label4;
        private TextBox tbPort;
        private Label label3;
        private TextBox tbAddress;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
    }
}
