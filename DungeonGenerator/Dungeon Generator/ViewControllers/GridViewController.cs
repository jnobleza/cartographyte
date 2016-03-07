using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL;
using Dungeon_Generator.DataModels;

namespace Dungeon_Generator.ViewControllers {

    /// <summary>
    /// GridViewController
    /// Used to render the grid and various information on the board
    /// </summary>
    class GridViewController {

        private int width = 20, height = 20;
        private LevelData data;

        public GridViewController() {

            data = LevelData.getInstance();
            data.setupWithDummyData();
        }

        // Public Method to render the grid with the given open gl context.
        // Assumes openGL has been refresh properly.
        public void renderWithContext(OpenGL gl) {

            // Render Data and Grid
            renderDataWithContext(gl);
            renderGrid(gl);
        }

        // Renders the Grid
        private void renderGrid(OpenGL gl) {

            gl.Color(0.0f, 0.0f, 0.0f);

            for (int x = 0; x < width + 1; x++) {
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(x, 0.0f);
                gl.Vertex(x, height);
                gl.End();
            }

            for (int y = 0; y < height + 1; y++) {
                gl.Begin(OpenGL.GL_LINE_LOOP);
                gl.Vertex(0.0f, y);
                gl.Vertex(width, y);
                gl.End();
            }
        }

        // Renders the Data provided
        private void renderDataWithContext(OpenGL gl) {

            data.render(gl);
        }

    }
}
