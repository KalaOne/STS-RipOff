using STS_Rip_Off.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Misc
{
    public class Effect : IEffect
    {
        public string Description { get; set; }
        public Effect(string eff)
        {
            this.Description = eff;
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
