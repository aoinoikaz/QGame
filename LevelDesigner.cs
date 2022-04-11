using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DTomlinQGame
{
    /// <summary>
    /// The main form for the level designer. Has all logic in this class.
    /// </summary>
    public partial class LevelDesigner : Form
    {
        private int rows;
        private int columns;

        private Point initialPoint;
        private Point previousPoint;
        private readonly int xOffset = 100;
        private readonly int yOffset = 50;
        private const int MAX_ROWS = 10;
        private const int MAX_COLUMNS = 6;
        private bool isInitialized = false;
        private bool isCreated = false;

        private Button currentlySelectedTool;
        private List<GameObject> GameObjects;


        public LevelDesigner()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            if (!isInitialized)
            {
                initialPoint = new Point(330, 150);
                currentlySelectedTool = null;
                GameObjects = new List<GameObject>();
                isInitialized = true;
            }
        }


        /// <summary>
        /// This function will create the grid dynamically based on the input parameters. The algorithm will iterate iterate through the 2d array and add each grid item accordingly. 
        /// It will also determine where to place each item based on the initial location/offsets.
        /// </summary>
        public void CreateGrid()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    GameObject item = new GameObject(GameObjectType.None, r, c);
                    item.Click += OnGridItemClicked;
                    item.BorderStyle = BorderStyle.Fixed3D;

                    // Initial point (first grid item)
                    if (r == 0 && c == 0)
                    {
                        item.Location = initialPoint;
                        Controls.Add(item);
                    }
                    // Any other grid item other than the first (0,0)
                    else if (c < columns)
                    {
                        // Place grid items on a new row
                        if (r > 0 && c == 0)
                        {
                            int rX = initialPoint.X;
                            int rY = previousPoint.Y + yOffset;
                            Point rLocation = new Point(rX, rY);
                            item.Location = rLocation;
                            Controls.Add(item);
                        }
                        // Place grid item in the column corresponding to that row
                        else
                        {
                            int cX = previousPoint.X + xOffset;
                            int cY = previousPoint.Y;
                            Point cLocation = new Point(cX, cY);
                            item.Location = cLocation;
                            Controls.Add(item);
                        }
                    }
                    GameObjects.Add(item);
                    previousPoint = item.Location;
                }
            }
        }

        
        /// <summary>
        /// This callback is invoked automatically when a user clicks on a grid item. It will determine which image to set on the grid and 
        /// will also reset images accordingly when choosing the gridtype of none.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGridItemClicked(object sender, EventArgs e)
        {
            if (currentlySelectedTool == null)
            {
                MessageBox.Show("Must select a tool first!", "Error");
            }
            else
            {
                GameObject item = (GameObject)sender;

                // Set the image to null instead of assigning it the none
                if (GameObject.GetGridItemTypeByName(currentlySelectedTool.Name) == GameObjectType.None)
                {
                    item.Image = null;

                    // Missed huge marks for this on AS2 because I forgot to add this 1 line of code which fixes the display output issue
                    item.Type = GameObjectType.None;
                }
                else
                {
                    item.Image = currentlySelectedTool.Image;
                    item.SizeMode = PictureBoxSizeMode.StretchImage;
                    item.Type = GameObject.GetGridItemTypeByName(currentlySelectedTool.Name);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Setup the save dialog dialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "QGame Level File|*.qgame";
                saveFileDialog.Title = "Save a level!";
                saveFileDialog.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog.FileName != string.Empty)
                {
                    // Write new data and save it to the file via a file stream created by the open file method
                    FileStream fs = (FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            string level = rows + "\n" + columns + "\n";
                            foreach (GameObject item in GameObjects)
                            {
                                level += item.RowId + "\n";
                                level += item.ColumnId + "\n";
                                level += GameObject.GetIdForType(item.Type) + "\n";
                            }
                            fs.Write(Encoding.ASCII.GetBytes(level), 0, level.Length - 1);
                            fs.Flush();
                            fs.Close();
                            
                            break;
                    }
                    DisplayResults();
                }
            }
        }

        /// <summary>
        /// This function validates user input
        /// </summary>
        /// <returns>Whether or not the user input is valid</returns>
        bool IsValid()
        {
            bool isValid = false;

            // Ensure text boxes aren't empty
            if (!string.IsNullOrEmpty(rowsTextBox.Text))
            {
                if (!string.IsNullOrEmpty(columnsTextBox.Text))
                {
                    string sRows = rowsTextBox.Text;
                    string sColumns = columnsTextBox.Text;

                    int r;
                    int c;

                    // Try to parse out integers from text boxes
                    if (int.TryParse(sRows, out r))
                    {
                        if (int.TryParse(sColumns, out c))
                        {
                            if (c > 0 && c <= MAX_COLUMNS)
                            {
                                if (r > 0 && r <= MAX_ROWS)
                                {
                                    isValid = true;
                                    rows = r;
                                    columns = c;
                                }
                                else
                                {
                                    MessageBox.Show("Row size must be between 1 and 10!", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Column size must be between 1 and 6!", "Error");
                                return isValid;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Column field must be a valid numbers!", "Error");
                            return isValid;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Row field must be a valid numbers!", "Error");
                        return isValid;
                    }
                }
                else
                {
                    MessageBox.Show("Column field cannot be blank!", "Error");
                    return isValid;
                }
            }
            else
            {
                MessageBox.Show("Row field cannot be blank!", "Error");
                return isValid;
            }
            return isValid;
        }

        /// <summary>
        /// This method simply displays the results after the level has been saved by the user
        /// </summary>
        private void DisplayResults()
        {
            int totalWalls = 0;
            int totalDoors = 0;
            int totalBoxes = 0;

            foreach (GameObject item in GameObjects)
            {
                switch (item.Type)
                {
                    case GameObjectType.Wall:
                        totalWalls++;
                        break;
                    case GameObjectType.GreenDoor:
                        totalDoors++;
                        break;
                    case GameObjectType.RedDoor:
                        totalDoors++;
                        break;
                    case GameObjectType.GreenBox:
                        totalBoxes++;
                        break;
                    case GameObjectType.RedBox:
                        totalBoxes++;
                        break;
                }
            }
            MessageBox.Show("File saved successfully: \n" + "Total number of walls: " + totalWalls + "\n" + "Total number of doors: " + totalDoors + "\n" + "Total number of boxes: " + totalBoxes);
        }


        private void GenerateGridBtn_Click(object sender, EventArgs e)
        {
            if (!isCreated)
            {
                if (IsValid())
                {
                    CreateGrid();
                    isCreated = true;
                }
            }
            else
            {
                MessageBox.Show("You have already generated a grid!", "Error");
            }
        }

        private void OnToolboxItemClicked(object sender, EventArgs e)
        {
            // Save a reference of the currently selected tool
            currentlySelectedTool = (Button)sender;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
