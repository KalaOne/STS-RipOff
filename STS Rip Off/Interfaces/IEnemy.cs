
using STS_Rip_Off.Misc;

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
        public int HealthLowValue { get; set; }
        public int HealthHighValue { get; set; }
    }

    public interface IBattleBehaviour
    {
        public Intent? Intent { get; set; } // next action to take
        public IEffect? Effect { get; set; } //effect of the intended action

    }
}
