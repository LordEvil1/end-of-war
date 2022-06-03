using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;




namespace end_of_war
{

    public partial class main_game : Form
    {
       private OleDbConnection connetion = new OleDbConnection();



        //mr and wr means metal requid ---- wll means wood label level ------wgi means wood gen i//
        // int g = 0, w = 50000, m = 50000, mr = 50, wll = 0, wgi = 500, wr = 150, mll, mgi = 1000, army_count = 0, train_army_count = 0, power_army = 0, bll = 0, bwr = 100, bmr = 20;
        SoundPlayer player0 = new SoundPlayer(end_of_war.Properties.Resources.s1);//(@"end of war\end of war\Resources\s1.wav");
        SoundPlayer player1 = new SoundPlayer(end_of_war.Properties.Resources.s2);//(@"end of war\end of war\Resources\s2.wav");
        SoundPlayer player2 = new SoundPlayer(end_of_war.Properties.Resources.s3);//(@"end of war\end of war\Resources\s3.wav");
        SoundPlayer upgrade_sound = new SoundPlayer(end_of_war.Properties.Resources.effect_upgrade);
        public main_game()
        {
            InitializeComponent();
           // connetion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LORDEVIL\Documents\Visual Studio 2012\Projects\end of war\end of war\bin\Debug\DB_EndOfWar_game.accdb";
        }

        private void main_game_Load(object sender, EventArgs e)
        {           
         /*  try
            {
                connetion.Open();
                connectedToolStripMenuItem.Text = "Connected succsful!";
                connetion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr " + ex);
            }
           */

            Display_name.Text = res.Name;

            ///////////////////////////////////////////////////////////////////////

            gem_gen.Enabled = true;
            Random song = new Random();
            int number = song.Next(0, 3);
            switch (number)
            {
                case (0):
                    player0.Play();
                    break;
                case (1):
                    player1.Play();
                    break;
                case (2):
                    player2.Play();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            res.g++;





        }

        private void metal_gen_Tick(object sender, EventArgs e)
        {
            res.m++;
        }

        private void wood_gen_Tick(object sender, EventArgs e)
        {
            level_count.Text = res.level.ToString();
            res.w++;
            gem_count.Text = res.g.ToString();
            wood_count.Text = res.w.ToString();
            metal_count.Text = res.m.ToString();
            wood_label_count_level.Text = res.wll.ToString();
            metal_label_count_level.Text = res.mll.ToString();

            res.power_army = res.army_count * (res.bll * 10);
            your_power.Text = "your power : " + res.power_army.ToString();
            army_count_label.Text = res.army_count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (res.m >= res.mr)
            {
                upgrade_sound.Play();
                res.wll = res.wll + 1;
                res.wgi = res.wgi - 50;
                if (res.wgi <= 0)
                {
                    upgrade_wood.Enabled = false;
                    upgrade_wood.Visible = false;
                }
                else
                {
                    wood_gen.Interval = res.wgi;
                    res.m = res.m - res.mr;
                    res.mr = res.mr + 20;
                    metal_count.Text = res.m.ToString();
                    MessageBox.Show("upgrade compeletd.");
                }
            }
            else
            {
                MessageBox.Show(res.mr + " metal requid !");

            }

        }

        private void wood_label_count_level_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (res.w >= res.wr)
            {
                upgrade_sound.Play();
                res.mll = res.mll + 1;

                res.mgi = res.mgi - 50;
                if (res.mgi <= 0)
                {
                    upgrade_metal.Enabled = false;
                    upgrade_metal.Visible = false;
                }
                else
                {
                    metal_gen.Interval = res.mgi;
                    res.w = res.w - res.wr;
                    res.wr = res.wr + 20;
                    wood_count.Text = res.w.ToString();
                    MessageBox.Show("upgrade compeletd.");
                }
            }
            else
            {
                MessageBox.Show(res.wr + " wood requid !");

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mini_games mini_games = new mini_games();
            mini_games.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (res.w >= res.bwr && res.m >= res.bmr)
            {
                upgrade_sound.Play();
                MessageBox.Show("upgrade compeletd");
                res.w = res.w - res.bwr;
                res.m = res.m - res.bmr;
                res.bll = res.bll + 1;
                res.bwr = res.bwr * 2;
                res.bmr = res.bmr * 2;
                Barracks_label_level.Text = res.bll.ToString();

            }
            else
                MessageBox.Show(res.bwr + " wood and " + res.bmr + " metal requid !");
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            if ((res.w - (res.train_army_count * 10) > 0) && (res.m - (res.train_army_count * 15) > 0))
            {
                upgrade_sound.Play();
                MessageBox.Show("army is ready");
                res.w = res.w - (res.train_army_count * 10);
                res.m = res.m - (res.train_army_count * 15);
                metal_count.Text = res.m.ToString();
                wood_count.Text = res.w.ToString();
                res.army_count = res.army_count + res.train_army_count;
                army_count_label.Text = res.army_count.ToString();
            }
            else
            {
                MessageBox.Show("not enough wood or metal 10 wood and 15 metal for each");
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void train_army_count_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            train_army_count_label.Text = res.train_army_count.ToString();
            if (res.train_army_count > 0)
            { mines_army_train_count.Enabled = true; }


        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            if (res.train_army_count <= 0)
                mines_army_train_count.Enabled = false;

            else
            {
                res.train_army_count--;
                train_army_count_label.Text = res.train_army_count.ToString();

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random song = new Random();
            int number = song.Next(0, 3);
            switch (number)
            {
                case (0):
                    player0.Play();
                    break;
                case (1):
                    player1.Play();
                    break;
                case (2):
                    player2.Play();
                    break;




            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player0.Stop();
            player1.Stop();
            player2.Stop();
        }

        private void button1_Click_5(object sender, EventArgs e)
        {

            war war = new war();
            war.Show();
            war.your_power.Text = res.power_army.ToString();

        }

        private void your_power_Click(object sender, EventArgs e)
        {

        }

        private void plus_train_army_count_MouseDown(object sender, MouseEventArgs e)
        {
            res.train_army_count++;

        }
        //rise_metal_g
        private void button2_Click_2(object sender, EventArgs e)
        {

            if (res.g >= 5)
            {
                res.g = res.g - 5;
                res.m = res.m + 70;
            }
            else
                MessageBox.Show("You Need 5 Gem for this trade!");
        }
        //rise_wood_g
        private void rise_wood_g_Click(object sender, EventArgs e)
        {
            if (res.g >= 2)
            {
                res.g = res.g - 2;
                res.w = res.w + 50;
            }
            else
                MessageBox.Show("You Need 2 Gem for this trade!");
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            TradeFrm tradefrm = new TradeFrm();
            tradefrm.Show();

        }

        private void main_game_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void main_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            player0.Stop();
            player1.Stop();
            player2.Stop();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void connectedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}


