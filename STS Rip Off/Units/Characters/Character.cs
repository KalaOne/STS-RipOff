using STS_Rip_Off.Cards;
using STS_Rip_Off.Interfaces;
using STS_Rip_Off.Misc;
using STS_Rip_Off.Relics;
using System.Text;

namespace STS_Rip_Off.Character
{
    public class Character : ICharacter
    {

        public CharacterType CharType { get; set; }

        public Relic StartingRelic { get; set; }
        public List<Relic> Relics { get; set; } = new List<Relic>();
        public List<Card> Deck { get; set; }
        public int Gold { get; set; } = 99;
        public int Health { get; set; }
        public int Energy { get; set; } = 3;
        public List<Potion> Potions { get; set; } = new List<Potion>();

        public enum CharacterType
        {
            Ironclad,
            Silent,
            Defect,
            Watcher
        }

        public void GetChacater(string characterSelected)
        {

            Console.WriteLine("character to select:" + characterSelected);
            switch (characterSelected)
            {
                
                case "ironclad":
                    this.CharType = CharacterType.Ironclad;
                    this.BuildCharater(this.CharType);
                    break;
                case "silent":
                    this.CharType = CharacterType.Silent;
                    this.BuildCharater(this.CharType);
                    break;
                case "defect": 
                    this.CharType =  CharacterType.Defect;
                    this.BuildCharater(this.CharType);
                    break;
                case "watcher":
                    this.CharType = CharacterType.Watcher;
                    this.BuildCharater(this.CharType);
                    break;
                default: break;
            }
        }

        private void BuildCharater(CharacterType charType)
        {
            this.StartingRelic = this.GiveRelic(charType);
            this.Health = 70;
            this.Deck = this.BuildDeck(charType);

        }

        private List<Card> BuildDeck(CharacterType charType)
        {
            List<Card> Deck;
            
            switch (charType)
            {
                case CharacterType.Ironclad:
                    Deck = new List<Card>();
                    for (int i = 0; i < 5; i++)
                    {
                        Effect effect = new Effect("Deal 6 damage.");
                        Card c = new Card("Strike", CardType.Ironclad, "Deal 6 damage.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Effect effect = new Effect("Gain 5 block.");
                        Card c = new Card("Defend", CardType.Ironclad, "Gain 5 block.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    Deck.Add(new Card("Bash", CardType.Ironclad, "Deal 8 Damage. Apply 2 Vulnerable", Rarity.Starter, new Effect("Deal  8 Damage. Apply 2 Vulnerable"), 2));
                    return Deck;
                case CharacterType.Silent:
                    Deck = new List<Card>();
                    for (int i = 0; i < 5; i++)
                    {
                        Effect effect = new Effect("Deal 6 damage.");
                        Card c = new Card("Strike", CardType.Silent, "Deal 6 damage.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Effect effect = new Effect("Gain 5 block.");
                        Card c = new Card("Defend", CardType.Silent, "Gain 5 block.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    List<Card> cardsToAdd = new List<Card>();
                    cardsToAdd.Add(new Card("Survivor", CardType.Silent, "Gain 8 block. Discard 1 card.", Rarity.Starter, new Effect("Gain 8 block. Discard 1 card."), 1));
                    cardsToAdd.Add(new Card("Neutralize", CardType.Silent, "Deal 3 Damage. Apply 1 Weak", Rarity.Starter, new Effect("Deal 3 Damage. Apply 1 Weak"), 0));
                    Deck.AddRange(cardsToAdd);
                   
                    return Deck;
                case CharacterType.Defect:
                    Deck = new List<Card>();
                    for (int i = 0; i < 4; i++)
                    {
                        Effect effect = new Effect("Deal 6 damage.");
                        Card c = new Card("Strike", CardType.Defect, "Deal 6 damage.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Effect effect = new Effect("Gain 5 block.");
                        Card c = new Card("Defend", CardType.Defect, "Gain 5 block.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    Deck.Add(new Card("Zap", CardType.Defect, "Channel 1 Lightning.", Rarity.Starter, new Effect("Channel 1 Lightning."), 1));
                    Deck.Add(new Card("Dualcast", CardType.Defect, "Evoke your next Orb twice.", Rarity.Starter, new Effect("Evoke your next Orb twice."), 0));

                    return Deck;
                case CharacterType.Watcher:
                    Deck = new List<Card>();
                    for (int i = 0; i < 4; i++)
                    {
                        Effect effect = new Effect("Deal 6 damage.");
                        Card c = new Card("Strike", CardType.Watcher, "Deal 6 damage.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Effect effect = new Effect("Gain 5 block.");
                        Card c = new Card("Defend", CardType.Watcher, "Gain 5 block.", Rarity.Starter, effect, 1);
                        Deck.Add(c);
                    }
                    Deck.Add(new Card("Erruption", CardType.Watcher, "Deal 9 Damage. Enter Wrath.", Rarity.Starter, new Effect("Deal 9 Damage. Enter Wrath."), 2));
                    Deck.Add(new Card("Vigilance", CardType.Watcher, "Gain 8 Block. Enter Calm.", Rarity.Starter, new Effect("Gain 8 Block. Enter Calm."), 2));

                    return Deck;
            }

            return null;
        }


        private Relic GiveRelic(CharacterType charType)
        {
            Relic relic;
            Effect effect;
            switch (charType)
            {
                case CharacterType.Ironclad:
                    effect = new Effect("Heals 6 HP at the end of combat.");
                    relic =  new Relic("Burnig Blood", "Heals 6 HP at the end of combat.", effect);
                    return relic;
                case CharacterType.Silent:
                    effect = new Effect("Draws 2 additional cards at the start of each combat.");
                    relic = new Relic("Ring of the Snake", "It draws 2 additional cards at the start of each combat.", effect);
                    return relic;
                case CharacterType.Defect:
                    effect = new Effect("Channel 1 Lightning at the start of each combat.");
                    relic = new Relic("Cracked Core", "Channel 1 Lightning at the start of each combat.", effect);
                    return relic;
                case CharacterType.Watcher:
                    effect = new Effect("Adds a Miracle to your hand at the start of each combat.");
                    relic = new Relic("Pure Water", "Adds a Miracle to your hand at the start of each combat.", effect);
                    return relic;
            }

            return null;
        }


        public string ToString()
        {
            StringBuilder sb = new StringBuilder("Character properties: \n" + " Starting Relic:" + this.StartingRelic.ToString());
            if(this.Relics != null) {
                foreach (var relic in this.Relics)
                {
                    sb.Append(relic.ToString());
                }
            }
            
            foreach (var card in this.Deck)
            {
                sb.Append(card.ToString());
            }

            sb.Append("\n Gold: " + this.Gold + " \n Health: " + this.Health + " \n Energy: " + this.Energy);

            return sb.ToString();
        }
    }
}
