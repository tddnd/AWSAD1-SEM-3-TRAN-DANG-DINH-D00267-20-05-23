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
            label1 = new Label();
            listMail = new DataGridView();
            buttonOpenAddMail = new Button();
            ((System.ComponentModel.ISupportInitialize)listMail).BeginInit();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.AutoSize = true;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.Location = new Point(803, 520);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(90, 31);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Đăng xuất";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonExitApp
            // 
            buttonExitApp.AutoSize = true;
            buttonExitApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExitApp.Location = new Point(899, 520);
            buttonExitApp.Name = "buttonExitApp";
            buttonExitApp.Size = new Size(75, 31);
            buttonExitApp.TabIndex = 1;
            buttonExitApp.Text = "Thoát";
            buttonExitApp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 4;
            label1.Text = "Danh sách";
            // 
            // listMail
            // 
            listMail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listMail.Location = new Point(3, 40);
            listMail.Name = "listMail";
            listMail.RowTemplate.Height = 25;
            listMail.Size = new Size(971, 474);
            listMail.TabIndex = 5;
            // 
            // buttonOpenAddMail
            // 
            buttonOpenAddMail.AutoSize = true;
            buttonOpenAddMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenAddMail.Location = new Point(899, 6);
            buttonOpenAddMail.Name = "buttonOpenAddMail";
            buttonOpenAddMail.Size = new Size(75, 31);
            buttonOpenAddMail.TabIndex = 6;
            buttonOpenAddMail.Text = "Gửi thư";
            buttonOpenAddMail.UseVisualStyleBackColor = true;
            buttonOpenAddMail.Click += buttonOpenAddMail_Click;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonOpenAddMail);
            Controls.Add(listMail);
            Controls.Add(label1);
            Controls.Add(buttonExitApp);
            Controls.Add(buttonLogout);
            Name = "List";
            Size = new Size(977, 554);
            Load += List_Load;
            ((System.ComponentModel.ISupportInitialize)listMail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogout;
        private Button buttonExitApp;
        private Label label1;
        private DataGridView listMail;
        private Button buttonOpenAddMail;
    }
}
