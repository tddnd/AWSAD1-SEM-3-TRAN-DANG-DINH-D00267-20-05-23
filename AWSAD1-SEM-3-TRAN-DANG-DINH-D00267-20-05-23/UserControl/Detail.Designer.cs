namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    partial class Detail
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
            buttonBack = new Button();
            buttonExitApp = new Button();
            label1 = new Label();
            label2 = new Label();
            textSendName = new TextBox();
            textSendTitle = new TextBox();
            textSendContent = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(818, 520);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 31);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Trở lại";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonExitApp
            // 
            buttonExitApp.AutoSize = true;
            buttonExitApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExitApp.Location = new Point(899, 520);
            buttonExitApp.Name = "buttonExitApp";
            buttonExitApp.Size = new Size(75, 31);
            buttonExitApp.TabIndex = 3;
            buttonExitApp.Text = "Thoát";
            buttonExitApp.UseVisualStyleBackColor = true;
            buttonExitApp.Click += buttonExitApp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 4;
            label1.Text = "Chi Tiết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 50);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 9;
            label2.Text = "Từ";
            // 
            // textSendName
            // 
            textSendName.BackColor = SystemColors.ButtonHighlight;
            textSendName.Location = new Point(114, 52);
            textSendName.Name = "textSendName";
            textSendName.ReadOnly = true;
            textSendName.Size = new Size(500, 23);
            textSendName.TabIndex = 10;
            // 
            // textSendTitle
            // 
            textSendTitle.BackColor = SystemColors.ButtonHighlight;
            textSendTitle.Location = new Point(114, 102);
            textSendTitle.Name = "textSendTitle";
            textSendTitle.ReadOnly = true;
            textSendTitle.Size = new Size(500, 23);
            textSendTitle.TabIndex = 11;
            // 
            // textSendContent
            // 
            textSendContent.AcceptsReturn = true;
            textSendContent.AcceptsTab = true;
            textSendContent.BackColor = SystemColors.ButtonHighlight;
            textSendContent.Location = new Point(114, 152);
            textSendContent.Multiline = true;
            textSendContent.Name = "textSendContent";
            textSendContent.ReadOnly = true;
            textSendContent.ScrollBars = ScrollBars.Vertical;
            textSendContent.Size = new Size(500, 250);
            textSendContent.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 13;
            label3.Text = "Tiêu đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 150);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 14;
            label4.Text = "Nội dung";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textSendContent);
            Controls.Add(textSendTitle);
            Controls.Add(textSendName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonExitApp);
            Controls.Add(buttonBack);
            Name = "Detail";
            Size = new Size(977, 554);
            Load += Detail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonExitApp;
        private Label label1;
        private Label label2;
        private TextBox textSendName;
        private TextBox textSendTitle;
        private TextBox textSendContent;
        private Label label3;
        private Label label4;
    }
}
