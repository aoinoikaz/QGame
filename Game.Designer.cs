
namespace DTomlinQGame
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numMoves_TextBox = new System.Windows.Forms.TextBox();
            this.remainingBoxes_TextBox = new System.Windows.Forms.TextBox();
            this.numMoves_Label = new System.Windows.Forms.Label();
            this.remainingBoxes_Label = new System.Windows.Forms.Label();
            this.gamePadLeft_Btn = new System.Windows.Forms.Button();
            this.gamePadDown_Btn = new System.Windows.Forms.Button();
            this.gamePadRight_Btn = new System.Windows.Forms.Button();
            this.gamePadUp_Btn = new System.Windows.Forms.Button();
            this.toolboxImages = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.LoadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // numMoves_TextBox
            // 
            this.numMoves_TextBox.Location = new System.Drawing.Point(825, 121);
            this.numMoves_TextBox.Name = "numMoves_TextBox";
            this.numMoves_TextBox.ReadOnly = true;
            this.numMoves_TextBox.Size = new System.Drawing.Size(256, 20);
            this.numMoves_TextBox.TabIndex = 3;
            // 
            // remainingBoxes_TextBox
            // 
            this.remainingBoxes_TextBox.Location = new System.Drawing.Point(825, 210);
            this.remainingBoxes_TextBox.Name = "remainingBoxes_TextBox";
            this.remainingBoxes_TextBox.ReadOnly = true;
            this.remainingBoxes_TextBox.Size = new System.Drawing.Size(256, 20);
            this.remainingBoxes_TextBox.TabIndex = 4;
            // 
            // numMoves_Label
            // 
            this.numMoves_Label.AutoSize = true;
            this.numMoves_Label.Location = new System.Drawing.Point(822, 96);
            this.numMoves_Label.Name = "numMoves_Label";
            this.numMoves_Label.Size = new System.Drawing.Size(94, 13);
            this.numMoves_Label.TabIndex = 5;
            this.numMoves_Label.Text = "Number of Moves:";
            // 
            // remainingBoxes_Label
            // 
            this.remainingBoxes_Label.AutoSize = true;
            this.remainingBoxes_Label.Location = new System.Drawing.Point(822, 185);
            this.remainingBoxes_Label.Name = "remainingBoxes_Label";
            this.remainingBoxes_Label.Size = new System.Drawing.Size(144, 13);
            this.remainingBoxes_Label.TabIndex = 6;
            this.remainingBoxes_Label.Text = "Number of Remaining Boxes:";
            // 
            // gamePadLeft_Btn
            // 
            this.gamePadLeft_Btn.Location = new System.Drawing.Point(825, 558);
            this.gamePadLeft_Btn.Name = "gamePadLeft_Btn";
            this.gamePadLeft_Btn.Size = new System.Drawing.Size(74, 54);
            this.gamePadLeft_Btn.TabIndex = 7;
            this.gamePadLeft_Btn.Text = "Left";
            this.gamePadLeft_Btn.UseVisualStyleBackColor = true;
            this.gamePadLeft_Btn.Click += new System.EventHandler(this.OnGamePadBtn_Clicked);
            // 
            // gamePadDown_Btn
            // 
            this.gamePadDown_Btn.Location = new System.Drawing.Point(916, 558);
            this.gamePadDown_Btn.Name = "gamePadDown_Btn";
            this.gamePadDown_Btn.Size = new System.Drawing.Size(74, 54);
            this.gamePadDown_Btn.TabIndex = 8;
            this.gamePadDown_Btn.Text = "Down";
            this.gamePadDown_Btn.UseVisualStyleBackColor = true;
            this.gamePadDown_Btn.Click += new System.EventHandler(this.OnGamePadBtn_Clicked);
            // 
            // gamePadRight_Btn
            // 
            this.gamePadRight_Btn.Location = new System.Drawing.Point(1007, 558);
            this.gamePadRight_Btn.Name = "gamePadRight_Btn";
            this.gamePadRight_Btn.Size = new System.Drawing.Size(74, 54);
            this.gamePadRight_Btn.TabIndex = 9;
            this.gamePadRight_Btn.Text = "Right";
            this.gamePadRight_Btn.UseVisualStyleBackColor = true;
            this.gamePadRight_Btn.Click += new System.EventHandler(this.OnGamePadBtn_Clicked);
            // 
            // gamePadUp_Btn
            // 
            this.gamePadUp_Btn.Location = new System.Drawing.Point(916, 498);
            this.gamePadUp_Btn.Name = "gamePadUp_Btn";
            this.gamePadUp_Btn.Size = new System.Drawing.Size(74, 54);
            this.gamePadUp_Btn.TabIndex = 10;
            this.gamePadUp_Btn.Text = "Up";
            this.gamePadUp_Btn.UseVisualStyleBackColor = true;
            this.gamePadUp_Btn.Click += new System.EventHandler(this.OnGamePadBtn_Clicked);
            // 
            // toolboxImages
            // 
            this.toolboxImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolboxImages.ImageStream")));
            this.toolboxImages.TransparentColor = System.Drawing.Color.Transparent;
            this.toolboxImages.Images.SetKeyName(0, "brick.jpg");
            this.toolboxImages.Images.SetKeyName(1, "red_door.png");
            this.toolboxImages.Images.SetKeyName(2, "green_door.png");
            this.toolboxImages.Images.SetKeyName(3, "red_box.png");
            this.toolboxImages.Images.SetKeyName(4, "green_box.png");
            this.toolboxImages.Images.SetKeyName(5, "none.jpg");
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 675);
            this.Controls.Add(this.gamePadUp_Btn);
            this.Controls.Add(this.gamePadRight_Btn);
            this.Controls.Add(this.gamePadDown_Btn);
            this.Controls.Add(this.gamePadLeft_Btn);
            this.Controls.Add(this.remainingBoxes_Label);
            this.Controls.Add(this.numMoves_Label);
            this.Controls.Add(this.remainingBoxes_TextBox);
            this.Controls.Add(this.numMoves_TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1194, 714);
            this.MinimumSize = new System.Drawing.Size(1194, 714);
            this.Name = "Game";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox numMoves_TextBox;
        private System.Windows.Forms.TextBox remainingBoxes_TextBox;
        private System.Windows.Forms.Label numMoves_Label;
        private System.Windows.Forms.Label remainingBoxes_Label;
        private System.Windows.Forms.Button gamePadLeft_Btn;
        private System.Windows.Forms.Button gamePadDown_Btn;
        private System.Windows.Forms.Button gamePadRight_Btn;
        private System.Windows.Forms.Button gamePadUp_Btn;
        private System.Windows.Forms.ImageList toolboxImages;
    }
}