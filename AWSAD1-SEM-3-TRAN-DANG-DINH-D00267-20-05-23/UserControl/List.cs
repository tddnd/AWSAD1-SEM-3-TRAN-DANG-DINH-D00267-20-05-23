using System;
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
        private static List instance;
        public static List Instance
        {
            get
            {
                if (instance == null)
                    instance = new List();
                return instance;
            }
        }
        public List()
        {
            InitializeComponent();
        }

        #region Method
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
        #endregion

        #region Event
        private void buttonLogout_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void List_Load(object sender, EventArgs e)
        {
            CreateColumForDataGirdView();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
