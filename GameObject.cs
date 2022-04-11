using System.Drawing;
using System.Windows.Forms;

namespace DTomlinQGame
{
    /// <summary>
    /// This class represents a grid item on the game board. It corresponds to the 2D array that it's stored inside of. It has reference
    /// to the row and column id it's been assigned to, as well as having underlying picture box properties.
    /// </summary>
    public class GameObject : PictureBox
    {
        public GameObjectType Type { get; set; }
        public int RowId { get; set; }
        public int ColumnId { get; set; }

        public GameObject(GameObjectType type, int rowId, int columnId)
        {
            Type = type;
            RowId = rowId;
            ColumnId = columnId;
        }

        public string GetColor()
        {
            return Type == GameObjectType.RedDoor || Type == GameObjectType.RedBox ? "Red"
                : Type == GameObjectType.GreenDoor || Type == GameObjectType.GreenBox ? "Green" 
                : string.Empty;
        }

        public bool IsDoor()
        {
            return Type == GameObjectType.RedDoor || Type == GameObjectType.GreenDoor;
        }

        public bool IsBox()
        {
            return Type == GameObjectType.RedBox || Type == GameObjectType.GreenBox;
        }

        public void Reset()
        {
            this.Type = GameObjectType.None; 
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Image = null;
        }

        public static Image GetImageForType(GameObjectType type)
        {
            Image img = null;

            switch (type)
            {
                case GameObjectType.Wall:
                    img = Game.Toolbox.Images[0];
                    break;
                case GameObjectType.RedDoor:
                    img = Game.Toolbox.Images[1];
                    break;
                case GameObjectType.GreenDoor:
                    img = Game.Toolbox.Images[2];
                    break;
                case GameObjectType.RedBox:
                    img = Game.Toolbox.Images[3];
                    break;
                case GameObjectType.GreenBox:
                    img = Game.Toolbox.Images[4];
                    break;
            }

            return img;
        }

        /// <summary>
        /// This function maps a button name to a toolbox item
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Returns the grid item type</returns>
        public static GameObjectType GetGridItemTypeByName(string type)
        {
            GameObjectType? t = null;

            switch (type)
            {
                case "buttonWall":
                    t = GameObjectType.Wall;
                    break;
                case "buttonRedDoor":
                    t = GameObjectType.RedDoor;
                    break;
                case "buttonGreenDoor":
                    t = GameObjectType.GreenDoor;
                    break;
                case "buttonRedBox":
                    t = GameObjectType.RedBox;
                    break;
                case "buttonGreenBox":
                    t = GameObjectType.GreenBox;
                    break;
                case "buttonNone":
                    t = GameObjectType.None;
                    break;
            }
            return t.Value;
        }


        // This function maps an id to a grid item type
        public static int GetIdForType(GameObjectType type)
        {
            int id = 0;

            switch (type)
            {
                case GameObjectType.Wall:
                    id = 0;
                    break;
                case GameObjectType.RedDoor:
                    id = 1;
                    break;
                case GameObjectType.GreenDoor:
                    id = 2;
                    break;
                case GameObjectType.RedBox:
                    id = 3;
                    break;
                case GameObjectType.GreenBox:
                    id = 4;
                    break;
                case GameObjectType.None:
                    id = 5;
                    break;
            }
            return id;
        }


        public static GameObjectType GetTypeForId(int id)
        {
            GameObjectType? type = null;
            switch (id)
            {
                case 0:
                    type = GameObjectType.Wall;
                    break;
                case 1:
                    type = GameObjectType.RedDoor;
                    break;
                case 2:
                    type = GameObjectType.GreenDoor;
                    break;
                case 3:
                    type = GameObjectType.RedBox;
                    break;
                case 4:
                    type = GameObjectType.GreenBox;
                    break;
                case 5:
                    type = GameObjectType.None;
                    break;
            }
            return type.Value;
        }
    }


    /// <summary>
    /// Grid item type enum
    /// </summary>
    public enum GameObjectType
    {
        None,
        Wall,
        RedDoor,
        GreenDoor,
        RedBox,
        GreenBox,
        Box
    }
}
