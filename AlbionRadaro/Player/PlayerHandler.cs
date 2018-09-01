using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlbionRadaro
{
    class PlayerHandler
    {
        private List<Player> playersInRange;
        private Player localPlayer;

        public PlayerHandler()
        {
            playersInRange = new List<Player>();
            localPlayer = new Player();
        }
        public void AddPlayer(Single posX, Single posY, string nickname, string guild, string alliance, int id)
        {
            Player p = new Player(posX, posY, nickname, guild, alliance, id);
            if(!playersInRange.Contains(p))
                playersInRange.Add(p);
            //Console.WriteLine("Added player: " + p.ToString());
        }
        public bool RemovePlayer(int id)
        {
            return playersInRange.RemoveAll(x => x.Id == id) > 0;
        }
        internal List<Player> PlayersInRange
        {
            get { return playersInRange; }
        }
        public void UpdateLocalPlayerPosition(Single posX, Single posY)
        {
            localPlayer.PosX = posX;
            localPlayer.PosY = posY;
        }
        internal void UpdatePlayerPosition(int id, float posX, float posY)
        {
            playersInRange.ForEach(p =>
            {
                if (p.Id == id)
                {
                    p.PosX = posX;
                    p.PosY = posY;
                }
            });

        }
        public Single localPlayerPosX()
        {
            return localPlayer.PosX;
        }
        public Single localPlayerPosY()
        {
            return localPlayer.PosY;
        }
    }
}
