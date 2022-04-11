using System;
using System.Windows.Forms;

namespace DTomlinQGame
{
    public partial class ControlPanel : Form
    {
        LevelDesigner levelDesigner;
        Game game;

        public ControlPanel()
        {
            InitializeComponent();
        }


        private void BtnDesign_Click(object sender, EventArgs e)
        {
            if (levelDesigner == null)
            {
                // Create a new level designer form - reset once it closes
                levelDesigner = new LevelDesigner();
                levelDesigner.FormClosed += (s, ea) => 
                {
                    levelDesigner = null;
                };
                levelDesigner.Show();
            }
            else
            {
                MessageBox.Show("Level designer is already open!");
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                game = new Game();
                game.FormClosed += (s, ea) =>
                {
                    game = null;
                };
                game.Show();
            }
            else
            { 
                MessageBox.Show("Game is already open!", "Error");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (levelDesigner != null || game != null)
            {
                MessageBox.Show("Cannot close control panel while level designer or game is open!", "Error");
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
