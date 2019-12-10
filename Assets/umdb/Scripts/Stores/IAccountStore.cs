using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMDB.Stores
{
    public interface IAccountStore
    {
        bool Connect(string connection);
        bool Login(string username, string password);
        bool AccountExists(string username);
        bool CreateAccount(string username, string password);
        void BanAccount(string username);
    }
}
