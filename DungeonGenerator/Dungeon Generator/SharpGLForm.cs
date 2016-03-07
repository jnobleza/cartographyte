using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using Dungeon_Generator.ViewControllers;
using Dungeon_Generator.DataModels;
using Dungeon_Generator.GenerationModels;

namespace Dungeon_Generator {
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class SharpGLForm : Form {

        private GridViewController gridViewController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpGLForm"/> class.
        /// </summary>
        public SharpGLForm() {
            InitializeComponent();
            gridViewController = new GridViewController();
        }

        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RenderEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e) {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            gl.LoadIdentity();

            gl.Translate(2.0f, 0.2f, 0.0f);
            gridViewController.renderWithContext(gl);
        }

        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e) {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            gl.ClearColor(0.5f, 0.5f, 0.5f, 0);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e) {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            gl.Ortho2D(0.0f, Width/30.0f, Height/30.0f, 0.0f);

            //  Create a perspective transformation.
            //gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);

            //  Use the 'look at' helper function to position and aim the camera.
            //gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        #region Form Buttons

        private void acceptButton_Click(object sender, EventArgs e) {
            Generator generator = Generator.getInstance();
            generator.acceptRooms();
        }

        private void rejectButton_Click(object sender, EventArgs e) {
            Generator generator = Generator.getInstance();
            generator.clearWeights();
        }

        // Generation Button, does the magic
        private void generateButton_Click(object sender, EventArgs e) {
            // Get the data instance
            GenerationData data = GenerationData.getInstance();
            
            // Pass in the data
            data.setupData(levelBox.SelectedIndex + 1, roomsBox.SelectedIndex + 1,
                (TrapMode)trapBox.SelectedIndex, (MonsterMode)monstersBox.SelectedIndex,
                (DifficultyLevel)difficultyBox.SelectedIndex, (TreasureMode)treasureBox.SelectedIndex);

            // TODO: Run the Generation
            Generator generator = Generator.getInstance();
            generator.GenerateRooms();

            LevelData.getInstance().setupLevelWithData(generator.roomList);
        }

        #endregion

        

    }
}
