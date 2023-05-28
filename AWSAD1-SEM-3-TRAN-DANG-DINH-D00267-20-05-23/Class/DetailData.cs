using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23.Class
{
    public class DetailData
    {
        private int senderId;
        private string senderName;
        private string senderContent;
        private string senderDate;
        private string reciverName;

        public int SenderId { get => senderId; set => senderId = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderContent { get => senderContent; set => senderContent = value; }
        public string SenderDate { get => senderDate; set => senderDate = value; }

        public string ReciverName { get => reciverName; set => reciverName = value; }

        public DetailData(int senderId, string senderName, string senderContent, string senderDate, string reciverName)
        {
            SenderId = senderId;
            SenderName = senderName;
            SenderContent = senderContent;
            SenderDate = senderDate;
            ReciverName = reciverName;
        }
    }
}
