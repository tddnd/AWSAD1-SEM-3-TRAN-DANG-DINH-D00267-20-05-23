namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    partial class FormMail
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
            panelFormUC = new Panel();
            loginFormUC = new Login();
            addFormUC = new Add();
            listFormUC = new List();
            detailFormUC = new Detail();
            panelFormUC.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormUC
            // 
            panelFormUC.BorderStyle = BorderStyle.FixedSingle;
            panelFormUC.Controls.Add(loginFormUC);
            panelFormUC.Controls.Add(addFormUC);
            panelFormUC.Controls.Add(listFormUC);
            panelFormUC.Controls.Add(detailFormUC);
            panelFormUC.Location = new Point(4, 4);
            panelFormUC.Name = "panelFormUC";
            panelFormUC.Size = new Size(977, 554);
            panelFormUC.TabIndex = 6;
            // 
            // loginFormUC
            // 
            loginFormUC.Location = new Point(-1, -1);
            loginFormUC.Name = "loginFormUC";
            loginFormUC.Size = new Size(977, 554);
            loginFormUC.TabIndex = 7;
            loginFormUC.Load += loginFormUC_Load;
            // 
            // addFormUC
            // 
            addFormUC.Location = new Point(-1, -1);
            addFormUC.Name = "addFormUC";
            addFormUC.Size = new Size(977, 554);
            addFormUC.TabIndex = 6;
            // 
            // listFormUC
            // 
            listFormUC.Location = new Point(-1, -1);
            listFormUC.Name = "listFormUC";
            listFormUC.Size = new Size(985, 563);
            listFormUC.TabIndex = 5;
            // 
            // detailFormUC
            // 
            detailFormUC.Location = new Point(-1, -1);
            detailFormUC.Name = "detailFormUC";
            detailFormUC.Size = new Size(985, 563);
            detailFormUC.TabIndex = 4;
            // 
            // FormMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panelFormUC);
            Name = "FormMail";
            Text = "Hòm Thư";
            panelFormUC.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFormUC;
        private Detail detailFormUC;
        private List listFormUC;
        private Add addFormUC;
        private Login loginFormUC;
    }
}