using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMDB.Data;

namespace UMDB.Stores
{
    public interface IPlayerStore
    {
        bool Connect(string connection);
        bool PlayerExists(string name);
        PlayerData LoadPlayer(string name);
        void SavePlayer(PlayerData player, bool isOnline);
        void SavePlayers(List<PlayerData> player, bool isOnline);
        void DeletePlayer(string name);
    }
}
