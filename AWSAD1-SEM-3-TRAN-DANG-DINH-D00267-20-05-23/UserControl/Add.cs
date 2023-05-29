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
    public partial class Add : UserControl
    {
        public int UserId;
        public string UserName;
        
        public Add()
        {
            InitializeComponent();
        }
    

        private void Add_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            connect = new SqlConnection(FormMail.linkDB);
            connect.Open();
            DateTime senderDate = DateTime.Now;
            cmd.CommandType = CommandType.Text;
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO [LISTMAIL] (senderId,reciverName,senderTitle,senderContent,senderDate,isRead,senderName) " +
                "values(@senderId,@reciverName,@senderTitle,@senderContent,@senderDate,@isRead,@senderName)";
            cmd.Connection = connect;
            cmd.Parameters.Add("@senderId", SqlDbType.Int).Value = FormMail.UserId;
            cmd.Parameters.Add("@senderName", SqlDbType.NVarChar).Value = FormMail.UserName;
            cmd.Parameters.Add("@reciverName", SqlDbType.NVarChar).Value = textSendName.Text;
            cmd.Parameters.Add("@senderTitle", SqlDbType.NVarChar).Value = textSendTitle.Text;
            cmd.Parameters.Add("@senderContent", SqlDbType.NVarChar).Value = textSendContent.Text;
            cmd.Parameters.Add("@senderDate", SqlDbType.NVarChar).Value = senderDate;
            cmd.Parameters.Add("@isRead", SqlDbType.Bit).Value = 0;
           
            int AddMail = cmd.ExecuteNonQuery();
            if (AddMail > 0)
            {
                MessageBox.Show(FormMail.UserName + " đã gửi thử thành công tới " + textSendName.Text);
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FormMail.UserName + FormMail.UserId);
            // Application.Exit();
        }
    }
}
