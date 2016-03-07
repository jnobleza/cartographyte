using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;
using Dungeon_Generator.GenerationModels;

namespace Dungeon_Generator.DataModels {
    class RoomData {
        private List<RoomTileData> tileData;
        private List<TrapsData> trapData;
        private List<TreasureData> treasureData;
        private List<MonsterData> monsterData;

        public RoomData() {
            tileData = new List<RoomTileData>();
            trapData = new List<TrapsData>();
            treasureData = new List<TreasureData>();
            monsterData = new List<MonsterData>();
        }

        private void addTile(int xPos, int yPos, int size) {
            tileData.Add(new RoomTileData(xPos, yPos, size));
        }

        private void addTrap(int xPos, int yPos) {
            trapData.Add(new TrapsData(xPos, yPos));
        }

        private void addMonster(int xPos, int yPos) {
            monsterData.Add(new MonsterData(xPos, yPos));
        }

        private void addTreasure(int xPos, int yPos) {
            treasureData.Add(new TreasureData(xPos, yPos));
        }

        // Method to setup the Room's data
        public void setupRoomData(Room room) {
            // TODO: write method when paraser is defined
            for (int iPos = 0; iPos < room.width; iPos++) {
                for (int jPos = 0; jPos < room.height; jPos++) {
                    addTile(room.posX + iPos, room.posY + jPos, 1);
                }
            }

            foreach (Monster monster in room.monsterList) {
                addMonster(monster.ReturnXCoord(), monster.ReturnYCoord());
            }

        }

        // Method to setup the Room's data with dummy data
        public static RoomData roomWithDummyData(int index) {
            RoomData room = new RoomData();

            switch (index) {
                case 1:
                    room.dummyRoom1();
                    break;
            }

            return room;
        }

        private void dummyRoom1() {
            addTile(10, 10, 3);
            addMonster(12, 12);
            addTrap(11, 10);
            addTreasure(10, 10);
        }

        public void render(OpenGL gl) {
            // Render Each Tile
            foreach (RoomTileData tile in tileData) {
                tile.render(gl);
            }

            // Render Each Trap
            foreach (TrapsData trap in trapData) {
                trap.render(gl);
            }

            // Render Each Monster
            foreach (MonsterData monster in monsterData) {
                monster.render(gl);
            }

            // Render Each Treasure
            foreach (TreasureData treasure in treasureData) {
                treasure.render(gl);
            }
        }

    }
}