using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro.Mobs
{
    class MobInfo
    {
        public static List<MobInfo> mobsInfo = new List<MobInfo>(new MobInfo[] {
            new MobInfo(9,1, MobType.SKINNABLE),
            new MobInfo(9,1,MobType.SKINNABLE),
            new MobInfo(16,1,MobType.SKINNABLE),
            new MobInfo(17,1,MobType.SKINNABLE),
            new MobInfo(18,1,MobType.SKINNABLE),
            new MobInfo(19,1,MobType.SKINNABLE),
            new MobInfo(20,1,MobType.SKINNABLE),
            new MobInfo(21,1,MobType.SKINNABLE),
            new MobInfo(22,1,MobType.SKINNABLE),
            new MobInfo(23,2,MobType.SKINNABLE),
            new MobInfo(24,3,MobType.SKINNABLE),
            new MobInfo(25,4,MobType.SKINNABLE),
            new MobInfo(26,5,MobType.SKINNABLE),
            new MobInfo(27,6,MobType.SKINNABLE),
            new MobInfo(28,7,MobType.SKINNABLE),
            new MobInfo(29,8,MobType.SKINNABLE),
            new MobInfo(30,1,MobType.SKINNABLE),
            new MobInfo(31,2,MobType.SKINNABLE),
            new MobInfo(32,3,MobType.SKINNABLE),
            new MobInfo(34,5,MobType.SKINNABLE),
            new MobInfo(36,1,MobType.SKINNABLE),
            new MobInfo(37,2,MobType.SKINNABLE),
            new MobInfo(38,3,MobType.SKINNABLE),
            new MobInfo(41,6,MobType.SKINNABLE),
            new MobInfo(42,7,MobType.SKINNABLE),
            new MobInfo(43,8,MobType.SKINNABLE),
            new MobInfo(44,1,MobType.SKINNABLE),
            new MobInfo(45,1,MobType.SKINNABLE),
            new MobInfo(46,6,MobType.HARVESTABLE,HarvestableMobType.ESSENCE),
            new MobInfo(47,6,MobType.HARVESTABLE,HarvestableMobType.ESSENCE),
            new MobInfo(48,3,MobType.HARVESTABLE,HarvestableMobType.SWAMP),
            new MobInfo(49,5,MobType.HARVESTABLE,HarvestableMobType.SWAMP),
            new MobInfo(50,7,MobType.HARVESTABLE,HarvestableMobType.SWAMP),
            new MobInfo(51,6,MobType.HARVESTABLE,HarvestableMobType.SWAMP),
            new MobInfo(52,3,MobType.HARVESTABLE,HarvestableMobType.STEPPE),
            new MobInfo(53,5,MobType.HARVESTABLE,HarvestableMobType.STEPPE),
            new MobInfo(54,7,MobType.HARVESTABLE,HarvestableMobType.STEPPE),
            new MobInfo(55,6,MobType.HARVESTABLE,HarvestableMobType.STEPPE),
            new MobInfo(56,3,MobType.HARVESTABLE,HarvestableMobType.MOUNTAIN),
            new MobInfo(57,3,MobType.HARVESTABLE,HarvestableMobType.MOUNTAIN),
            new MobInfo(58,5,MobType.HARVESTABLE,HarvestableMobType.MOUNTAIN),
            new MobInfo(59,5,MobType.HARVESTABLE,HarvestableMobType.MOUNTAIN),
            new MobInfo(60,7,MobType.HARVESTABLE,HarvestableMobType.MOUNTAIN),
            new MobInfo(61,6,MobType.HARVESTABLE,HarvestableMobType.MOUNTAIN),
            new MobInfo(62,3,MobType.HARVESTABLE,HarvestableMobType.FOREST),
            new MobInfo(63,3,MobType.HARVESTABLE,HarvestableMobType.FOREST),
            new MobInfo(64,5,MobType.HARVESTABLE,HarvestableMobType.FOREST),
            new MobInfo(65,5,MobType.HARVESTABLE,HarvestableMobType.FOREST),
            new MobInfo(66,7,MobType.HARVESTABLE,HarvestableMobType.FOREST),
            new MobInfo(67,6,MobType.HARVESTABLE,HarvestableMobType.FOREST),
            new MobInfo(68,3,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(69,3,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(70,5,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(71,5,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(72,7,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(73,6,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(74,6,MobType.HARVESTABLE,HarvestableMobType.HIGHLAND),
            new MobInfo(419,1,MobType.SKINNABLE),
            new MobInfo(420,1,MobType.SKINNABLE),
            new MobInfo(75, 2,MobType.RESOURCE),
            new MobInfo(76, 3,MobType.RESOURCE),
            new MobInfo(77, 4,MobType.RESOURCE),
            new MobInfo(78, 5,MobType.RESOURCE),
            new MobInfo(79, 6,MobType.RESOURCE),
            new MobInfo(80, 7,MobType.RESOURCE),
            new MobInfo(81, 8,MobType.RESOURCE),
            new MobInfo(82, 4,MobType.RESOURCE),
            new MobInfo(83, 4,MobType.RESOURCE),
            new MobInfo(84, 4,MobType.RESOURCE),
            new MobInfo(85, 4,MobType.RESOURCE),
            new MobInfo(86, 4,MobType.RESOURCE),
            new MobInfo(87, 5,MobType.RESOURCE),
            new MobInfo(88, 5,MobType.RESOURCE),
            new MobInfo(89, 5,MobType.RESOURCE),
            new MobInfo(90, 5,MobType.RESOURCE),
            new MobInfo(91, 5,MobType.RESOURCE),
            new MobInfo(92, 6,MobType.RESOURCE),
            new MobInfo(93, 6,MobType.RESOURCE),
            new MobInfo(94, 6,MobType.RESOURCE),
            new MobInfo(95, 6,MobType.RESOURCE),
            new MobInfo(96, 6,MobType.RESOURCE),
            new MobInfo(97, 7,MobType.RESOURCE),
            new MobInfo(98, 7,MobType.RESOURCE),
            new MobInfo(99, 7,MobType.RESOURCE),
            new MobInfo(100,7,MobType.RESOURCE),
            new MobInfo(101,7,MobType.RESOURCE),
            new MobInfo(102,8,MobType.RESOURCE),
            new MobInfo(103,8,MobType.RESOURCE),
            new MobInfo(104,8,MobType.RESOURCE),
            new MobInfo(105,8,MobType.RESOURCE),
            new MobInfo(106,8,MobType.RESOURCE),
            new MobInfo(107,2,MobType.RESOURCE),
            new MobInfo(108,3,MobType.RESOURCE),
            new MobInfo(109,4,MobType.RESOURCE),
            new MobInfo(110,5,MobType.RESOURCE),
            new MobInfo(111,6,MobType.RESOURCE),
            new MobInfo(112,7,MobType.RESOURCE),
            new MobInfo(113,8,MobType.RESOURCE),
            new MobInfo(114,2,MobType.RESOURCE),
            new MobInfo(115,3,MobType.RESOURCE),
            new MobInfo(116,4,MobType.RESOURCE),
            new MobInfo(117,5,MobType.RESOURCE),
            new MobInfo(118,6,MobType.RESOURCE),
            new MobInfo(119,7,MobType.RESOURCE),
            new MobInfo(120,8,MobType.RESOURCE),
            new MobInfo(121,2,MobType.RESOURCE),
            new MobInfo(122,3,MobType.RESOURCE),
            new MobInfo(123,4,MobType.RESOURCE),
            new MobInfo(124,5,MobType.RESOURCE),
            new MobInfo(125,6,MobType.RESOURCE),
            new MobInfo(126,2,MobType.RESOURCE),
            new MobInfo(127,3,MobType.RESOURCE),
            new MobInfo(128,4,MobType.RESOURCE),
            new MobInfo(129,5,MobType.RESOURCE),
            new MobInfo(130,6,MobType.RESOURCE),
            new MobInfo(131,2,MobType.RESOURCE),
            new MobInfo(132,3,MobType.RESOURCE),
            new MobInfo(133,4,MobType.RESOURCE),
            new MobInfo(134,5,MobType.RESOURCE),
            new MobInfo(135,6,MobType.RESOURCE)
        });

        int id;
        byte tier;
        MobType mobType;
        HarvestableMobType harvestableMobType;

        private MobInfo(int id, byte tier, MobType mobType)
        {
            this.id = id;
            this.tier = tier;
            this.mobType = mobType;
        }
        private MobInfo(int id, byte tier, MobType mobType, HarvestableMobType harvestableMobType)
        {
            this.id = id;
            this.tier = tier;
            this.mobType = mobType;
            this.harvestableMobType = harvestableMobType;
        }
        public override string ToString()
        {
            return "id: " + id + " tier: " + tier + " mobType: " + mobType;
        }
        internal MobType MobType
        {
            get { return mobType; }
            set { mobType = value; }
        }
        public byte Tier
        {
            get { return tier; }
            set { tier = value; }
        }
        public HarvestableMobType HarvestableMobType
        {
            get { return harvestableMobType; }
            set { harvestableMobType = value; }
        }

        public static MobInfo getMobInfo(int mobId){
            foreach (MobInfo i in mobsInfo)
                if (i.id == mobId)
                    return i;
            return null;
            //return mobsInfo.Find(m => m.id == mobId);
        }
    }
}
