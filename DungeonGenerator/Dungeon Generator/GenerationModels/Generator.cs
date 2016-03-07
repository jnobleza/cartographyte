using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dungeon_Generator.DataModels;

namespace Dungeon_Generator.GenerationModels {
    class Generator {

        MonsterGenList monsterGenerator;
        public List<Room> roomList;
        Random rnd = new Random();
        Random rndTwo = new Random();
        int availableSquares, weightedMin, weightedMax;

        private static Generator instance;

        private Generator() {
            roomList = new List<Room>();
            monsterGenerator = new MonsterGenList();

            GenerationData data = GenerationData.getInstance();
            availableSquares = data.gridSquares;

            weightedMin = 4;
            weightedMax = availableSquares/2;
        }

        public static Generator getInstance() {
            if (instance == null) {
                instance = new Generator();
            }

            return instance;
        }

        #region Weighting Methods

        private int smallestSize() {
            int smallest = roomList[0].width * roomList[0].height;

            foreach (Room room in roomList) {
                smallest = (smallest > room.width * room.height) ? room.width * room.height : smallest;
            }

            return smallest;
        }

        private int largestSize() {
            int largest = roomList[0].width * roomList[0].height;

            foreach (Room room in roomList) {
                largest = (largest < room.width * room.height) ? room.width * room.height : largest;
            }

            return largest;
        }

        // Method to accept the rooms, used to build the weighted averages
        public void acceptRooms() {
            weightedMin = smallestSize();
            weightedMax = largestSize();
        }

        public void clearWeights() {
            weightedMin = 4;
            weightedMax = GenerationData.getInstance().gridSquares / 2;
        }

        #endregion

        #region Generation Methods

        private bool checkIfRoomCollides(int x, int y, int width, int height) {
            foreach (Room room in roomList) {
                if (!(x > room.posX + room.width || x + width < room.posX || y > room.posY + room.height || y + height < room.posY)) {
                    return true;
                }
            }

            return false;
        }

        private bool fallsOffEdge(int x, int y, int width, int height) {
            return (x < 0 || x + width > 20 || y < 0 || y + height > 20);
        }

        private void removeLargestRoom() {
            Room largeRoom = roomList[0];
            foreach (Room room in roomList) {
                if (largeRoom.width * largeRoom.height < room.width * room.height) {
                    largeRoom = room;
                }
            }

            availableSquares += (largeRoom.width * largeRoom.height);
            roomList.Remove(largeRoom);
        }

        private void addRoom(int x, int y, int width, int height) {
            roomList.Add(new Room(width, height, x, y));
        }

        private void GenerateMonsters() {
            GenerationData data = GenerationData.getInstance();
            int monsterCount = 0, monsterLikelyness = 0;
            monsterGenerator = new MonsterGenList();

            // Determine what monster mode we are using and set the variables to act as such
            switch (data.monsterMode) {
                case MonsterMode.None:
                    monsterCount = monsterLikelyness = 0;
                    break;
                case MonsterMode.Few:
                    monsterCount = 5;
                    monsterLikelyness = 21;
                    break;
                case MonsterMode.Moderate:
                    monsterCount = 10;
                    monsterLikelyness = 31;
                    break;
                case MonsterMode.Many:
                    monsterCount = 20;
                    monsterLikelyness = 61;
                    break;
            }

            //check & set level
            monsterGenerator.SetMonsterStats(data.level, data.level + 5);

            for (int i = 0; i < roomList.Count; i++) {
                // Needs randomized x coord?
                monsterGenerator.SetMonsterRoomDimensions(roomList[i].posX, roomList[i].posY, roomList[i].width, roomList[i].height);

                //set monsters
                //everything is minions for now
                for (int j = 0; j < monsterCount; j++) {
                    int currRand = rndTwo.Next(1, 101);
                    if (currRand < monsterLikelyness) {
                        roomList[i].addToMonsList(monsterGenerator.GenerateMinion());
                    }
                }

            }
        }

        private void GenerateRoom() {
            bool roomAddedSuccessfully = false;
            int roomsAvailableSquares = availableSquares;

            // While we haven't got a successful room
            while (!roomAddedSuccessfully) {
                // Grab the size of the room we want, make sure its even
                int roomSize = rnd.Next(weightedMin, Math.Min(100, weightedMax));
                roomSize = (roomSize % 2 == 0) ? roomSize : roomSize - 1;

                // Generate the Width of the room
                List<int> factors = GetFactors(roomSize).ToList<int>();

                if (factors.Count <= 4) return;

                List<int> trimmedFactors = new List<int>();
                foreach (int factor in factors) {
                    if (factor <= 20 && roomSize / factor <= 20) {
                        trimmedFactors.Add(factor);
                    }
                }

                if (trimmedFactors.Count == 0) return;

                factors = trimmedFactors;

                // Use the Width to get the height
                int height = factors[rndTwo.Next(0, factors.Count)];
                int width = roomSize / height;

                int x = 10, y = 10;

                // Adjust x and y
                if (x + width > 20) {
                    x = 20 - width;
                }

                if (y + height > 20) {
                    y = 20 - height;
                }

                while (checkIfRoomCollides(x, y, width, height)) {
                    x += nudge();
                    y += nudge();

                    // If we fall off the edge, remove the largest room and set our available size to be smaller
                    if (fallsOffEdge(x, y, width, height)) {
                        removeLargestRoom();
                        return;
                    }

                }

                if (!fallsOffEdge(x, y, width, height)) {
                    // Add the Room
                    addRoom(x, y, width, height);
                    availableSquares -= roomSize;
                    roomAddedSuccessfully = true;
                }

            }
        }

        private int nudge() {
            return rnd.Next(-5, 5);
        }

        private static IEnumerable<int> GetFactors(int num) {
            //Given anumber (num), return a list of all of it's 
            //factors.
            //We're going to grab this from both ends, since a given factor
            //divided by our number will yield a second factor. for example, 
            //the factors of 6 can be expressed as:
            // Given our first factor (1), and dividing 1 / 6, we get a second factor (6).
            // Given our third factor (2), and dividing 2 / 6, we get a fourth factor (3).
            for (int factor = 1; factor * factor <= num; factor++) {
                if (num % factor == 0) {
                    yield return factor;
                    if (factor * factor != num)
                        yield return num / factor;
                }
            }
        }

        public void GenerateRooms() {
            roomList.Clear();
            GenerationData data = GenerationData.getInstance();
            availableSquares = data.gridSquares;

            //check # rooms
            //go through each and make a new room
            while (roomList.Count < data.numberOfRooms) {
                GenerateRoom();
            }

            // Add the Monsters to the Room
            GenerateMonsters();
        }

        #endregion

    }
}
