using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSAD1_SEM_3_TRAN_DANG_DINH_D00267_20_05_23.Class
{
    public class UserInfo
    {
        private int id;
        private string username;
        private string password;
        private int groupId;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int GroupId { get => groupId; set => groupId = value; }

        public UserInfo(int id, string username, string password, int groupId)
        {
            Id = id;
            Username = username;
            Password = password;
            GroupId = groupId;
        }
    }
}
