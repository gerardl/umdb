using UMDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMDB.Stores
{
    public interface IGuildStore
    {
        bool Connect(string connection);
        bool GuildExists(string name);
        GuildData LoadGuild(string name);
        bool SaveGuild(GuildData guildData);
        bool DeleteGuild(string name);
    }
}
