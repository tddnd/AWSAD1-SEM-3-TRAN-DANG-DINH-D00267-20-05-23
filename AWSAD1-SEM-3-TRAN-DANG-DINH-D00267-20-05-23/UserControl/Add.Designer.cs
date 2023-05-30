namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    partial class Add
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
            labelAddHeader = new Label();
            buttonBack = new Button();
            buttonExitApp = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textSendName = new TextBox();
            textSendTitle = new TextBox();
            textSendContent = new TextBox();
            buttonSendMail = new Button();
            SuspendLayout();
            // 
            // labelAddHeader
            // 
            labelAddHeader.AutoSize = true;
            labelAddHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddHeader.Location = new Point(3, 8);
            labelAddHeader.Name = "labelAddHeader";
            labelAddHeader.Size = new Size(74, 25);
            labelAddHeader.TabIndex = 5;
            labelAddHeader.Text = "Gửi thư";
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(803, 520);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 31);
            buttonBack.TabIndex = 6;
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
            buttonExitApp.TabIndex = 7;
            buttonExitApp.Text = "Thoát";
            buttonExitApp.UseVisualStyleBackColor = true;
            buttonExitApp.Click += buttonExitApp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 50);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 8;
            label2.Text = "Đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 9;
            label3.Text = "Tiêu đề";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 150);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 10;
            label4.Text = "Nội dung";
            // 
            // textSendName
            // 
            textSendName.Location = new Point(114, 52);
            textSendName.Name = "textSendName";
            textSendName.Size = new Size(500, 23);
            textSendName.TabIndex = 1;
            // 
            // textSendTitle
            // 
            textSendTitle.Location = new Point(114, 102);
            textSendTitle.Name = "textSendTitle";
            textSendTitle.Size = new Size(500, 23);
            textSendTitle.TabIndex = 2;
            // 
            // textSendContent
            // 
            textSendContent.AcceptsReturn = true;
            textSendContent.AcceptsTab = true;
            textSendContent.Location = new Point(114, 152);
            textSendContent.Multiline = true;
            textSendContent.Name = "textSendContent";
            textSendContent.ScrollBars = ScrollBars.Vertical;
            textSendContent.Size = new Size(500, 250);
            textSendContent.TabIndex = 3;
            textSendContent.KeyUp += textSendContent_KeyUp;
            // 
            // buttonSendMail
            // 
            buttonSendMail.AutoSize = true;
            buttonSendMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSendMail.Location = new Point(524, 425);
            buttonSendMail.Name = "buttonSendMail";
            buttonSendMail.Size = new Size(90, 31);
            buttonSendMail.TabIndex = 11;
            buttonSendMail.Text = "Gửi";
            buttonSendMail.UseVisualStyleBackColor = true;
            buttonSendMail.Click += buttonSendMail_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSendMail);
            Controls.Add(textSendContent);
            Controls.Add(textSendTitle);
            Controls.Add(textSendName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonExitApp);
            Controls.Add(buttonBack);
            Controls.Add(labelAddHeader);
            Name = "Add";
            Size = new Size(977, 554);
            Load += Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddHeader;
        private Button buttonBack;
        private Button buttonExitApp;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textSendName;
        private TextBox textSendTitle;
        private TextBox textSendContent;
        private Button buttonSendMail;
    }
}
