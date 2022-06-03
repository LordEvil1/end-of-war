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
    public partial class war : Form
    {

        public war()
        {
            InitializeComponent();
        }
        public void defat()      
        {
            MessageBox.Show("your army cant defet enemy");
            res.army_count = res.army_count - (res.army_count / 5);
        }

        private void war_timer_Tick(object sender, EventArgs e)
        {
            rohan_pic.Image = res.Image1r;
            enemy_pic.Image = res.Image2e;
            enemy_power_count.Text = res.enemy_power.ToString();





            res.rohan_power = Convert.ToInt32(your_power.Text);

        }

        private void war_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void start_battle_Click(object sender, EventArgs e) // WAr button -------------------------
        {       
            
            //level 10
            if (res.e10 == true)
            {
                //level 10 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e9 = false;
                    res.e10 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 1000000;
                    res.m = res.m + 1000000;
                    res.g = res.g + 200;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources.WinRohan;
                    res.Image2e = end_of_war.Properties.Resources.WinWar;
                    //enemy power up
                    res.enemy_power = 0;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    start_battle.Enabled = false;
                    start_battle.Visible = false;
                    res.level += 1;
                }
                // level 10 fail
                else
                {
                    MessageBox.Show("your army cant defet enemy");
                    res.army_count = res.army_count - (res.army_count / 2);
                }
                    
            }
            //============================================================
            //level 9
            if (res.e9 == true)
            {
                //level 9vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e9 = false;
                    res.e10 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 256000;
                    res.m = res.m + 352000;
                    res.g = res.g + 90;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._20;
                    res.Image2e = end_of_war.Properties.Resources._10;
                    //enemy power up
                    res.enemy_power = 500000;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level += 1;
                }
                // level 9 fail
                else
                    defat();
            }
            //============================================================
            //level 8
            if (res.e8 == true)
            {
                //level 8 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e8 = false;
                    res.e9 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 128000;
                    res.m = res.m + 176000;
                    res.g = res.g + 80;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._19;
                    res.Image2e = end_of_war.Properties.Resources._9;
                    //enemy power up
                    res.enemy_power = 255000;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level = res.level + 1;
                }
                // level 8 fail
                else
                    defat();
            }
            //============================================================
            //level 7
            if (res.e7 == true)
            {
                //level 7 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e7 = false;
                    res.e8 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 64000;
                    res.m = res.m + 88000;
                    res.g = res.g + 70;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._18;
                    res.Image2e = end_of_war.Properties.Resources._8;
                    //enemy power up
                    res.enemy_power = 125096;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level = res.level + 1;
                }
                // level 7 fail
                else
                    defat();
            }
            //============================================================
            //level 6
            if (res.e6 == true)
            {
                //level 6 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e6 = false;
                    res.e7 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 32000;
                    res.m = res.m + 44000;
                    res.g = res.g + 60;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._17;
                    res.Image2e = end_of_war.Properties.Resources._7;
                    //enemy power up
                    res.enemy_power = 62500;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level = res.level + 1;
                }
                // level 6 fail
                else
                    defat();
            }
            //============================================================
            //level 5
            if (res.e5 == true)
            {
                //level 5 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e5 = false;
                    res.e6 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 16000;
                    res.m = res.m + 22000;
                    res.g = res.g + 50;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._16;
                    res.Image2e = end_of_war.Properties.Resources._6;
                    //enemy power up
                    res.enemy_power = 31252;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level = res.level + 1;
                }
                // level 5 fail
                else
                    defat();
            }
            //============================================================
            //level 4
            if (res.e4 == true)
            {
                //level 4 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e4 = false;
                    res.e5 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 8000;
                    res.m = res.m + 12000;
                    res.g = res.g + 40;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._15;
                    res.Image2e = end_of_war.Properties.Resources._5;
                    //enemy power up
                    res.enemy_power = 15625;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level = res.level + 1;
                }
                // level 4 fail
                else
                    defat();
            }
            //============================================================
            //level 3
            if (res.e3 == true)
            {
                //level 3 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e3 = false;
                    res.e4 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 4000;
                    res.m = res.m + 6000;
                    res.g = res.g + 30;
                    //picture
                    res.Image1r = end_of_war.Properties.Resources._14;
                    res.Image2e = end_of_war.Properties.Resources._4;
                    //enemy power up
                    res.enemy_power = 7812;
                    enemy_power_count.Text = res.enemy_power.ToString();
                    res.level = res.level + 1;
                }
                // level 2 fail
                else
                defat();
            }
            //===================================================================================
            //level 2
            if (res.e2 == true)
            {

                //level 2 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e2 = false;
                    res.e3 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 2000;
                    res.m = res.m + 3000;
                    res.g = res.g + 20;
                    res.Image1r = end_of_war.Properties.Resources._13;
                    res.Image2e = end_of_war.Properties.Resources._3;

                    res.level = res.level + 1;

                    res.enemy_power = 3906;
                    enemy_power_count.Text = res.enemy_power.ToString();

                }

                // level 2 fail
                else
                    defat();
            }

            //============================================================
            //============================================================
            //level 1
            if (res.e1 == true)
            {
                //level 1 vict
                if ((res.rohan_power - res.enemy_power) * 2 > res.enemy_power)
                {
                    res.e1 = false;
                    res.e2 = true;
                    MessageBox.Show("you defet the enemy ");
                    res.w = res.w + 1000;
                    res.m = res.m + 1500;
                    res.g = res.g + 10;
                    res.Image1r = end_of_war.Properties.Resources._12;
                    res.Image2e = end_of_war.Properties.Resources._2;

                    res.level = res.level + 1;

                    res.enemy_power = 1953;
                    enemy_power_count.Text = res.enemy_power.ToString();

                }
                // level 1 fail
                else
                    defat();
            }

        }

        private void rohan_pic_Click(object sender, EventArgs e)
        {

        }//end of this private void start_battle_Click

            
        }

    }
