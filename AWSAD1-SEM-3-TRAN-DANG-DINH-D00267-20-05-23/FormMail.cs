using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginFormUC.BringToFront();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listFormUC.BringToFront();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            detailFormUC.BringToFront();
        }

        private void loginFormUC_Load(object sender, EventArgs e)
        {

        }

        private void loginFormUC_SubmitFormEmit(object sender, EventArgs e)
        {
            listFormUC.BringToFront();
        }
    }
}
