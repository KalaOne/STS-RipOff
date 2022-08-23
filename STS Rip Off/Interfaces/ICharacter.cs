using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static STS_Rip_Off.Character.Character;

namespace STS_Rip_Off.Interfaces
{
    public interface ICharacter
    {
        public CharacterType CharType { get; set; }
        //public Relic StartingRelic { get; set; }
        //public Relic[] Relics { get; set; }
        //public Card Cards{ get; set; }
        public int Gold { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        //public Potion[] Potions { get; set; }

    }
}
