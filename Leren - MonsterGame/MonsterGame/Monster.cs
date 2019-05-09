using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster
    {
        private int hitpoints = 100;
    }

    public Monster(int initialHitPoints)
    {
        this.hitPoints = initialHitPoints;
    }

    public void LooseHitPoints(int damage)
    {
        this.hitPoints = this.hitPoints - damage;
    }
}
