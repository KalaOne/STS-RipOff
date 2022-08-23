using STS_Rip_Off.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Interfaces
{
    public interface IRelic
    {
        public string RelicName { get; set; }
        public string Description { get; set; }
        public Effect Effect { get; set; }
    }
}
