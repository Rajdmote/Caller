using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connect.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string ticket { get; set; }
        public string Username { get; set; }
        public string Company { get; set; }
        public int COC_Number { get; set; }
    }
}