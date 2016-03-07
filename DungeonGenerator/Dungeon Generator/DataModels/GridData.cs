using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;

namespace Dungeon_Generator.DataModels {
    public abstract class GridData {
        protected int xCoord, yCoord;
        protected float colorR, colorG, colorB;

        public GridData(int xPos, int yPos, float colorR, float colorG, float colorB) {
            this.xCoord = xPos;
            this.yCoord = yPos;
            this.colorR = colorR;
            this.colorG = colorG;
            this.colorB = colorB;
        }

        public GridData(int xPos, int yPos, float color) : this(xPos, yPos, color, color, color) { }
        public GridData(int xPos, int yPos) : this(xPos, yPos, 0.0f) { }
        public GridData() : this(0, 0) { }

        public void render(OpenGL gl) {
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(colorR, colorG, colorB);
            _render(gl);
            gl.End();
        }

        protected abstract void _render(OpenGL gl);
    }
}
