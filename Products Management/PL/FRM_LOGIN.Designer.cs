namespace Products_Management.PL
{
    partial class FRM_LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtPWD = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "اسم المستخدم:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 88);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "كلمة السر:";
            // 
            // txtID
            // 
            txtID.Location = new Point(135, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(317, 23);
            txtID.TabIndex = 2;
            // 
            // txtPWD
            // 
            txtPWD.Location = new Point(135, 85);
            txtPWD.Name = "txtPWD";
            txtPWD.PasswordChar = '*';
            txtPWD.Size = new Size(317, 23);
            txtPWD.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(377, 125);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "الدخول";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(274, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FRM_LOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 197);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPWD);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_LOGIN";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "نافذة الدخول:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtPWD;
        private Button btnLogin;
        private Button btnCancel;
    }
}