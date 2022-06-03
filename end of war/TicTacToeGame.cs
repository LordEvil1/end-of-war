using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using end_of_war.Properties;

namespace end_of_war
{
    public partial class TicTacToeGame : Form
    {
        bool[] ticked = new bool[9];

        public TicTacToeGame()
        {
            InitializeComponent();
        }
        private void A1_Click(object sender, EventArgs e)
        {
            ticked[0] = true;
            A1.Enabled = false;
            A1.Width = 170;
            A1.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();           
            enemy_move();
        }
        private void A2_Click(object sender, EventArgs e)
        {
            ticked[1] = true;
            A2.Enabled = false;
            A2.Width = 170;
            A2.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void A1_CLICK(object sender, EventArgs e)
        {
            ticked[0] = true;
            A1.Enabled = false;
            A1.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            ticked[2] = true;
            A3.Enabled = false;
            A3.Width = 170;
            A3.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();

        }

        private void B1_Click(object sender, EventArgs e)
        {
            ticked[3] = true;
            B1.Enabled = false;
            B1.Width = 170;
            B1.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ticked[4] = true;
            B2.Enabled = false;
            B2.Width = 170;
            B2.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            ticked[5] = true;
            B3.Enabled = false;
            B3.Width = 170;
            B3.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            ticked[6] = true;
            C1.Enabled = false;
            C1.Width = 170;
            C1.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            ticked[7] = true;
            C2.Enabled = false;
            C2.Width = 170;
            C2.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            ticked[8] = true;
            C3.Enabled = false;
            C3.Width = 170;
            C3.Image = end_of_war.Properties.Resources.sword;
            checkforwinner();
            enemy_move();
        }

        private void BACKGROUND_IMG_Click(object sender, EventArgs e)
        {

        }

        private void CheckForWin_Tick(object sender, EventArgs e)
        {



        }

        public void checkforwinner()
        {

            if (A1.Width == A2.Width && A2.Width == A3.Width)
                WIN();
            //A1A2A3
            else if (B1.Width == B2.Width && B2.Width == B3.Width)
                WIN();
            //B1B2B3
            else if (C1.Width == C2.Width && C2.Width == C3.Width)
                WIN();
            //C1C2C3
            else if (A1.Width == B1.Width && B1.Width == C1.Width)
                WIN();
            //A1B1C1       
            else if (A2.Width == B2.Width && B2.Width == C2.Width)
                WIN();
            //A2B2C2
            else if (A3.Width == B3.Width && B3.Width == C3.Width)
                WIN();
            //A3B3C3
            else if (A1.Width == B2.Width && B2.Width == C3.Width)
                WIN();
            //A1B2C3
            else if (A3.Width == B2.Width && B2.Width == C1.Width)
                WIN();
            //A3B2C1
            // AI WIN CHECK --------------------------------------
            else if (A1.Height == A2.Height && A2.Height == A3.Height)
                WIN();
            //A1A2A3
            else if (B1.Height == B2.Height && B2.Height == B3.Height)
                AIwin();
            //B1B2B3
            else if (C1.Height == C2.Height && C2.Height == C3.Height)
                AIwin();
            //C1C2C3
            else if (A1.Height == B1.Height && B1.Height == C1.Height)
                AIwin();
            //A1B1C1       
            else if (A2.Height == B2.Height && B2.Height == C2.Height)
                AIwin();
            //A2B2C2
            else if (A3.Height == B3.Height && B3.Height == C3.Height)
                AIwin();
            //A3B3C3
            else if (A1.Height == B2.Height && B2.Height == C3.Height)
                AIwin();
            //A1B2C3
            else if (A3.Height == B2.Height && B2.Height == C1.Height)
                AIwin();
            //A3B2C1              
            else if (ticked[0] && ticked[1] && ticked[2] && ticked[3] && ticked[4] && ticked[5] && ticked[6] && ticked[7] && ticked[8])
            {
                MessageBox.Show("Tie");
                int i = 171;
                int ii = 140;
                foreach (PictureBox c in Controls)
                {
                    if (c.Name == "BACKGROUND_IMG")
                    { }
                    else
                    {
                        PictureBox b = (PictureBox)c;
                        b.Enabled = true;
                        b.Image = null;
                        b.Width = i;
                        i++;
                        b.Height = ii;
                        ii++;
                    }
                    for (int i2 = 0; i2 <= 8; i2++)
                        ticked[i2] = false;

                }
            }
            
                




        }
        public void WIN()
        {
            res.w += 100;
            res.m += 80;
            res.g += 1;
            MessageBox.Show("there is a Winner");
            int i = 171;
            int ii = 140;
            foreach (PictureBox c in Controls)
            {
                if (c.Name == "BACKGROUND_IMG")
                {

                }
                else
                {
                    PictureBox b = (PictureBox)c;
                    b.Enabled = true;
                    b.Image = null;
                    b.Width = i;
                    i++;
                    b.Height = ii;
                    ii++;
                }
                for (int i2 = 0; i2 <= 8; i2++)
                {
                    ticked[i2] = false;
                }

            }

        }
        public void AIwin()
        {
            MessageBox.Show("AI win the game");
            int i = 171;
            int ii = 140;
            foreach (PictureBox c in Controls)
            {
                if (c.Name == "BACKGROUND_IMG")
                { }
                else
                {
                    PictureBox b = (PictureBox)c;
                    b.Enabled = true;
                    b.Image = null;
                    b.Width = i;
                    i++;
                    b.Height = ii;
                    ii++;
                }
                for (int i2 = 0; i2 <= 8; i2++)
                    ticked[i2] = false;

            }
        }
        
        public void enemy_move()
        {
           
            for (int moveCharge = 0; moveCharge < 1; moveCharge++)
            {
                //Ai try to win last move
                if (!ticked[2])
                {
                    if (A1.Height == A2.Height)//1    
                    {

                        A3.Height = 139;
                        A3.Enabled = false;
                        A3.Image = Resources.shild;
                        ticked[2] = true;
                        checkforwinner();
                        break;
                    }
                }
                if (!ticked[6])
                {
                    if (A1.Height == B1.Height)//2
                    {
                        C1.Height = 139;
                        C1.Enabled = false;
                        C1.Image = Resources.shild;
                        ticked[6] = true; checkforwinner();
                        break;
                    }
                }
                if (!ticked[8])
                {
                    if (A1.Height == B2.Height)//3
                    {
                        C3.Height = 139;
                        C3.Enabled = false;
                        C3.Image = Resources.shild;
                        ticked[8] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[1])
                {
                    if (A1.Height == A3.Height)//4
                    {
                        A2.Height = 139;
                        A2.Enabled = false;
                        A2.Image = Resources.shild;
                        ticked[1] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[3])
                {
                    if (A1.Height == C1.Height)//5
                    {
                        B1.Height = 139;
                        B1.Enabled = false;
                        B1.Image = Resources.shild;
                        ticked[3] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (A1.Height == C3.Height)//6
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[0])
                {
                    if (B1.Height == C1.Height)//7
                    {
                        A1.Height = 139;
                        A1.Enabled = false;
                        A1.Image = Resources.shild;
                        ticked[0] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[5])
                {
                    if (B1.Height == B2.Height)//8
                    {
                        B3.Height = 139;
                        B3.Enabled = false;
                        B3.Image = Resources.shild;
                        ticked[5] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (B1.Height == B3.Height)//9
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[0])
                {
                    if (A2.Height == A3.Height)//10
                    {
                        A1.Height = 139;
                        A1.Enabled = false;
                        A1.Image = Resources.shild;
                        ticked[0] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[7])
                {
                    if (A2.Height == B2.Height)//11
                    {
                        C2.Height = 139;
                        C2.Enabled = false;
                        C2.Image = Resources.shild;
                        ticked[7] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (A2.Height == C2.Height)//12
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[2])
                {
                    if (C1.Height == B2.Height)//13
                    {
                        A3.Height = 139;
                        A3.Enabled = false;
                        A3.Image = Resources.shild;
                        ticked[2] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (C1.Height == A3.Height)//14
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[7])
                {
                    if (C1.Height == C3.Height)//15
                    {
                        C2.Height = 139;
                        C2.Enabled = false;
                        C2.Image = Resources.shild;
                        ticked[7] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[8])
                {
                    if (C1.Height == C2.Height)//16
                    {
                        C3.Height = 139;
                        C3.Enabled = false;
                        C3.Image = Resources.shild;
                        ticked[8] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[8])
                {
                    if (A3.Height == B3.Height)//17
                    {
                        C3.Height = 139;
                        C3.Enabled = false;
                        C3.Image = Resources.shild;
                        ticked[8] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[5])
                {
                    if (A3.Height == C3.Height)//18
                    {
                        B3.Height = 139;
                        B3.Enabled = false;
                        B3.Image = Resources.shild;
                        ticked[5] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[6])
                {
                    if (A3.Height == B2.Height)//19
                    {
                        C1.Height = 139;
                        C1.Enabled = false;
                        C1.Image = Resources.shild;
                        ticked[6] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[0])
                {
                    if (B2.Height == C3.Height)//20
                    {
                        A1.Height = 139;
                        A1.Enabled = false;
                        A1.Image = Resources.shild;
                        ticked[0] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[1])
                {
                    if (B2.Height == C2.Height)//21
                    {
                        A2.Height = 139;
                        A2.Enabled = false;
                        A2.Image = Resources.shild;
                        ticked[1] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[3])
                {
                    if (B2.Height == B3.Height)//22
                    {
                        B1.Height = 139;
                        B1.Enabled = false;
                        B1.Image = Resources.shild;
                        ticked[3] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[2])
                {
                    if (B3.Height == C3.Height)//23
                    {
                        A3.Height = 139;
                        A3.Enabled = false;
                        A3.Image = Resources.shild;
                        ticked[2] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[6])
                {
                    if (C2.Height == C3.Height)//24
                    {
                        C1.Height = 139;
                        C1.Enabled = false;
                        C1.Image = Resources.shild;
                        ticked[6] = true;
                        checkforwinner(); break;
                    }
                }
                    //start blocking player
                if (!ticked[2])
                {
                    if (A1.Width == A2.Width)//1    
                    {

                        A3.Height = 139;
                        A3.Enabled = false;
                        A3.Image = Resources.shild;
                        ticked[2] = true;
                        checkforwinner();
                        break;
                    }
                }
                if (!ticked[6])
                {
                    if (A1.Width == B1.Width)//2
                    {
                        C1.Height = 139;
                        C1.Enabled = false;
                        C1.Image = Resources.shild;
                        ticked[6] = true; checkforwinner();
                        break;
                    }
                }
                if (!ticked[8])
                {
                    if (A1.Width == B2.Width)//3
                    {
                        C3.Height = 139;
                        C3.Enabled = false;
                        C3.Image = Resources.shild;
                        ticked[8] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[1])
                {
                    if (A1.Width == A3.Width)//4
                    {
                        A2.Height = 139;
                        A2.Enabled = false;
                        A2.Image = Resources.shild;
                        ticked[1] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[3])
                {
                    if (A1.Width == C1.Width)//5
                    {
                        B1.Height = 139;
                        B1.Enabled = false;
                        B1.Image = Resources.shild;
                        ticked[3] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (A1.Width == C3.Width)//6
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[0])
                {
                    if (B1.Width == C1.Width)//7
                    {
                        A1.Height = 139;
                        A1.Enabled = false;
                        A1.Image = Resources.shild;
                        ticked[0] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[5])
                {
                    if (B1.Width == B2.Width)//8
                    {
                        B3.Height = 139;
                        B3.Enabled = false;
                        B3.Image = Resources.shild;
                        ticked[5] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (B1.Width == B3.Width)//9
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[0])
                {
                    if (A2.Width == A3.Width)//10
                    {
                        A1.Height = 139;
                        A1.Enabled = false;
                        A1.Image = Resources.shild;
                        ticked[0] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[7])
                {
                    if (A2.Width == B2.Width)//11
                    {
                        C2.Height = 139;
                        C2.Enabled = false;
                        C2.Image = Resources.shild;
                        ticked[7] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (A2.Width == C2.Width)//12
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[2])
                {
                    if (C1.Width == B2.Width)//13
                    {
                        A3.Height = 139;
                        A3.Enabled = false;
                        A3.Image = Resources.shild;
                        ticked[2] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[4])
                {
                    if (C1.Width == A3.Width)//14
                    {
                        B2.Height = 139;
                        B2.Enabled = false;
                        B2.Image = Resources.shild;
                        ticked[4] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[7])
                {
                    if (C1.Width == C3.Width)//15
                    {
                        C2.Height = 139;
                        C2.Enabled = false;
                        C2.Image = Resources.shild;
                        ticked[7] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[8])
                {
                    if (C1.Width == C2.Width)//16
                    {
                        C3.Height = 139;
                        C3.Enabled = false;
                        C3.Image = Resources.shild;
                        ticked[8] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[8])
                {
                    if (A3.Width == B3.Width)//17
                    {
                        C3.Height = 139;
                        C3.Enabled = false;
                        C3.Image = Resources.shild;
                        ticked[8] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[5])
                {
                    if (A3.Width == C3.Width)//18
                    {
                        B3.Height = 139;
                        B3.Enabled = false;
                        B3.Image = Resources.shild;
                        ticked[5] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[6])
                {
                    if (A3.Width == B2.Width)//19
                    {
                        C1.Height = 139;
                        C1.Enabled = false;
                        C1.Image = Resources.shild;
                        ticked[6] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[0])
                {
                    if (B2.Width == C3.Width)//20
                    {
                        A1.Height = 139;
                        A1.Enabled = false;
                        A1.Image = Resources.shild;
                        ticked[0] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[1])
                {
                    if (B2.Width == C2.Width)//21
                    {
                        A2.Height = 139;
                        A2.Enabled = false;
                        A2.Image = Resources.shild;
                        ticked[1] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[3])
                {
                    if (B2.Width == B3.Width)//22
                    {
                        B1.Height = 139;
                        B1.Enabled = false;
                        B1.Image = Resources.shild;
                        ticked[3] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[2])
                {
                    if (B3.Width == C3.Width)//23
                    {
                        A3.Height = 139;
                        A3.Enabled = false;
                        A3.Image = Resources.shild;
                        ticked[2] = true;
                        checkforwinner(); break;
                    }
                }
                if (!ticked[6])
                {
                    if (C2.Width == C3.Width)//24
                    {
                        C1.Height = 139;
                        C1.Enabled = false;
                        C1.Image = Resources.shild;
                        ticked[6] = true;
                        checkforwinner(); break;
                    }
                }
                for (int freeMove = 0; freeMove < 1; freeMove++)
                {
                    Random Move = new Random();
                    int choice = Move.Next(1, 9);
                    switch (choice)
                    {
                        case (1):
                            if (!ticked[0] && A1.Image == null)
                            {
                                A1.Height = 139;
                                A1.Enabled = false;
                                A1.Image = Resources.shild;
                                ticked[0] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (2):
                            if (!ticked[1] && A2.Image == null)
                            {
                                A2.Height = 139;
                                A2.Enabled = false;
                                A2.Image = Resources.shild;
                                ticked[1] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (3):
                            if (!ticked[2] && A3.Image == null)
                            {
                                A3.Height = 139;
                                A3.Enabled = false;
                                A3.Image = Resources.shild;
                                ticked[2] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (4):
                            if (!ticked[3] && B1.Image == null)
                            {
                                B1.Height = 139;
                                B1.Enabled = false;
                                B1.Image = Resources.shild;
                                ticked[3] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (5):
                            if (!ticked[4] && B2.Image == null)
                            {
                                B2.Height = 139;
                                B2.Enabled = false;
                                B2.Image = Resources.shild;
                                ticked[4] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (6):
                            if (!ticked[5] && B3.Image == null)
                            {
                                B3.Height = 139;
                                B3.Enabled = false;
                                B3.Image = Resources.shild;
                                ticked[5] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (7):
                            if (!ticked[6] && C1.Image == null)
                            {
                                C1.Height = 139;
                                C1.Enabled = false;
                                C1.Image = Resources.shild;
                                ticked[6] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (8):
                            if (!ticked[7] && C2.Image == null)
                            {
                                C2.Height = 139;
                                C2.Enabled = false;
                                C2.Image = Resources.shild;
                                ticked[7] = true; checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        case (9):
                            if (!ticked[8] && C3.Image == null)
                            {
                                C3.Height = 139;
                                C3.Enabled = false;
                                ticked[8] = true;
                                C3.Image = Resources.shild;
                                checkforwinner();
                            }
                            else
                            {
                                freeMove -= 1;
                                continue;
                            }
                            break;
                        default:
                            break;





                    }


                }

            }
        }
    }
}
