using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRadaro
{
    public static class Settings
    {
        static List<String> tiers = new List<String>();
        static List<HarvestableType> harvestable = new List<HarvestableType>();
        static bool onlyRares = false;
        static bool displayPeople = true;
        static bool soundsOnPlayer = false;
        static bool livingEntities = false;

        public static bool LivingEntities
        {
            get { return Settings.livingEntities; }
            set { Settings.livingEntities = value; }
        }
        public static void saveSettings(Form1 form){
            AppSettings s = new AppSettings();

            s.T123 = form.cbTier1230.Checked;
            s.T40 = form.cbTier40.Checked; 
            s.T41 = form.cbTier41.Checked; 
            s.T42 = form.cbTier42.Checked; 
            s.T43 = form.cbTier43.Checked; 
            s.T50 = form.cbTier50.Checked; 
            s.T51 = form.cbTier51.Checked; 
            s.T52 = form.cbTier52.Checked; 
            s.T53 = form.cbTier53.Checked; 
            s.T60 = form.cbTier60.Checked; 
            s.T61 = form.cbTier61.Checked; 
            s.T62 = form.cbTier62.Checked; 
            s.T63 = form.cbTier63.Checked; 
            s.T70 = form.cbTier70.Checked; 
            s.T71 = form.cbTier71.Checked; 
            s.T72 = form.cbTier72.Checked; 
            s.T73 = form.cbTier73.Checked; 
            s.T80 = form.cbTier80.Checked; 
            s.T81 = form.cbTier81.Checked; 
            s.T82 = form.cbTier82.Checked; 
            s.T83 = form.cbTier83.Checked;
            s.rFiber     = form.cbFiber.Checked;
            s.rWood      = form.cbWood.Checked;
            s.rOre       = form.cbOre.Checked;
            s.rAnimal    = form.cbAnimal.Checked;
            s.rRock      = form.cbRock.Checked;
            s.rElemental = form.cbEntities.Checked;
            s.rMob       = form.cbMob.Checked;
            s.rTreasures = form.cbTreasures.Checked;
            s.rSoundOnPlayer = form.cbSounds.Checked;
            s.Save();
        }
        public static void loadSettings(Form1 form)
        {
            AppSettings s = new AppSettings();

            form.cbTier1230.Checked = s.T123;
            form.cbTier40.Checked = s.T40;
            form.cbTier41.Checked = s.T41;
            form.cbTier42.Checked = s.T42;
            form.cbTier43.Checked = s.T43;
            form.cbTier50.Checked = s.T50;
            form.cbTier51.Checked = s.T51;
            form.cbTier52.Checked = s.T52;
            form.cbTier53.Checked = s.T53;
            form.cbTier60.Checked = s.T60;
            form.cbTier61.Checked = s.T61;
            form.cbTier62.Checked = s.T62;
            form.cbTier63.Checked = s.T63;
            form.cbTier70.Checked = s.T70;
            form.cbTier71.Checked = s.T71;
            form.cbTier72.Checked = s.T72;
            form.cbTier73.Checked = s.T73;
            form.cbTier80.Checked = s.T80;
            form.cbTier81.Checked = s.T81;
            form.cbTier82.Checked = s.T82;
            form.cbTier83.Checked = s.T83;
            form.cbFiber.Checked     = s.rFiber;    
            form.cbWood.Checked      = s.rWood;     
            form.cbOre.Checked       = s.rOre ;     
            form.cbAnimal.Checked    = s.rAnimal  ; 
            form.cbRock.Checked      = s.rRock ;    
            form.cbEntities.Checked = s.rElemental;
            form.cbMob.Checked       = s.rMob      ;
            form.cbTreasures.Checked = s.rTreasures;
            form.cbSounds.Checked = s.rSoundOnPlayer;

        }
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
        public static bool IsInTiers(byte tier, byte enchant)
        {
            return tiers.Contains(tier+"."+enchant);
        }
        public static bool OnlyRares()
        {
            return onlyRares;
        }
        public static bool IsInHarvestable(HarvestableType ht)
        {
            return harvestable.Contains(ht);
        }

        public static void UpdateTier(int tier, byte enchant, bool show)
        {
            byte bTier = (byte) tier;
            String iString = tier + "." + enchant;
            if(show){
                if (!tiers.Contains(iString))
                    tiers.Add(iString);
            }else{
                if (tiers.Contains(iString))
                    tiers.Remove(iString);
            }
        }

        public static void UpdateHarvestable(List<HarvestableType> h, bool show)
        {
            if(show){
                foreach(HarvestableType ht in h)
                    if (!harvestable.Contains(ht)) 
                        harvestable.Add(ht);
            }
            else
            {
                foreach (HarvestableType ht in h)
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

        internal static void showEntities(bool p)
        {
            livingEntities = p;
        }
    }
}
