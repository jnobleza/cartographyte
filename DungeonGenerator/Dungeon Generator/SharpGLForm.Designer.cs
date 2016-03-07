namespace Dungeon_Generator {
    partial class SharpGLForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.openGLControl = new SharpGL.OpenGLControl();
            this.resultsInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generateButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newTreasureLabel = new System.Windows.Forms.Label();
            this.newTrasuresInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.specificsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomsBox = new System.Windows.Forms.ComboBox();
            this.trasureLabel = new System.Windows.Forms.Label();
            this.treasureBox = new System.Windows.Forms.ComboBox();
            this.tunerLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.difficultyBox = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.monstersLabel = new System.Windows.Forms.Label();
            this.trapsLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.monstersBox = new System.Windows.Forms.ComboBox();
            this.trapBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(209, 0);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(674, 434);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // resultsInput
            // 
            this.resultsInput.Location = new System.Drawing.Point(209, 440);
            this.resultsInput.Multiline = true;
            this.resultsInput.Name = "resultsInput";
            this.resultsInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsInput.Size = new System.Drawing.Size(674, 129);
            this.resultsInput.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.generateButton);
            this.panel3.Controls.Add(this.acceptButton);
            this.panel3.Controls.Add(this.rejectButton);
            this.panel3.Location = new System.Drawing.Point(3, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 79);
            this.panel3.TabIndex = 15;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(10, 16);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(101, 53);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(117, 16);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(117, 46);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(75, 23);
            this.rejectButton.TabIndex = 1;
            this.rejectButton.Text = "Clear";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.newTreasureLabel);
            this.panel2.Controls.Add(this.newTrasuresInput);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.specificsLabel);
            this.panel2.Location = new System.Drawing.Point(3, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 173);
            this.panel2.TabIndex = 14;
            // 
            // newTreasureLabel
            // 
            this.newTreasureLabel.AutoSize = true;
            this.newTreasureLabel.Location = new System.Drawing.Point(27, 131);
            this.newTreasureLabel.Name = "newTreasureLabel";
            this.newTreasureLabel.Size = new System.Drawing.Size(59, 13);
            this.newTreasureLabel.TabIndex = 8;
            this.newTreasureLabel.Text = "Input New:";
            // 
            // newTrasuresInput
            // 
            this.newTrasuresInput.Location = new System.Drawing.Point(30, 147);
            this.newTrasuresInput.Name = "newTrasuresInput";
            this.newTrasuresInput.Size = new System.Drawing.Size(121, 20);
            this.newTrasuresInput.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Treasures";
            // 
            // specificsLabel
            // 
            this.specificsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificsLabel.Location = new System.Drawing.Point(25, 0);
            this.specificsLabel.Name = "specificsLabel";
            this.specificsLabel.Size = new System.Drawing.Size(126, 26);
            this.specificsLabel.TabIndex = 5;
            this.specificsLabel.Text = "Specifics";
            this.specificsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.roomsBox);
            this.panel1.Controls.Add(this.trasureLabel);
            this.panel1.Controls.Add(this.treasureBox);
            this.panel1.Controls.Add(this.tunerLabel);
            this.panel1.Controls.Add(this.difficultyLabel);
            this.panel1.Controls.Add(this.difficultyBox);
            this.panel1.Controls.Add(this.levelLabel);
            this.panel1.Controls.Add(this.levelBox);
            this.panel1.Controls.Add(this.monstersLabel);
            this.panel1.Controls.Add(this.trapsLabel);
            this.panel1.Controls.Add(this.roomLabel);
            this.panel1.Controls.Add(this.monstersBox);
            this.panel1.Controls.Add(this.trapBox);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 309);
            this.panel1.TabIndex = 13;
            // 
            // roomsBox
            // 
            this.roomsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomsBox.FormattingEnabled = true;
            this.roomsBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.roomsBox.Location = new System.Drawing.Point(30, 56);
            this.roomsBox.Name = "roomsBox";
            this.roomsBox.Size = new System.Drawing.Size(121, 21);
            this.roomsBox.TabIndex = 12;
            // 
            // trasureLabel
            // 
            this.trasureLabel.AutoSize = true;
            this.trasureLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.trasureLabel.Location = new System.Drawing.Point(27, 267);
            this.trasureLabel.Name = "trasureLabel";
            this.trasureLabel.Size = new System.Drawing.Size(49, 13);
            this.trasureLabel.TabIndex = 11;
            this.trasureLabel.Text = "Treasure";
            // 
            // treasureBox
            // 
            this.treasureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treasureBox.FormattingEnabled = true;
            this.treasureBox.Items.AddRange(new object[] {
            "None",
            "Few",
            "Moderate",
            "Many"});
            this.treasureBox.Location = new System.Drawing.Point(30, 283);
            this.treasureBox.Name = "treasureBox";
            this.treasureBox.Size = new System.Drawing.Size(121, 21);
            this.treasureBox.TabIndex = 10;
            // 
            // tunerLabel
            // 
            this.tunerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunerLabel.Location = new System.Drawing.Point(25, 0);
            this.tunerLabel.Name = "tunerLabel";
            this.tunerLabel.Size = new System.Drawing.Size(126, 26);
            this.tunerLabel.TabIndex = 5;
            this.tunerLabel.Text = "Tuners";
            this.tunerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(27, 221);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.difficultyLabel.TabIndex = 9;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // difficultyBox
            // 
            this.difficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Impossible"});
            this.difficultyBox.Location = new System.Drawing.Point(30, 237);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(121, 21);
            this.difficultyBox.TabIndex = 8;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(27, 175);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 7;
            this.levelLabel.Text = "Level";
            // 
            // levelBox
            // 
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.levelBox.Location = new System.Drawing.Point(30, 191);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(121, 21);
            this.levelBox.TabIndex = 6;
            // 
            // monstersLabel
            // 
            this.monstersLabel.AutoSize = true;
            this.monstersLabel.Location = new System.Drawing.Point(27, 129);
            this.monstersLabel.Name = "monstersLabel";
            this.monstersLabel.Size = new System.Drawing.Size(50, 13);
            this.monstersLabel.TabIndex = 5;
            this.monstersLabel.Text = "Monsters";
            // 
            // trapsLabel
            // 
            this.trapsLabel.AutoSize = true;
            this.trapsLabel.Location = new System.Drawing.Point(27, 80);
            this.trapsLabel.Name = "trapsLabel";
            this.trapsLabel.Size = new System.Drawing.Size(34, 13);
            this.trapsLabel.TabIndex = 4;
            this.trapsLabel.Text = "Traps";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(27, 35);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(92, 13);
            this.roomLabel.TabIndex = 3;
            this.roomLabel.Text = "Number of Rooms";
            // 
            // monstersBox
            // 
            this.monstersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monstersBox.FormattingEnabled = true;
            this.monstersBox.Items.AddRange(new object[] {
            "None",
            "Few",
            "Moderate",
            "Many"});
            this.monstersBox.Location = new System.Drawing.Point(30, 145);
            this.monstersBox.Name = "monstersBox";
            this.monstersBox.Size = new System.Drawing.Size(121, 21);
            this.monstersBox.TabIndex = 2;
            // 
            // trapBox
            // 
            this.trapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trapBox.FormattingEnabled = true;
            this.trapBox.Items.AddRange(new object[] {
            "None",
            "Few",
            "Moderate",
            "Many"});
            this.trapBox.Location = new System.Drawing.Point(30, 96);
            this.trapBox.Name = "trapBox";
            this.trapBox.Size = new System.Drawing.Size(121, 21);
            this.trapBox.TabIndex = 1;
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 572);
            this.Controls.Add(this.resultsInput);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openGLControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpGLForm";
            this.Text = "SharpGL Form";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label newTreasureLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label specificsLabel;
        private System.Windows.Forms.Label trasureLabel;
        private System.Windows.Forms.Label tunerLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label monstersLabel;
        private System.Windows.Forms.Label trapsLabel;
        private System.Windows.Forms.Label roomLabel;

        private System.Windows.Forms.ComboBox monstersBox;
        private System.Windows.Forms.ComboBox trapBox;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.ComboBox difficultyBox;
        private System.Windows.Forms.ComboBox treasureBox;
        private System.Windows.Forms.TextBox newTrasuresInput;
        private System.Windows.Forms.TextBox resultsInput;

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.ComboBox roomsBox;
    }
}

