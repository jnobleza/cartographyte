using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace Dungeon_Generator.DataModels {
    public class RoomTileData : GridData {

        private float size;

        public RoomTileData(int xPos, int yPos, float size) : base(xPos, yPos, 0.9f) {
            this.size = size;
        }

        public RoomTileData(int xPos, int yPos) : this(xPos, yPos, 1.0f) {
        }

        protected override void _render(OpenGL gl) {
            gl.Vertex(xCoord, yCoord);
            gl.Vertex(xCoord + size, yCoord);
            gl.Vertex(xCoord + size, yCoord + size);
            gl.Vertex(xCoord, yCoord + size);
        }
    }
}
