using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencija_Back.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool premiun { get; set; }

    }
}
