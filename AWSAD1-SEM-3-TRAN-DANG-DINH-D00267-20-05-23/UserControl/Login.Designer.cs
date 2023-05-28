namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            buttonLogin = new Button();
            buttonExitApp = new Button();
            label1 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            resources.ApplyResources(buttonLogin, "buttonLogin");
            buttonLogin.Name = "buttonLogin";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExitApp
            // 
            resources.ApplyResources(buttonExitApp, "buttonExitApp");
            buttonExitApp.Name = "buttonExitApp";
            buttonExitApp.UseVisualStyleBackColor = true;
            buttonExitApp.Click += buttonExitApp_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textUsername
            // 
            textUsername.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(textUsername, "textUsername");
            textUsername.Name = "textUsername";
            // 
            // textPassword
            // 
            textPassword.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(textPassword, "textPassword");
            textPassword.Name = "textPassword";
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Controls.Add(buttonExitApp);
            Controls.Add(buttonLogin);
            Name = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonExitApp;
        private Label label1;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label label2;
        private Label label3;
    }
}
