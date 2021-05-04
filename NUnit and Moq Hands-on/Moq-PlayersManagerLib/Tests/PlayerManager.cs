using PlayersManagerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class PlayerManager
    {
        IPlayerMapper _playerMapper;
        public PlayerManager(IPlayerMapper playerMapper)
        {
            this._playerMapper = playerMapper;
        }
        public bool TestIsPlayerNameExistsInDb(string name)
        {
            bool player = _playerMapper.IsPlayerNameExistsInDb(name);
            return player;
        }
    }
}
