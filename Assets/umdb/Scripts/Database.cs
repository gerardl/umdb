using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMDB.Stores;
using UMDB.Data;

namespace UMDB
{
    public class Database
    {
        private readonly IAccountStore _accountStore;
        private readonly IPlayerStore _playerStore;
        private readonly IGuildStore _guildStore;

        public Database(string accountConnection, IAccountStore accountStore, 
            string playerConnection, IPlayerStore playerStore, 
            string guildConnection, IGuildStore guildStore)
        {
            _accountStore = accountStore;
            _playerStore = playerStore;
            _guildStore = guildStore;

            _accountStore.Connect(accountConnection);
            _playerStore.Connect(playerConnection);
            _guildStore.Connect(guildConnection);
        }

        #region Account

        public virtual bool CreateAccount(string username, string password)
        {
            if (!_accountStore.AccountExists(username))
            {
                return _accountStore.CreateAccount(username, password);
            }
            else return false;
        }

        public virtual bool Login(string username, string password)
        {
            return _accountStore.Login(username, password);
        }

        #endregion

        #region Player

        public virtual void SavePlayer(PlayerData playerData, bool isOnline)
        {
            _playerStore.SavePlayer(playerData, isOnline);
        }

        public virtual void SavePlayers(List<PlayerData> playerData, bool isOnline)
        {
            _playerStore.SavePlayers(playerData, isOnline);
        }

        public virtual PlayerData LoadPlayer(string name)
        {
            return _playerStore.LoadPlayer(name);
        }

        #endregion

        #region Guild

        public virtual void SaveGuild(GuildData guildData)
        {
            _guildStore.SaveGuild(guildData);
        }

        public virtual GuildData LoadGuild(string name)
        {
            return _guildStore.LoadGuild(name);
        }

        #endregion
    }
}

