using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace end_of_war
{
    class res
    {
        public static int
            g = 0,//Gem
            mr = 50,//Metal required
            wll = 0,//wood label level
            wgi = 500,//wood generate intrval
            wr = 150,// wood required
            mll = 0,//metal lable level
            mgi = 1000,// metal generate intrval
            train_army_count = 0,//<------
            level = 0,//player Level
            bll = 0,//barracks label level
            bwr = 100,//barracks wood required
            bmr = 20,//barracks metal required
            rohan_power = 0,
            TradeCount = 0,
            TradeGemCount = 0,
            metal_trade_req = 100;
        public static bool e1 = true, e2 = false, e3 = false, e4 = false, e5 = false, e6 = false, e7 = false, e8 = false, e9 = false, e10 = false;
        public static System.Drawing.Bitmap Image1r = end_of_war.Properties.Resources._111;
        public static System.Drawing.Bitmap Image2e = end_of_war.Properties.Resources._1;
        public static int rp = 11, ep = 1;
        public static long
                           w = 0,//wood
                           m = 0,//metal
                           power_army = 999999,//player power army
                           enemy_power = 950,//enemy power army
                           army_count = 999999;//player army count
        private static string _name; // private player user name 

        public static string Name // property user name
        {
            get 
            {
                return _name; // read user name
            }
            set // write player user name
            {
                value = value.Trim(); // trim value 
                _name = value; // 
                
                
            }

        }

    }
}
