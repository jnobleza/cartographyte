using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;
using Dungeon_Generator.GenerationModels;

namespace Dungeon_Generator.DataModels {
    class LevelData {

        private static LevelData instance;
        private List<RoomData> rooms;

        // Constructor set to be private for Singleton
        private LevelData() {
            rooms = new List<RoomData>();
        }

        // Method to accept the Generated Data and parse.
        public void setupLevelWithData(List<Room> roomList) {
            rooms.Clear();

            // TODO: Write Method once paraser is defined.
            foreach (Room room in roomList) {
                RoomData newData = new RoomData();
                newData.setupRoomData(room);
                rooms.Add(newData);


            }
        }

        // Method to test the Rendering
        public void setupWithDummyData() {
            // TODO: Dummy Data
            rooms.Add(RoomData.roomWithDummyData(1));
        }

        // Method to render the Level Data
        public void render(OpenGL gl) {
            // Loop Through the rooms and render them
            foreach (RoomData room in rooms) {
                room.render(gl);
            }
        }

        // Singleton Method
        public static LevelData getInstance() {
            if (instance == null) {
                instance = new LevelData();
            }

            return instance;
        }
    }
}
