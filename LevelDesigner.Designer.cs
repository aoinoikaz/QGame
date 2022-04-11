
namespace DTomlinQGame
{
    partial class LevelDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelDesigner));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.toolboxGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonGreenDoor = new System.Windows.Forms.Button();
            this.toolboxImages = new System.Windows.Forms.ImageList(this.components);
            this.buttonWall = new System.Windows.Forms.Button();
            this.buttonGreenBox = new System.Windows.Forms.Button();
            this.buttonRedBox = new System.Windows.Forms.Button();
            this.buttonRedDoor = new System.Windows.Forms.Button();
            this.buttonNone = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.toolboxGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.columnsTextBox);
            this.groupBox1.Controls.Add(this.rowsTextBox);
            this.groupBox1.Controls.Add(this.columnsLabel);
            this.groupBox1.Controls.Add(this.rowsLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(348, 16);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(101, 52);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateGridBtn_Click);
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Location = new System.Drawing.Point(182, 48);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.columnsTextBox.TabIndex = 5;
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(9, 48);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowsTextBox.TabIndex = 4;
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(179, 16);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(50, 13);
            this.columnsLabel.TabIndex = 3;
            this.columnsLabel.Text = "Columns:";
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(6, 16);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(37, 13);
            this.rowsLabel.TabIndex = 2;
            this.rowsLabel.Text = "Rows:";
            // 
            // toolboxGroupBox
            // 
            this.toolboxGroupBox.Controls.Add(this.buttonGreenDoor);
            this.toolboxGroupBox.Controls.Add(this.buttonWall);
            this.toolboxGroupBox.Controls.Add(this.buttonGreenBox);
            this.toolboxGroupBox.Controls.Add(this.buttonRedBox);
            this.toolboxGroupBox.Controls.Add(this.buttonRedDoor);
            this.toolboxGroupBox.Controls.Add(this.buttonNone);
            this.toolboxGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolboxGroupBox.Location = new System.Drawing.Point(12, 113);
            this.toolboxGroupBox.Name = "toolboxGroupBox";
            this.toolboxGroupBox.Size = new System.Drawing.Size(282, 546);
            this.toolboxGroupBox.TabIndex = 4;
            this.toolboxGroupBox.TabStop = false;
            this.toolboxGroupBox.Text = "Toolbox";
            // 
            // buttonGreenDoor
            // 
            this.buttonGreenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenDoor.ImageIndex = 2;
            this.buttonGreenDoor.ImageList = this.toolboxImages;
            this.buttonGreenDoor.Location = new System.Drawing.Point(54, 291);
            this.buttonGreenDoor.Name = "buttonGreenDoor";
            this.buttonGreenDoor.Size = new System.Drawing.Size(165, 58);
            this.buttonGreenDoor.TabIndex = 7;
            this.buttonGreenDoor.Text = "Green Door";
            this.buttonGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenDoor.UseVisualStyleBackColor = true;
            this.buttonGreenDoor.Click += new System.EventHandler(this.OnToolboxItemClicked);
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
            this.toolboxImages.Images.SetKeyName(5, "");
            // 
            // buttonWall
            // 
            this.buttonWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWall.ImageIndex = 0;
            this.buttonWall.ImageList = this.toolboxImages;
            this.buttonWall.Location = new System.Drawing.Point(54, 141);
            this.buttonWall.Name = "buttonWall";
            this.buttonWall.Size = new System.Drawing.Size(165, 58);
            this.buttonWall.TabIndex = 6;
            this.buttonWall.Text = "Wall";
            this.buttonWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWall.UseVisualStyleBackColor = true;
            this.buttonWall.Click += new System.EventHandler(this.OnToolboxItemClicked);
            // 
            // buttonGreenBox
            // 
            this.buttonGreenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenBox.ImageIndex = 4;
            this.buttonGreenBox.ImageList = this.toolboxImages;
            this.buttonGreenBox.Location = new System.Drawing.Point(54, 445);
            this.buttonGreenBox.Name = "buttonGreenBox";
            this.buttonGreenBox.Size = new System.Drawing.Size(165, 58);
            this.buttonGreenBox.TabIndex = 5;
            this.buttonGreenBox.Text = "Green Box";
            this.buttonGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenBox.UseVisualStyleBackColor = true;
            this.buttonGreenBox.Click += new System.EventHandler(this.OnToolboxItemClicked);
            // 
            // buttonRedBox
            // 
            this.buttonRedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedBox.ImageIndex = 3;
            this.buttonRedBox.ImageList = this.toolboxImages;
            this.buttonRedBox.Location = new System.Drawing.Point(54, 369);
            this.buttonRedBox.Name = "buttonRedBox";
            this.buttonRedBox.Size = new System.Drawing.Size(165, 58);
            this.buttonRedBox.TabIndex = 4;
            this.buttonRedBox.Text = "Red Box";
            this.buttonRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedBox.UseVisualStyleBackColor = true;
            this.buttonRedBox.Click += new System.EventHandler(this.OnToolboxItemClicked);
            // 
            // buttonRedDoor
            // 
            this.buttonRedDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedDoor.ImageIndex = 1;
            this.buttonRedDoor.ImageList = this.toolboxImages;
            this.buttonRedDoor.Location = new System.Drawing.Point(54, 217);
            this.buttonRedDoor.Name = "buttonRedDoor";
            this.buttonRedDoor.Size = new System.Drawing.Size(165, 58);
            this.buttonRedDoor.TabIndex = 2;
            this.buttonRedDoor.Text = "Red Door";
            this.buttonRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedDoor.UseVisualStyleBackColor = true;
            this.buttonRedDoor.Click += new System.EventHandler(this.OnToolboxItemClicked);
            // 
            // buttonNone
            // 
            this.buttonNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNone.ImageIndex = 5;
            this.buttonNone.ImageList = this.toolboxImages;
            this.buttonNone.Location = new System.Drawing.Point(54, 63);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(165, 58);
            this.buttonNone.TabIndex = 0;
            this.buttonNone.Text = "None";
            this.buttonNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNone.UseVisualStyleBackColor = true;
            this.buttonNone.Click += new System.EventHandler(this.OnToolboxItemClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // LevelDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.toolboxGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "LevelDesigner";
            this.Text = "Level Designer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolboxGroupBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox columnsTextBox;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.GroupBox toolboxGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button buttonGreenBox;
        private System.Windows.Forms.Button buttonRedBox;
        private System.Windows.Forms.Button buttonRedDoor;
        private System.Windows.Forms.Button buttonNone;
        private System.Windows.Forms.Button buttonWall;
        private System.Windows.Forms.ImageList toolboxImages;
        private System.Windows.Forms.Button buttonGreenDoor;
    }
}