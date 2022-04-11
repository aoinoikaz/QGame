using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DTomlinQGame
{
    /// <summary>
    /// This class provides all the logic for the game.
    /// </summary>
    public partial class Game : Form
    {
        private Point initialPoint;
        private Point previousPoint;
        private readonly int xOffset = 100;
        private readonly int yOffset = 50;
        private int totalMoves = 0;
        private int numBoxesLeft;

        private int totalRows;
        private int totalColumns;

        private GameObject currentlySelectedItem;
        private List<GameObject> GameObjects;

        public static ImageList Toolbox { get; set; }


        public Game()
        {
            InitializeComponent();
            Init();

        }

        /// <summary>
        /// Simply initializes some properties which are used throughout the game
        /// </summary>
        public void Init()
        {
            initialPoint = new Point(75, 75);
            GameObjects = new List<GameObject>();
            Toolbox = toolboxImages;
        }


        /// <summary>
        /// Destroy the current game state
        /// </summary>
        private void ResetLevel()
        {
            // We must iterate backwards to compensate for removal of game objects.
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i].GetType() == typeof(GameObject))
                {
                    Controls.Remove(Controls[i]);
                }
            }

            GameObjects.Clear();

            totalMoves = 0;
            previousPoint = new Point(0, 0);
            currentlySelectedItem = null;
        }


        /// <summary>
        /// This method is invoked automatically when the user clicks on the
        /// load game tool strip. It will invoke logic to parse, generate and update the 
        /// game UI
        /// </summary>
        /// <param name="sender">The control</param>
        /// <param name="e">More useless event args</param>
        private void LoadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the file dialog for user to select the .qgame file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "QGame Level File|*.qgame";
                openFileDialog.Title = "Select a level!";
                openFileDialog.ShowDialog();

                // If the file name is not an empty string open it for loading.
                if (openFileDialog.FileName != string.Empty)
                {
                    var fs = openFileDialog.OpenFile();
                    string content = string.Empty;
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        content = reader.ReadToEnd();
                    }
                    ResetLevel();
                    ParseLevel(content);
                    Generate();
                    UpdateUI();
                }
            }
        }


        /// <summary>
        /// This function parses the level data
        /// </summary>
        /// <param name="level">The string containing the level data which will be parsed</param>
        void ParseLevel(string level)
        {
            string[] split = level.Split('\n');

            totalRows = int.Parse(split[0]);
            totalColumns = int.Parse(split[1]);

            for (int i = 0; i < split.Count(); i++)
            {
                // We've already parsed the total rows and column
                if (i < 2)
                {
                    continue;
                }
                else
                {
                    // If modulo is 2, we know that its the start of the triplet data structure
                    // 2 % 3 == 2
                    // Start of first triplet is index 2,3,4 .. etc
                    // 0 % 3 == 0, 1 % 3 == 1, 2 % 3 == 2, next triple
                    if (i % 3 == 2)
                    {
                        int itemRow = int.Parse(split[i]);
                        int itemColumn = int.Parse(split[i + 1]);
                        int gameObjectType = int.Parse(split[i + 2]);

                        GameObjectType type = GameObject.GetTypeForId(gameObjectType);
                        GameObject item = new GameObject(type, itemRow, itemColumn);
                        GameObjects.Add(item);
                    }
                }
            }
        }


        /// <summary>
        /// This function generates the game object grid based on the parsed level data
        /// </summary>
        void Generate()
        {
            for (int r = 0; r < totalRows; r++)
            {
                for (int c = 0; c < totalColumns; c++)
                {
                    GameObject item = GameObjects.Find(i => i.RowId == r && i.ColumnId == c);
                    item.Image = GameObject.GetImageForType(item.Type);
                    item.SizeMode = PictureBoxSizeMode.StretchImage;

                    // So the demo video shows no border style, however my images aren't great so im adding this just for visual aid to help show the bounds of the map. 
                    item.BorderStyle = BorderStyle.Fixed3D;
                    item.Click += OnGridItemClicked;

                    // Initial point (first grid item)
                    if (r == 0 && c == 0)
                    {
                        item.Location = initialPoint;
                        Controls.Add(item);
                    }
                    // Any other grid item other than the first (0,0)
                    else if (c < totalColumns)
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
                    previousPoint = item.Location;
                }
            }
        }


        /// <summary>
        /// This function calculates collision and moves the selected box accordingly
        /// </summary>
        /// <param name="dir">Direction to move the game object</param>
        private void HandleMove(string dir)
        {
            bool collided = false;

            while (!collided)
            {
                // Get the direction (orientation that our object will be moved)
                // Based on basic vector math, we know that up and left will be negative and
                // down / right is positive
                int direction = (dir == "Up" || dir == "Left") ? -1 : 1;

                int nextColumn = currentlySelectedItem.ColumnId;
                int nextRow = currentlySelectedItem.RowId;

                if (dir == "Up" || dir == "Down")
                {
                    nextRow += direction;
                }
                else
                {
                    nextColumn += direction;
                }

                GameObject nextGameObject = GetGameObject(nextRow, nextColumn);

                // If there actually is a next game object, then swap it
                if (nextGameObject != null && nextGameObject.Type == GameObjectType.None)
                {
                    SwapGameObjects(currentlySelectedItem, nextGameObject);
                }
                else
                {
                    if (nextGameObject != null && nextGameObject.IsDoor() && currentlySelectedItem.GetColor() == nextGameObject.GetColor())
                    {
                        currentlySelectedItem.Reset();
                        numBoxesLeft--;
                    }

                    collided = true;
                    continue;
                }
            }
        }


        /// <summary>
        /// This function swaps game objects, simulating movement, which also respects
        /// the underlying picture box grid
        /// </summary>
        /// <param name="obj1">Object to be moved</param>
        /// <param name="obj2">Objetc being swapped</param>
        void SwapGameObjects(GameObject obj1, GameObject obj2)
        {
            int tempRow = obj1.RowId;
            int tempCol = obj1.ColumnId;
            Point tempLocation = obj1.Location;

            obj1.Location = obj2.Location;
            obj2.Location = tempLocation;

            obj1.ColumnId = obj2.ColumnId;
            obj2.ColumnId = tempCol;

            obj1.RowId = obj2.RowId;
            obj2.RowId = tempRow;

            obj1.BringToFront();
        }


        /// <summary>
        /// This method is invoked automatically when the user clicks on a game object and will handle updating
        /// the currently selected objects as well as minor UI updates.
        /// </summary>
        /// <param name="sender">The currently selected item</param>
        /// <param name="e">More useless event args</param>
        private void OnGridItemClicked(object sender, EventArgs e)
        {
            // User hasn't selected a box
            if (currentlySelectedItem == null)
            {
                currentlySelectedItem = (GameObject)sender;

                if (currentlySelectedItem.Type != GameObjectType.GreenBox && currentlySelectedItem.Type != GameObjectType.RedBox)
                {
                    MessageBox.Show("You must choose either a green or red box!", "Error");
                    currentlySelectedItem = null;
                }
                else
                {
                    currentlySelectedItem.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            else
            {
                // Remove the previous border style
                currentlySelectedItem.BorderStyle = BorderStyle.Fixed3D;

                // Save the item the user clicked
                currentlySelectedItem = (GameObject)sender;

                if (currentlySelectedItem.Type != GameObjectType.GreenBox && currentlySelectedItem.Type != GameObjectType.RedBox)
                {
                    MessageBox.Show("You must choose either a green or red box!", "Error");
                    currentlySelectedItem = null;
                }
                else
                {
                    currentlySelectedItem.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }


        /// <summary>
        /// This method is invoked automatically when the user clicks on the game pad
        /// </summary>
        /// <param name="sender">The corresponding game pad button</param>
        /// <param name="e">Useless event args in this case</param>
        private void OnGamePadBtn_Clicked(object sender, EventArgs e)
        {
            totalMoves++;
            numMoves_TextBox.Text = totalMoves.ToString();

            // first, check if a grid item is clicked, if not error
            if (currentlySelectedItem == null)
            {
                MessageBox.Show("You must choose either a red or green box!", "Error");
            }
            else
            {
                Button direction = (Button)sender;
                HandleMove(direction.Text);
            }

            if (numBoxesLeft == 0)
            {
                MessageBox.Show("You won!");
                ResetLevel();
            }

            UpdateUI();
        }


        /// <summary>
        /// This function simply updates the user interface
        /// </summary>
        private void UpdateUI()
        {
            numBoxesLeft = 0;

            foreach (GameObject item in GameObjects)
            {
                if (item.Type == GameObjectType.GreenBox)
                {
                    numBoxesLeft++;
                }
                else if (item.Type == GameObjectType.RedBox)
                {
                    numBoxesLeft++;
                }
            }

            remainingBoxes_TextBox.Text = numBoxesLeft.ToString();
            numMoves_TextBox.Text = totalMoves.ToString();
        }


        /// <summary>
        /// This function simply returns a game obnect
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public GameObject GetGameObject(int row, int column)
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                if (GameObjects[i].RowId == row && GameObjects[i].ColumnId == column)
                {
                    return GameObjects[i];
                }
            }
            return null;
        }
    }
}
