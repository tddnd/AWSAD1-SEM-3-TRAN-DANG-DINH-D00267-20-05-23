namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    partial class FormLogin
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
            labelPassword = new Label();
            textPassword = new TextBox();
            buttonLogin = new Button();
            buttonExit = new Button();
            labelUserName = new Label();
            textUserName = new TextBox();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(26, 67);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(93, 25);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Mật Khẩu";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(126, 72);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(223, 23);
            textPassword.TabIndex = 3;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSize = true;
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(126, 112);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(89, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Đăng Nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.AutoSize = true;
            buttonExit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(274, 112);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.Location = new Point(26, 24);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(94, 25);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "Tài Khoản";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(126, 29);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(223, 23);
            textUserName.TabIndex = 2;
            textUserName.TextChanged += textUserName_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(textUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Name = "FormLogin";
            Text = "Đăng Nhập";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPassword;
        private TextBox textPassword;
        private Button buttonLogin;
        private Button buttonExit;
        private Label labelUserName;
        private TextBox textUserName;
    }
}