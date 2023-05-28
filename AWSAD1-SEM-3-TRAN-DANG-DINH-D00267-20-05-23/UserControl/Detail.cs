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
    public partial class Detail : UserControl
    {
        private static Detail instance;
        public static Detail Instance
        {
            get
            {
                if (instance == null)
                    instance = new Detail();
                return instance;
            }
        }
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
