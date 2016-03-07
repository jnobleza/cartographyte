using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Generator.GenerationModels
{
    class Monster
    {
        String name, type, desc, powers;

        int level, x, y, hp;

        public Monster(String n, int l, String t, String d, String p, int x, int y, int h)
        {
            this.name = n;
            this.level = l;
            this.desc = d;
            this.powers = p;
            this.hp = h;
            this.x = x;
            this.y = y;

            // Minion, Regular, Mid-Boss, Boss
            this.type = t;
        }

        // Returns for the various variables.
        public String ReturnName()
        {
            return this.name;
        }

        public String ReturnType()
        {
            return this.type;
        }

        public String ReturnDesc()
        {
            return this.desc;
        }

        public String ReturnPowers()
        {
            return this.desc;
        }

        public int ReturnLevel()
        {
            return this.level;
        }

        public int ReturnXCoord()
        {
            return this.x;
        }

        public int ReturnYCoord()
        {
            return this.y;
        }
    }
}
