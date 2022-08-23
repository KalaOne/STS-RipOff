using STS_Rip_Off.Interfaces;
using STS_Rip_Off.Misc;
using static STS_Rip_Off.Character.Character;

namespace STS_Rip_Off.Cards
{

    
    public class Card : ICard
    {
        public string Name { get; set; }
        public CardType Type { get; set; }
        public string Description { get; set; }
        public Rarity Rarity { get; set; }
        public Effect Effect { get; set; }
        public Effect? EffectPlus { get; set; }
        public int Cost { get; set; }


        public Card (string name, CardType type, string desc, Rarity rarity, Effect eff, int cost)
        {
            this.Name = name;
            this.Type = type;
            this.Description = desc;
            this.Rarity = rarity;
            this.Effect = eff;
            this.Cost = cost;
        }
        
        public override string ToString()
        {
            return "\n  Cardname: " + this.Name + " \n   Type: " + this.Type + " \n   Description: " + this.Description + " \n   Effect: " + this.Effect + " \n   Cost: " + this.Cost + "\n";
        }
    }
}
