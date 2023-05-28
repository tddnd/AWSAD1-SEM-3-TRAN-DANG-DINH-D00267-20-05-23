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
            label1 = new Label();
            buttonBack = new Button();
            buttonExitApp = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonSendMail = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 5;
            label1.Text = "Gửi thư";
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
            // textBox1
            // 
            textBox1.Location = new Point(114, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.AcceptsTab = true;
            textBox3.Location = new Point(114, 152);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(500, 250);
            textBox3.TabIndex = 3;
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
            // AddMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSendMail);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonExitApp);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "AddMail";
            Size = new Size(977, 554);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonExitApp;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonSendMail;
    }
}
