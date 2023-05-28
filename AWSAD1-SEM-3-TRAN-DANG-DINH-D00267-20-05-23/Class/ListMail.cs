using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23.Class
{
    internal class ListMail
    {
        private static ListMail instance;
        public static ListMail Instance
        {
            get
            {
                if (instance != null)
                {
                    instance = new ListMail();

                }
                return instance;
            }

            set => instance = value;
        }
        List<Mail> listMailData;

        public List<Mail> ListMailData { get => listMailData; set => listMailData = value; }

        public ListMail()
        {
            listMailData = new List<Mail>();
        }
    }
}
