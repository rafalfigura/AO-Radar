using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro
{
    public static class Settings
    {
        static List<byte> tiers = new List<byte>();
        static List<HarvestableType> harvestable = new List<HarvestableType>();
        static bool onlyRares = false;
        static bool displayPeople = true;
        static bool soundsOnPlayer = false;

        public static bool DisplayPeople
        {
            get { return Settings.displayPeople; }
            set { Settings.displayPeople = value; }
        }

        public static bool PlaySoundOnPlayer()
        {
            return soundsOnPlayer;
        }
        public static void UpdateDisplayPeople(bool val)
        {
            displayPeople = val;
        }
        public static bool IsInTiers(byte tier)
        {
            return tiers.Contains(tier);
        }
        public static bool OnlyRares()
        {
            return onlyRares;
        }
        public static bool IsInHarvestable(HarvestableType ht)
        {
            return harvestable.Contains(ht);
        }

        public static void UpdateTier(int tier, bool show)
        {

            byte bTier = (byte) tier;
            if(show){
                if(!tiers.Contains(bTier))
                    tiers.Add(bTier);
            }else{
                if(tiers.Contains(bTier))
                    tiers.Remove(bTier);
            }
        }

        public static void UpdateHarvestable(HarvestableType ht, bool show)
        {
            if(show){
                if (!harvestable.Contains(ht)) 
                    harvestable.Add(ht);
            }else{
                if (harvestable.Contains(ht)) 
                    harvestable.Remove(ht);
            }
        }


        internal static void UpdateOnlyRares(bool raresOnly)
        {
            onlyRares = raresOnly;
        }

        internal static void setSoundsOnPlayer(bool p)
        {
            soundsOnPlayer = p;
        }
    }
}
