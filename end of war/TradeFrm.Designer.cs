namespace end_of_war
{
    partial class TradeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeFrm));
            this.plus_trade_count = new System.Windows.Forms.Button();
            this.mines_trade_count = new System.Windows.Forms.Button();
            this.trade_count_label = new System.Windows.Forms.Label();
            this.training_army = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rise_wood_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trade_timer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus_trade_count
            // 
            this.plus_trade_count.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.plus_trade_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_trade_count.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_trade_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.plus_trade_count.Location = new System.Drawing.Point(124, 58);
            this.plus_trade_count.Name = "plus_trade_count";
            this.plus_trade_count.Size = new System.Drawing.Size(28, 34);
            this.plus_trade_count.TabIndex = 42;
            this.plus_trade_count.Text = "+";
            this.plus_trade_count.UseVisualStyleBackColor = true;
            this.plus_trade_count.Click += new System.EventHandler(this.plus_trade_count_Click);
            // 
            // mines_trade_count
            // 
            this.mines_trade_count.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.mines_trade_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mines_trade_count.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mines_trade_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mines_trade_count.Location = new System.Drawing.Point(31, 58);
            this.mines_trade_count.Name = "mines_trade_count";
            this.mines_trade_count.Size = new System.Drawing.Size(26, 34);
            this.mines_trade_count.TabIndex = 41;
            this.mines_trade_count.Text = "-";
            this.mines_trade_count.UseVisualStyleBackColor = true;
            this.mines_trade_count.Click += new System.EventHandler(this.mines_trade_count_Click);
            // 
            // trade_count_label
            // 
            this.trade_count_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.trade_count_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trade_count_label.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trade_count_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trade_count_label.Location = new System.Drawing.Point(66, 62);
            this.trade_count_label.Name = "trade_count_label";
            this.trade_count_label.Size = new System.Drawing.Size(52, 26);
            this.trade_count_label.TabIndex = 40;
            this.trade_count_label.Text = "0";
            this.trade_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // training_army
            // 
            this.training_army.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.training_army.Cursor = System.Windows.Forms.Cursors.Hand;
            this.training_army.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.training_army.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.training_army.Location = new System.Drawing.Point(13, 12);
            this.training_army.Name = "training_army";
            this.training_army.Size = new System.Drawing.Size(161, 47);
            this.training_army.TabIndex = 39;
            this.training_army.Text = "how many trade?";
            this.training_army.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(54, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 43;
            this.button1.Text = "metal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rise_wood_btn
            // 
            this.rise_wood_btn.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.rise_wood_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rise_wood_btn.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rise_wood_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rise_wood_btn.Location = new System.Drawing.Point(54, 109);
            this.rise_wood_btn.Name = "rise_wood_btn";
            this.rise_wood_btn.Size = new System.Drawing.Size(74, 27);
            this.rise_wood_btn.TabIndex = 44;
            this.rise_wood_btn.Text = "wood";
            this.rise_wood_btn.UseVisualStyleBackColor = true;
            this.rise_wood_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(54, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 27);
            this.button3.TabIndex = 45;
            this.button3.Text = "Army";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trade_timer
            // 
            this.trade_timer.Enabled = true;
            this.trade_timer.Interval = 1;
            this.trade_timer.Tick += new System.EventHandler(this.trade_timer_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::end_of_war.Properties.Resources.box;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(54, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 32);
            this.button2.TabIndex = 46;
            this.button2.Text = "Gem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TradeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::end_of_war.Properties.Resources.fqd1;
            this.ClientSize = new System.Drawing.Size(183, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rise_wood_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plus_trade_count);
            this.Controls.Add(this.mines_trade_count);
            this.Controls.Add(this.trade_count_label);
            this.Controls.Add(this.training_army);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TradeFrm";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TradeFrm";
            this.Load += new System.EventHandler(this.TradeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plus_trade_count;
        private System.Windows.Forms.Button mines_trade_count;
        private System.Windows.Forms.Label trade_count_label;
        private System.Windows.Forms.Button training_army;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rise_wood_btn;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Timer trade_timer;
        private System.Windows.Forms.Button button2;
    }
}