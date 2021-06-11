using Terraria;
using Terraria.ModLoader;


namespace TSMusic2
{
    public class TSMusic2 : Mod
    {
        public TSMusic2 Instance;

        public TSMusic2()
        {
            Mod = this;

            Instance = this;

            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
        }

        public static Mod TerraStory { get; set; }

        public static TSMusic2 Mod { get; set; }

        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {

            if (Main.myPlayer != -1 && !Main.gameMenu)
            {
                if (Main.player[Main.myPlayer].ZoneHoly)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/DreamHallow");
                    priority = MusicPriority.BiomeLow;
                }
                if (Main.player[Main.myPlayer].ZoneCorrupt)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/Laby");
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].ZoneCrimson)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/CrimsonwoodCrimson");
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].ZoneSandstorm)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/PerionSandstorm");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneBeach)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/BlueWorld");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneJungle)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/JungleBook");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/SunsetDesert");
                    priority = MusicPriority.BiomeLow;
                }
            }
        }
    }
}