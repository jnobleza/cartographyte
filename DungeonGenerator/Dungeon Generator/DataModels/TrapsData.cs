using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace Dungeon_Generator.DataModels {
    class TrapsData : GridData {

        private float size, offset;

        public TrapsData(int xPos, int yPos, float size) : base(xPos, yPos, 1.0f, 102.0f / 255.0f, 0.0f) {

            this.offset = size * 0.2f;
            this.size = size * 0.8f;
        }

        public TrapsData(int xPos, int yPos)
            : this(xPos, yPos, 1.0f) {
        }

        protected override void _render(OpenGL gl) {
            gl.Vertex(xCoord + offset, yCoord + offset);
            gl.Vertex(xCoord + size, yCoord + offset);
            gl.Vertex(xCoord + size, yCoord + size);
            gl.Vertex(xCoord + offset, yCoord + size);
        }
    }
}
