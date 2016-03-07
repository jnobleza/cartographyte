using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Generator.GenerationModels
{
    // Generator calls these generic Monster types.
    class MonsterGenList
    {
        int level, roomWidth, roomHeight, hp, hpMidBoss, hpBoss, xPos, yPos;
        Random rnd = new Random();

        public void SetMonsterStats(int l, int h)
        {
            this.level = l;
            this.hp = h;
            this.hpMidBoss = h * 2 + 10;
            this.hpBoss = h * 4 + 10;
        }

        public void SetMonsterRoomDimensions(int x, int y, int width, int height)
        {
            this.xPos = x;
            this.yPos = y;
            this.roomWidth = width;
            this.roomHeight = height;
        }

        public Monster GenerateMinion()
        {
            return new Monster("Minion", level, "Minion", "", "Attack - Melee 1", rnd.Next(xPos, xPos + roomWidth), rnd.Next(yPos, yPos + roomHeight), 1);
        }

        public Monster GenerateRangedMinion()
        {
            return new Monster("Minion - Ranged", level, "Minion", "Cannot attack the adjacent spaces.", "Attack - Range 7", rnd.Next(xPos, xPos + roomWidth), rnd.Next(yPos, yPos + roomHeight), 1);
        }

        public Monster GenerateBombMinion()
        {
            return new Monster("Minion - Bomb", level, "Minion", "Dies if it uses its attack once.", "Attack - Explode Burst 3", rnd.Next(xPos, xPos + roomWidth), rnd.Next(yPos, yPos + roomHeight), 1);
        }

        public Monster GenerateRegMons()
        {
            return new Monster("Regular Monster", level, "Regular", "", "Attack - Explode Burst 3", rnd.Next(xPos, xPos + roomWidth), rnd.Next(yPos, yPos + roomHeight), hp);
        }

        public Monster GenerateMidBoss()
        {
            return new Monster("Mid Boss", level + 1, "Mid Boss", "", "Attack - Melee 1, Attack - Range 7", rnd.Next(xPos, xPos + roomWidth), rnd.Next(yPos, yPos + roomHeight), hp);
        }

        public Monster GenerateBoss()
        {
            return new Monster("Boss", level + 2, "Boss", "", "Attack - Melee 1, Attack - Range 7, Attack - Special Burst 3", rnd.Next(xPos, xPos + roomWidth), rnd.Next(yPos, yPos + roomHeight), hp);
        }
    }
}
