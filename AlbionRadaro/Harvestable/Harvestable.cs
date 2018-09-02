using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlbionRadaro
{
    class Harvestable
    {
        private int id;
        private byte type;
        private byte tier;
        private Single posX;
        private Single posY;
        private byte charges;
        private byte size;

        public Harvestable(int id, byte type, byte tier, Single posX, Single posY, byte charges, byte size)
        {
            this.id = id;
            this.type = type;
            this.tier = tier;
            this.posX = posX;
            this.posY = posY;
            this.charges = charges;
            this.size = size;
        }
        public override string ToString()
        {
            return "id: " + id + " type:" + (HarvestableType)type + " tier: " + tier +  " Size: " + size +  " posX:" + posX + " posY: " + posY + " charges: " + charges;
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
        public int Id
        {
            get { return id; }
        }

        public byte Type
        {
            get { return type; }
            set { type = value; }
        }

        public byte Tier
        {
            get { return tier; }
            set { tier = value; }
        }

        public byte Charges
        {
            get { return charges; }
            set { charges = value; }
        }
        public string GetInfo()
        {
            return (HarvestableType)type + " T: " + tier;
        }
        public byte Size
        {
            get { return size; }
            set { size = value; }
        }
        public static string getMapStringInfo(HarvestableType type)
        {
            switch (type)
            {
                case HarvestableType.WOOD:
                case HarvestableType.WOOD_GIANTTREE:
                case HarvestableType.WOOD_CRITTER_GREEN:
                case HarvestableType.WOOD_CRITTER_RED:
                case HarvestableType.WOOD_CRITTER_DEAD:
                case HarvestableType.WOOD_GUARDIAN_RED:
                    return "W";
                case HarvestableType.ROCK:
                case HarvestableType.ROCK_CRITTER_GREEN:
                case HarvestableType.ROCK_CRITTER_RED:
                case HarvestableType.ROCK_CRITTER_DEAD:
                case HarvestableType.ROCK_GUARDIAN_RED:
                    return "R";
                case HarvestableType.FIBER:
                case HarvestableType.FIBER_CRITTER:
                case HarvestableType.FIBER_GUARDIAN_RED:
                case HarvestableType.FIBER_GUARDIAN_DEAD:
                    return "F";
                case HarvestableType.HIDE:
                case HarvestableType.HIDE_FOREST:
                case HarvestableType.HIDE_STEPPE:
                case HarvestableType.HIDE_SWAMP:
                case HarvestableType.HIDE_MOUNTAIN:
                case HarvestableType.HIDE_HIGHLAND:
                case HarvestableType.HIDE_CRITTER:
                case HarvestableType.HIDE_GUARDIAN:
                    return "H";
                case HarvestableType.ORE:
                case HarvestableType.ORE_CRITTER_GREEN:
                case HarvestableType.ORE_CRITTER_RED:
                case HarvestableType.ORE_CRITTER_DEAD:
                case HarvestableType.ORE_GUARDIAN_RED:
                    return "O";
                case HarvestableType.DEADRAT:
                    return "DEAD_RAT";
                case HarvestableType.SILVERCOINS_NODE:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_ELITE_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_ROAMING:
                case HarvestableType.SILVERCOINS_LOOT_ROAMING_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_ROAMING_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN:
                case HarvestableType.SILVERCOINS_LOOT_ELITE:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_ELITE_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_ELITE_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_STANDARD:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_STANDARD_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_VETERAN:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_DEMON:
                case HarvestableType.SILVERCOINS_LOOT_SARCOPHAGUS_STANDARD_MINIBOSS:
                    return "SILVER";
                case HarvestableType.CHEST_EXP_SILVERCOINS_LOOT_STANDARD:
                case HarvestableType.CHEST_EXP_SILVERCOINS_LOOT_VETERAN:
                    return "CHEST";
                default:
                    return "ERR" + type;
            }
        }
        public string getMapInfo()
        {
            switch ((HarvestableType)type)
            {
                case HarvestableType.WOOD:
                case HarvestableType.WOOD_GIANTTREE:
                case HarvestableType.WOOD_CRITTER_GREEN:
                case HarvestableType.WOOD_CRITTER_RED:
                case HarvestableType.WOOD_CRITTER_DEAD:
                case HarvestableType.WOOD_GUARDIAN_RED:
                    return "W";
                case HarvestableType.ROCK:
                case HarvestableType.ROCK_CRITTER_GREEN:
                case HarvestableType.ROCK_CRITTER_RED:
                case HarvestableType.ROCK_CRITTER_DEAD:
                case HarvestableType.ROCK_GUARDIAN_RED:
                    return "R";
                case HarvestableType.FIBER:
                case HarvestableType.FIBER_CRITTER:
                case HarvestableType.FIBER_GUARDIAN_RED:
                case HarvestableType.FIBER_GUARDIAN_DEAD:
                    return "F";
                case HarvestableType.HIDE:
                case HarvestableType.HIDE_FOREST:
                case HarvestableType.HIDE_STEPPE:
                case HarvestableType.HIDE_SWAMP:
                case HarvestableType.HIDE_MOUNTAIN:
                case HarvestableType.HIDE_HIGHLAND:
                case HarvestableType.HIDE_CRITTER:
                case HarvestableType.HIDE_GUARDIAN:
                    return "H";
                case HarvestableType.ORE:
                case HarvestableType.ORE_CRITTER_GREEN:
                case HarvestableType.ORE_CRITTER_RED:
                case HarvestableType.ORE_CRITTER_DEAD:
                case HarvestableType.ORE_GUARDIAN_RED:
                    return "O";
                case HarvestableType.DEADRAT:
                    return "DEAD_RAT";
                case HarvestableType.SILVERCOINS_NODE:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_ELITE_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_ROAMING:
                case HarvestableType.SILVERCOINS_LOOT_ROAMING_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_ROAMING_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN:
                case HarvestableType.SILVERCOINS_LOOT_ELITE:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_ELITE_MINIBOSS:
                case HarvestableType.SILVERCOINS_LOOT_STANDARD_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_VETERAN_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_ELITE_BOSS:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_STANDARD:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_STANDARD_TRASH:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_VETERAN:
                case HarvestableType.SILVERCOINS_LOOT_CHEST_DEMON:
                case HarvestableType.SILVERCOINS_LOOT_SARCOPHAGUS_STANDARD_MINIBOSS:
                    return "SILVER";
                case HarvestableType.CHEST_EXP_SILVERCOINS_LOOT_STANDARD:
                case HarvestableType.CHEST_EXP_SILVERCOINS_LOOT_VETERAN:
                    return "CHEST";
                default:
                    return "ERR"+type;
            }
        }

    }
}
