using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Generator.GenerationModels
{
    class Room
    {

        
        // Height and width of each room.
        public int width, height;

        // Middle of the two, width/2 and height/2
        public int midW, midH;

        // Position of x and y in worldspace, uses midW and midH.
        public int posX, posY;
        

        // Number of monsters, treasures, and traps in the room.
        public int monsterCount, treasureCount, trapCount;

        public List<Monster> monsterList;
        public List<Treasure> treasureList;
        public List<Trap> trapList;

        public Room(int w, int h, int posX, int posY)
        {
            setSize(w, h);
            setPos(posX, posY);

            monsterList = new List<Monster>();
            treasureList = new List<Treasure>();
            trapList = new List<Trap>();
        }

        public void addToMonsList(Monster m)
        {
            monsterList.Add(m);
        }

        // Sets dimensions of room.
        public void setSize(int w, int h)
        {
            this.width = w;
            this.height = h;
            setMid();
        }

        // Store middle position of the room.
        private void setMid()
        {
            this.midW = width / 2;
            this.midH = height / 2;
        }

        public void setPos(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public int returnPosX() {

            return posX;
        }

        public int returnPosY()
        {
            return posY;
        }

        public int returnWidth()
        {
            return this.width;
        }

        public int returnHeight()
        {
            return this.height;
        }

        public int returnMidW()
        {
            return this.midW;
        }

        public int returnMidH()
        {
            return this.midH;
        }

    }
}
