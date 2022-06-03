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
    public partial class sing_in : Form
    {
        public sing_in()
        {
            InitializeComponent();
        }

        private void name_confirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Enter a display name");
            else
            {
                this.Hide();
                res res = new res();
                res.Name = textBox1.Text;
                main_game main_game = new main_game();
                main_game.Show();              
               
                
                
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sing_in_Load(object sender, EventArgs e)
        {
           
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }
    }
}
