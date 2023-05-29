using Microsoft.VisualBasic.ApplicationServices;
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
        public static int UserId;
        public static string UserName;
        public static string linkDB = "Data Source=MSI-TRIDENT-X-P\\N1GHTMARE1VN18;Initial Catalog=AWSAD1;Integrated Security=True;MultipleActiveResultSets=True";
        public FormMail()
        {
            InitializeComponent();
        }

        private void FormMail_Load(object sender, EventArgs e)
        {
            loginFormUC.SubmitFormEmit += new EventHandler(loginFormUC_SubmitFormEmit);

            listFormUC.OpenAddForm += new EventHandler(listFormUC_OpenAddForm);
            listFormUC.BackToLogin += new EventHandler(listFormUC_BackToLogin);

            addFormUC.BackToList += new EventHandler(addFormUC_BackToList);
        }

        private void loginFormUC_Load(object sender, EventArgs e)
        {

        }

        protected void loginFormUC_SubmitFormEmit(object sender, EventArgs e)
        {
            listFormUC.BringToFront();
            FormMail.ActiveForm.Text = "Xin chào " + UserName + " - id: " + UserId;
        }

        protected void listFormUC_OpenAddForm(object sender, EventArgs e)
        {
            addFormUC.BringToFront();
        }

        protected void listFormUC_BackToLogin(object sender, EventArgs e)
        {
            loginFormUC.BringToFront();
        }

        protected void addFormUC_BackToList(object sender, EventArgs e)
        {
            listFormUC.BringToFront();
        }
    }
}
