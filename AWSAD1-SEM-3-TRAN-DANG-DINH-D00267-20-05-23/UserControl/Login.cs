using System;
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

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{

    public partial class Login : UserControl
    {
        public event EventHandler SubmitFormEmit;
        private static Login instance;
        public static Login Instance
        {
            get
            {
                if (instance == null)
                    instance = new Login();
                return instance;
            }
        }
        string str = "Data Source=MSI-TRIDENT-X-P\\N1GHTMARE1VN18;Initial Catalog=AWSAD1;Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection kn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            kn = new SqlConnection(str);
            kn.Open();
        }

        private void textTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            cmd = kn.CreateCommand();
            cmd.CommandText = "SELECT * FROM [USER] WHERE Username = '" + textUsername.Text + "' AND Password = '" + textPassword.Text + "'";
            SqlDataReader DR = cmd.ExecuteReader();
            // DBCheckLogin dBCheckLogin = new DBCheckLogin(DR.Read());

            if (DR.Read() == true)
            {
                DR.Close();
                MessageBox.Show("Đăng nhập thành công");

                if (SubmitFormEmit != null)
                {
                    SubmitFormEmit.Invoke(this, e);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên tài khoản và mật khẩu");
            }

        }

        private void SubmitForm(object sender, EventArgs e)
        {

        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class DBCheckLogin
    {
        public bool Result { get; set; }
        public DBCheckLogin(bool result)
        {
            Result = result;
        }
    }
}
