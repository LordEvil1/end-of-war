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
    public partial class Flappy_Bird_game : Form
    {
        int pipeSpeed = 4,
            gravity = 5,
            score = 0;
           

        public Flappy_Bird_game()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            

            score_label.Text = "score:"+score.ToString();
////////////////////////////////////////////////////////////////////
            flappy_bird.Top += gravity;
            pipe.Left -= pipeSpeed;
            pipeDown.Left -= pipeSpeed;
            pipe2.Left -= pipeSpeed;
            pipeDown2.Left -= pipeSpeed;
////////////////////////////////////////////////////////////////////
            if (pipe.Left < -40)
            {
                score++;
                pipe.Left = 500-20;
            }   
            if (pipeDown.Left < -40)
            {
                score++;
                pipeDown.Left = 550-30;
            }          
            if (pipeDown2.Left < -40)
            {
                score++;
                pipeDown2.Left = 850-20;
            }            
            if (pipe2.Left < -40)
            {
                score++;
                pipe2.Left = 840-10;
                
            }
            ////////////////////////////////////////////////////////////////////
            if (flappy_bird.Bounds.IntersectsWith(pipe.Bounds)||               
                flappy_bird.Bounds.IntersectsWith(pipe2.Bounds) ||
                flappy_bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                flappy_bird.Bounds.IntersectsWith(pipeDown2.Bounds)||
                flappy_bird.Bounds.IntersectsWith(ground.Bounds)||
                flappy_bird.Bounds.IntersectsWith(Air.Bounds))
            {
                EndGame();
            }
////////////////////////////////////////////////////////////////////
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -4;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 4;
            }
        }

        private void Flappy_Bird_game_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }
        private void EndGame()
        {
            pipeSpeed = 4;
            timer1.Enabled = false;
            res.w = res.w + (score * 5);
            res.m = res.m + (score * 5);
            MessageBox.Show("GameOver"+
                " Your Score:"+score);
            score = 0;
            pipe.Left = 400;
            pipeDown.Left = 410;
            pipe2.Left = 810;
            pipeDown2.Left = 860;
            flappy_bird.Top = 75;
            pipeDown2.Top += 1;

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void StartBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
            }
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Speed_Tick(object sender, EventArgs e)
        {
            pipeSpeed++;
        }
    }
}
