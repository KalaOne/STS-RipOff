using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS_Rip_Off.Interfaces
{
    public enum EnemyType
    {
        Monster,
        Elite,
        Boss
    }

    public interface IEnemy
    {
        public string Name { get; set; }
        public EnemyType Type { get; set; }
       // public Skill? PassiveSkill { get; set; }
        public int Health { get; set; }
       // public Intent Intent { get; set; }

    }
}
