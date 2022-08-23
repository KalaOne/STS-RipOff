using STS_Rip_Off.Interfaces;
using STS_Rip_Off.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Relics
{
    public class Relic : IRelic
    {
        public string RelicName { get; set; }
        public string Description { get; set; }
        public Effect Effect { get; set; }

        public Relic() {}

        public Relic(string name, string description, Effect eff)
        {
            this.RelicName = name;
            this.Description = description;
            this.Effect = eff;
        }

        public override string ToString()
        {
            return "\n  Relic: \n   Name: " + this.RelicName + " \n   Description: " + this.Description + " \n   Effect: " + this.Effect; 
        }
    }
}
