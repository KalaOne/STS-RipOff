using STS_Rip_Off.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Units.Enemies
{
    public class EnemySpawning
    {
        public static Dictionary<string, decimal> FirstFourfEnemiesAct1EncounterChance = new Dictionary<string, decimal>()
        {
            {"Cultist", 25.00m },
            {"Jaw Worm", 25.00m },
            {"2 Louses", 25.00m },
            {"Small Slimes", 25.00m } // Acid Slime(m) OR Spike(m) + Acid(s) OR Spike(s)
        };

        public static List<string> firstFourRandomEnemies = new List<string>()
        {
            new string("Acid Slime(S)"),
            new string("Acid Slime(S)"),
            new string("Acid Slime(S)"),
            new string("Acid Slime(S)")
        };

        public static Dictionary<string, decimal> RemainingfEnemiesAct1EncounterChance = new Dictionary<string, decimal>()
        {
            {"Gremlin Gang", 6.25m }, // 4 randomly chosen from 2 MAD, 2 SNEAKY, 2 FAT, 1 WIZARD and 1 SHIELD
            {"Large Slime", 12.50m }, // Acid Slime (L) or Spike Slime (L)
            {"Lots of slimes", 6.25m }, // 3 Spike Slime (s) + 2 Acid slime (s)
            {"Blue Slaver", 12.50m },
            {"Red Slaver", 6.25m },
            {"3 Louses", 12.50m }, // Each has 50% chance of being red or green
            {"2 Fungi Beasts", 12.50m },
            {"Exordium Thugs", 9.375m }, // Any Louse or Acid/Spike Slime (M) + Looter or Cultist or Any Slaver.
            {"Exordium Wildfile", 9.375m }, // Fungi Beast or Jaw Worm + Any Louses or Acid/Spike Slime (M).
            {"Looter", 12.50m }
        };


    }
}
