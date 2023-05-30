using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23.Class
{
    public class Mail
    {
        private string senderName;
        private string senderContent;
        private string senderDate;

        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderContent { get => senderContent; set => senderContent = value; }
        public string SenderDate { get => senderDate; set => senderDate = value; }

        public Mail(string senderName, string senderContent, string senderDate)
        {
            SenderName = senderName;
            SenderContent = senderContent;
            SenderDate = senderDate;
        }
    }
}
