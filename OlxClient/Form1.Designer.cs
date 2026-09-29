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
            tabControl1.Size = new Size(930, 599);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(922, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Auth";
            tabPage1.UseVisualStyleBackColor = true;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(922, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sell";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btPSend
            // 
            btPSend.Font = new Font("Segoe UI", 20F);
            btPSend.Location = new Point(706, 17);
            btPSend.Name = "btPSend";
            btPSend.Size = new Size(211, 169);
            btPSend.TabIndex = 10;
            btPSend.Text = "Send to marketplace";
            btPSend.UseVisualStyleBackColor = true;
            btPSend.Click += btPSend_Click;
            // 
            // rtbPDescription
            // 
            rtbPDescription.Font = new Font("Segoe UI", 20F);
            rtbPDescription.Location = new Point(190, 284);
            rtbPDescription.Name = "rtbPDescription";
            rtbPDescription.Size = new Size(727, 279);
            rtbPDescription.TabIndex = 9;
            rtbPDescription.Text = "";
            // 
            // tbPStatus
            // 
            tbPStatus.Font = new Font("Segoe UI", 20F);
            tbPStatus.Location = new Point(126, 215);
            tbPStatus.Name = "tbPStatus";
            tbPStatus.Size = new Size(331, 43);
            tbPStatus.TabIndex = 8;
            // 
            // tbPUnit
            // 
            tbPUnit.Font = new Font("Segoe UI", 20F);
            tbPUnit.Location = new Point(126, 146);
            tbPUnit.Name = "tbPUnit";
            tbPUnit.Size = new Size(331, 43);
            tbPUnit.TabIndex = 7;
            // 
            // tbPPrice
            // 
            tbPPrice.Font = new Font("Segoe UI", 20F);
            tbPPrice.Location = new Point(126, 80);
            tbPPrice.Name = "tbPPrice";
            tbPPrice.Size = new Size(331, 43);
            tbPPrice.TabIndex = 6;
            // 
            // lblPStatus
            // 
            lblPStatus.AutoSize = true;
            lblPStatus.Font = new Font("Segoe UI", 20F);
            lblPStatus.Location = new Point(26, 218);
            lblPStatus.Name = "lblPStatus";
            lblPStatus.Size = new Size(94, 37);
            lblPStatus.TabIndex = 5;
            lblPStatus.Text = "Status:";
            // 
            // lblPUnit
            // 
            lblPUnit.AutoSize = true;
            lblPUnit.Font = new Font("Segoe UI", 20F);
            lblPUnit.Location = new Point(26, 149);
            lblPUnit.Name = "lblPUnit";
            lblPUnit.Size = new Size(73, 37);
            lblPUnit.TabIndex = 4;
            lblPUnit.Text = "Unit:";
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new Font("Segoe UI", 20F);
            lblPPrice.Location = new Point(26, 83);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(80, 37);
            lblPPrice.TabIndex = 3;
            lblPPrice.Text = "Price:";
            // 
            // lblPDescription
            // 
            lblPDescription.AutoSize = true;
            lblPDescription.Font = new Font("Segoe UI", 20F);
            lblPDescription.Location = new Point(26, 287);
            lblPDescription.Name = "lblPDescription";
            lblPDescription.Size = new Size(158, 37);
            lblPDescription.TabIndex = 2;
            lblPDescription.Text = "Description:";
            // 
            // tbPName
            // 
            tbPName.Font = new Font("Segoe UI", 20F);
            tbPName.Location = new Point(126, 17);
            tbPName.Name = "tbPName";
            tbPName.Size = new Size(331, 43);
            tbPName.TabIndex = 1;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Font = new Font("Segoe UI", 20F);
            lblPName.Location = new Point(26, 20);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(94, 37);
            lblPName.TabIndex = 0;
            lblPName.Text = "Name:";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(922, 571);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Buy";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 599);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox tbPName;
        private Label lblPName;
        private Label lblPDescription;
        private Label lblPPrice;
        private Label lblPStatus;
        private Label lblPUnit;
        private TextBox tbPStatus;
        private TextBox tbPUnit;
        private TextBox tbPPrice;
        private RichTextBox rtbPDescription;
        private Button btPSend;
    }
}
