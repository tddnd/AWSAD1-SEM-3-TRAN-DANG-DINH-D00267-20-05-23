﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23.Class;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    public partial class List : UserControl
    {
        public event EventHandler OpenAddForm;
        public event EventHandler BackToLogin;

        public List()
        {
            InitializeComponent();
        }

        void CreateColumForDataGirdView()
        {
            var colName = new DataGridViewTextBoxColumn();
            var colContent = new DataGridViewTextBoxColumn();
            var colDate = new DataGridViewTextBoxColumn();

            colName.HeaderText = "Người gửi";
            colContent.HeaderText = "Nội dung";
            colDate.HeaderText = "Thời gian";

            colName.DataPropertyName = "SenderName";
            colContent.DataPropertyName = "SenderContent";
            colDate.DataPropertyName = "SenderDate";

            colName.Width = 200;
            colContent.Width = 527;
            colDate.Width = 200;

            colName.ReadOnly = true;
            colContent.ReadOnly = true;
            colDate.ReadOnly = true;

            listMail.Columns.AddRange(new DataGridViewTextBoxColumn[] { colName, colContent, colDate });
        }

        void LoadlistPhoneBook()
        {
            listMail.DataSource = ListMail.Instance.ListMailData;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (BackToLogin != null)
            {
                BackToLogin.Invoke(this, e);
            }
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void List_Load(object sender, EventArgs e)
        {
            CreateColumForDataGirdView();
        }

        private void buttonOpenAddMail_Click(object sender, EventArgs e)
        {
            if (OpenAddForm != null)
            {
                OpenAddForm.Invoke(this, e);
            }
        }
    }
}
