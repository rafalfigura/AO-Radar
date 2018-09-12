using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro.Mobs
{
    class Mob
    {
        int id;
        int typeId;
        Single posX;
        Single posY;
        int health;
        byte enchantmentLevel;
        MobInfo mobInfo;

        public Mob(int id, int typeId, Single posX, Single posY, int health, byte enchantmentLevel)
        {
            this.id = id;
            this.typeId = typeId;
            this.posX = posX;
            this.posY = posY;
            this.health = health;
            this.enchantmentLevel = enchantmentLevel;
            mobInfo = MobInfo.getMobInfo(typeId);
        }
        public override string ToString()
        {
            return "id:" + id + " typeId: " + typeId + " posX: " + posX + " posY: " + posY + " health: " + health + " charges: " + enchantmentLevel;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Single PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        public Single PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public byte EnchantmentLevel
        {
            get { return enchantmentLevel; }
            set { enchantmentLevel = value; }
        }

        internal MobInfo MobInfo
        {
            get { return mobInfo; }
            set { mobInfo = value; }
        }


        internal string getMapStringInfo()
        {
            if (mobInfo != null)
            {
                if (mobInfo.MobType == MobType.HARVESTABLE)
                {
                    switch (mobInfo.HarvestableMobType)
                    {
                        case HarvestableMobType.ESSENCE:
                            return "E";
                        case HarvestableMobType.SWAMP:
                            return "F";
                        case HarvestableMobType.STEPPE:
                            return "L";
                        case HarvestableMobType.MOUNTAIN:
                            return "O";
                        case HarvestableMobType.FOREST:
                            return "W";
                        case HarvestableMobType.HIGHLAND:
                            return "R";

                    }
                }
                else if (mobInfo.MobType == MobType.SKINNABLE)
                {
                    return "S";
                }
                else if (mobInfo.MobType == MobType.OTHER)
                {
                    return "M";
                }
            }
            return "M";
        }
    }
}
