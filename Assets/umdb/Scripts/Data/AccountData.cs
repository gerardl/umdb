using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMDB.Data
{
    public class AccountData
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsBanned { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
