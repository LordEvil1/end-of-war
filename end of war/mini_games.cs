using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end_of_war
{
    public partial class mini_games : Form
    {
        public mini_games()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flappy_Bird_game Flappy_Bird_game = new Flappy_Bird_game();
            this.Hide();
            Flappy_Bird_game.Show();
            

        }

        private void mini_games_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            this.Close();
            ticTacToeGame.Show();
            
        }
    }
}
