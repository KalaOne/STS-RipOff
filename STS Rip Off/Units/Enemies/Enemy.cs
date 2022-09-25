using STS_Rip_Off.Interfaces;
using STS_Rip_Off.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Units.Enemies
{

    class EnemyProperty
    {
        public int LowHealth { get; set; }
        public int HighHealth { get; set; }
        public string? Power { get; set; }
    }


    class EnemyRngValues
    {
        public string EnemyName { get; set; }
        public decimal LowValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal EncounterChance { get; set; }
    }

    class Enemy : IEnemy
    {
        // List of powers - Do I need it?!
        public enum SlimesWithPairs
        {
            SmallAcidSlimeWithSmallAcidSlimeAndThreeSmallSpikeSlimes,
            SmallAcidSlimeWithOneMediumSpikeSlime,
            SmallSpikeSlimeWithTwoSmallSpikeSlimesAndTwoSmallAcidSlimes,
            SmallSpikeSlimeWithMediumAcidSlime,
            MediumAcidSlimeWithOneSmallSpikeSlime,
            MediumAcidSlimeWithOneBlueSlaver,
            MediumAcidSlimeWithOneRedSlaver,
            MediumAcidSlimeWithOneCultist,
            MediumAcidSlimeWithOneLooter,
            MediumAcidSlimeWithOne,
            MediumAcidSlimeWithOneJawWorm,
            MediumAcidSlimeWithOneFungiBeast
        }


        public static Dictionary<string,EnemyProperty> Enemies = new Dictionary<string,EnemyProperty>()
        {
            {"Acid Slime(S)", new EnemyProperty{ LowHealth= 8,HighHealth=12, Power= null} },

            //new Enemy("Acid Slime(S)", EnemyType.Monster,8,12, false),
            //new Enemy("Acid Slime(S)", EnemyType.Monster,8,12, true, null, SlimesWithPairs.SmallAcidSlimeWithSmallAcidSlimeAndThreeSmallSpikeSlimes),
            //new Enemy("Acid Slime(S)", EnemyType.Monster,8,12, true, null, SlimesWithPairs.SmallAcidSlimeWithOneMediumSpikeSlime),

            //new Enemy("Acid Slime(M)", EnemyType.Monster,28,32, true,  "Split"),
            //new Enemy("Acid Slime(L)", EnemyType.Monster,65,69,"Split"),

            //new Enemy("Spike Slime(S)", EnemyType.Monster,10,14, false),
            //new Enemy("Spike Slime(S)", EnemyType.Monster,10,14, true, null, SlimesWithPairs.SmallSpikeSlimeWithTwoSmallSpikeSlimesAndTwoSmallAcidSlimes),
            //new Enemy("Spike Slime(S)", EnemyType.Monster,10,14, true, null, SlimesWithPairs.SmallSpikeSlimeWithMediumAcidSlime),



        };


        List<EnemyRngValues> EN = new List<EnemyRngValues>();




        // list of properties that a enemy has
        // each enemy will have certain properties
        // check which enemy is selected -> return those properties
      
        public Enemy(int Act, int floor)
        {

            if (Act == 1)
            {
                // loop for floors 1-4
                for (int i = 1; i < 5; i++)
                {
                    if (floor == i)
                    {
                        //rng for the enemy to spawn
                        Random rng = new Random();
                        rng.Next(1,100);
                        this.PopulateListOfEnemies(EnemySpawning.FirstFourfEnemiesAct1EncounterChance);

                        // I need to select the enemy from the list of enemies and build its properties.

                        
                    }
                }
                //loop for floors 5-13
                for (int i = 5; i < 13; i++)
                {
                    if (floor == i)
                    {
                        //rng for the enemy to spawn
                        Random rng = new Random();
                        rng.Next(1, 100);
                        this.PopulateListOfEnemies(EnemySpawning.RemainingfEnemiesAct1EncounterChance);

                        //build enemy based on the selection
                    }
                }
            }
        }

        public Enemy(string name, EnemyType type, int healthLow, int healthHigh, string? power = null)
        {
            Name = name;
            Type = type;
            HealthLowValue = healthLow;
            HealthHighValue = healthHigh;
            Power = power;
        }

        public Enemy(string name, EnemyType type, int healthLow, int healthHigh, bool inParty, string? power = null, SlimesWithPairs? pairType = null)
        {
            Name = name; 
            Type = type;
            HealthLowValue = healthLow;
            HealthHighValue = healthHigh;
            Power = power;
        }

        public string Name { get; set; }
        public EnemyType Type { get; set; }
        public int HealthLowValue { get; set; }
        public int HealthHighValue { get; set; }
        public string? Power { get; set; }
        public bool InPartyWithSomeone { get; set; }
        public List<Enemy>? Party { get; set; }


        // convert each enemy that is a pair to a num to easily select later on.
        



        

        public Enemy SlimeEnemyBuilder(Enemy enemy, SlimesWithPairs? pair = null)
        {
            // swtich for the slimes
            // create the list of slimes 
            // append to the enemy object.
            // return the enemy

            Random rng = new Random();
            var selectedEnemy = EnemySpawning.firstFourRandomEnemies[rng.Next(EnemySpawning.firstFourRandomEnemies.Count)];
            var newEnemy = Enemies.FirstOrDefault(x => x.Name == selectedEnemy);
            Console.WriteLine(newEnemy);
            // select name of the rng result
            // find enemy in list of enemies
            // build that enemy



            return enemy;
        }

        public void PopulateListOfEnemies(Dictionary<string, decimal> enemies)
        {
            decimal previousHighValue = 0.0m;

            for (int i = 0; i < enemies.Count; i++)
            {
                var currentValue = enemies.ElementAt(i);
                EN.Add(
                    new EnemyRngValues
                    {
                        EnemyName = currentValue.Key,
                        LowValue = previousHighValue + 1,
                        HighValue = currentValue.Value + previousHighValue,
                        EncounterChance = currentValue.Value
                    });

                previousHighValue = currentValue.Value + previousHighValue;

            }
        }
    }
}
