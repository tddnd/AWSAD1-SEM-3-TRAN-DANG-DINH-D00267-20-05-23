using AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    public partial class Detail : UserControl
    {
        public event EventHandler DetailBackToList;
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            FormMail.LoadDetailForm += new EventHandler(FormMail_LoadDetailForm);
        }

        protected void FormMail_LoadDetailForm(object sender, EventArgs e)
        {
            LoadDetailMail();
        }

        void LoadDetailMail()
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connect = new SqlConnection(FormMail.linkDB);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [LISTMAIL] WHERE id = '" + FormMail.IndexMail + "'";
            SqlDataReader LoadDetail = cmd.ExecuteReader();

            if (LoadDetail.Read() == true)
            {
                textSendName.Text = LoadDetail.GetString(6);
                textSendTitle.Text = LoadDetail.GetString(2);
                textSendContent.Text = LoadDetail.GetString(3);
                LoadDetail.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                LoadDetail.Close();
            }
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (DetailBackToList != null)
            {
                DetailBackToList.Invoke(this, e);
            }
        }
    }
}
