using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGH
{
    public class clsDTOLogin
    {
        private string username;
        private string password;

        public clsDTOLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
