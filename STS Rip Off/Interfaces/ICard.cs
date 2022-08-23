
using STS_Rip_Off.Cards;
using STS_Rip_Off.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Interfaces
{
    public enum CardType
    {
        Ironclad,
        Silent,
        Defect,
        Watcher,
        Colourless,
        Status,
        Curse
    }

    public enum Rarity
    {
        Starter,
        Common,
        Uncommon,
        Rare,
    }
   
    public interface ICard
    {
        public string Name { get; set; }
        public CardType Type{ get; set; }
        public string Description { get; set; }
        public Rarity Rarity { get; set; }
        public Effect Effect { get; set;}
        public Effect EffectPlus { get; set; }
        public int Cost { get; set; }

    }
}
