﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Hero
    {

        public Hero()
        {
        }

        public void Attack(Monster monster, int damage)
        {
            monster.LooseHitPoints(damage);
        }
    }
}
