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
    public partial class TradeFrm : Form
    {
        public TradeFrm()
        {
            InitializeComponent();
        }

        private void plus_trade_count_Click(object sender, EventArgs e)
        {
            res.TradeCount++;
            trade_count_label.Text = res.TradeCount.ToString();
            if (res.TradeCount > 0)
                mines_trade_count.Enabled = true;
           

        }

        private void mines_trade_count_Click(object sender, EventArgs e)
        {
            if (res.TradeCount <= 0)
                mines_trade_count.Enabled = false;
            if (res.TradeCount > 0)
            {
                res.TradeCount--;
                trade_count_label.Text = res.TradeCount.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            //trade wood
            if (res.TradeCount > 0)
            {
                res.TradeGemCount = res.TradeCount * 2;
                if (res.g >= res.TradeGemCount)
                {
                    res.g = res.g - res.TradeGemCount;
                    res.w = res.w + (res.TradeCount * 50);
                    MessageBox.Show("Trade completed!");
                }
                else
                    MessageBox.Show("Not enough Gem! 2 gem Need for each trade!");

                res.TradeGemCount = default(int);
            }
            else
                MessageBox.Show("Enter a valid Number");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //trade metal
            if (res.TradeCount > 0)
            {
                res.TradeGemCount = res.TradeCount * 5;
                if (res.g >= res.TradeGemCount)
                {
                    res.g = res.g - res.TradeGemCount;
                    res.m = res.m + (res.TradeCount * 70);
                    MessageBox.Show("Trade completed!");
                }
                else
                    MessageBox.Show("Not enough Gem! 5 gem Need for each trade!");

                res.TradeGemCount = default(int);
            }
            else
                MessageBox.Show("Enter a valid Number");
        }

        private void trade_timer_Tick(object sender, EventArgs e)
        {
            trade_count_label.Text = res.TradeCount.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //trade metal
            if (res.TradeCount > 0)
            {
                res.TradeGemCount = res.TradeCount * 10;
                if (res.g >= res.TradeGemCount)
                {
                    res.g = res.g - res.TradeGemCount;
                    res.army_count = res.army_count + (res.TradeCount * 10);
                    MessageBox.Show("Trade completed!");
                }
                else
                    MessageBox.Show("Not enough Gem! 10 gem Need for each trade!");

                res.TradeGemCount = default(int);
            }
            else
                MessageBox.Show("Enter a valid Number");
        }

        private void TradeFrm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //trade Gem
            if (res.TradeCount > 0)
            {
                res.metal_trade_req = res.TradeCount * 100;
                if (res.m >= res.metal_trade_req)
                {
                    res.g = res.g + res.TradeCount;
                    res.m = res.m - res.metal_trade_req;
                    
                    MessageBox.Show("Trade completed!");
                }
                else
                    MessageBox.Show("Not enough Metal! 100 Metal Need for each trade!");

                res.TradeGemCount = default(int);
            }
            else
                MessageBox.Show("Enter a valid Number");
        }
    }
}
