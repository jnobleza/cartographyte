using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon_Generator.DataModels {

    enum TrapMode {
        None = 0,
        Few = 1,
        Moderate = 2,
        Many = 3,
    }

    enum MonsterMode {
        None = 0,
        Few = 1,
        Moderate = 2,
        Many = 3,
    }

    enum DifficultyLevel {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Impossible = 3,
    }

    enum TreasureMode {
        None = 0,
        Few = 1,
        Moderate = 2,
        Many = 3,
    }

    partial class GenerationData {
        public int level { get; private set; }
        public int numberOfRooms { get; private set; }
        public TrapMode trapMode { get; private set; }
        public MonsterMode monsterMode { get; private set; }
        public DifficultyLevel difficulty { get; private set; }
        public TreasureMode treasureMode { get; private set; }
        public int gridSquares{get; private set;}

        private static GenerationData instance;

        private GenerationData() {
            level = numberOfRooms = 1;
            trapMode = TrapMode.None;
            monsterMode = MonsterMode.None;
            difficulty = DifficultyLevel.Easy;
            treasureMode = TreasureMode.None;
            gridSquares = 400;
        }

        // Method to be used by the view controller to pass in the data.
        public void setupData(int level, int rooms, TrapMode traps,
            MonsterMode monsters, DifficultyLevel difficulty, TreasureMode treasure) {
                
                // Setup the data with the variables passed in.
                this.level = level;
                numberOfRooms = rooms;
                trapMode = traps;
                monsterMode = monsters;
                this.difficulty = difficulty;
                treasureMode = treasure;
        }

        // Singleton Method to get the instance
        public static GenerationData getInstance() {
            if (instance == null) instance = new GenerationData();
            return instance;
        }
    }
}
