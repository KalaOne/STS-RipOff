using STS_Rip_Off.Cards;
using STS_Rip_Off.Relics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Misc
{
    public class Reward
    {
        public List<Card> CardRewardList { get; set; }
        public int Gold { get; set; }
        public Potion? Potion { get; set; }
        public Relic? Relic { get; set; }

       
    }
}
