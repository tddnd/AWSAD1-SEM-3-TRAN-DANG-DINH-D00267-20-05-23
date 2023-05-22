namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    partial class List
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
            buttonLogout = new Button();
            buttonExitApp = new Button();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.AutoSize = true;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.Location = new Point(826, 466);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(90, 31);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Đăng xuất";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonExitApp
            // 
            buttonExitApp.AutoSize = true;
            buttonExitApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExitApp.Location = new Point(922, 466);
            buttonExitApp.Name = "buttonExitApp";
            buttonExitApp.Size = new Size(75, 31);
            buttonExitApp.TabIndex = 1;
            buttonExitApp.Text = "Thoát";
            buttonExitApp.UseVisualStyleBackColor = true;
            buttonExitApp.Click += buttonExitApp_Click;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonExitApp);
            Controls.Add(buttonLogout);
            Name = "List";
            Size = new Size(1000, 500);
            Load += List_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogout;
        private Button buttonExitApp;
    }
}
