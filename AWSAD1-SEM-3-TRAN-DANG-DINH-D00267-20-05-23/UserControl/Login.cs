﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{

    public partial class Login : UserControl
    {
        public event EventHandler SubmitFormEmit;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textUsername.Text = "admin@gmail.com";
            textPassword.Text = "123qwe";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connect = new SqlConnection(FormMail.linkDB);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [USER] WHERE Username = '" + textUsername.Text + "' AND Password = '" + textPassword.Text + "'";
            SqlDataReader LoginUser = cmd.ExecuteReader();

            if (LoginUser.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                FormMail.UserId = LoginUser.GetInt32(0);
                FormMail.UserName = textUsername.Text;
                if (SubmitFormEmit != null)
                {
                    SubmitFormEmit.Invoke(this, e);
                    LoginUser.Close();
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên tài khoản và mật khẩu");
                LoginUser.Close();
            }

        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }
    }
}
