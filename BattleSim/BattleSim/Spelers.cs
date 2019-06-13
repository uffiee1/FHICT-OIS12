using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    class Spelers
    {
        public int HitPoints = 100;
        public enum Type
        {
            Ranger,
            Warrior
        }

        public Type SpelerType {get; set; }
        public Spelers(int hitpoints, Type type)
        {
            HitPoints = hitpoints;
            SpelerType = type;
        }
        
        public void ApplyDamage(Spelers speler, int damage)
        {
            speler.HitPoints = speler.HitPoints - damage;
        }

    }
}


