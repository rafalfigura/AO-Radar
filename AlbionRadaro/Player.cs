using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlbionRadaro
{
    class Player
    {
        private Single posX;
        private Single posY;
        private string nickname;
        private string guild;
        private string alliance;
        private int id;
        public Player()
        {
            posX = 0;
            posY = 0;
            nickname = "";
            guild = "";
            alliance = "";
            id = 0;
        }
        public Player(Single posX, Single posY, string nickname, string guild, string alliance, int id)
        {
            this.posX = posX;
            this.posY = posY;
            this.nickname = nickname;
            this.guild = guild;
            this.alliance = alliance;
            this.id = id;
        }
        public override string ToString()
        {
            return nickname + "(" + id + "):" + guild + " " + alliance + " [" + posX + " " + posY + "]";
        }
        public Single PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public Single PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string Guild
        {
            get { return guild; }
            set { guild = value; }
        }
        public string Alliance
        {
            get { return alliance; }
            set { alliance = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
