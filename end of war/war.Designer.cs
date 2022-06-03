namespace end_of_war
{
    partial class war
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(war));
            this.rohan_pic = new System.Windows.Forms.PictureBox();
            this.enemy_pic = new System.Windows.Forms.PictureBox();
            this.happeness = new System.Windows.Forms.Label();
            this.your_power = new System.Windows.Forms.Label();
            this.war_timer = new System.Windows.Forms.Timer(this.components);
            this.enemy_power_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_battle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rohan_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // rohan_pic
            // 
            this.rohan_pic.Location = new System.Drawing.Point(77, 57);
            this.rohan_pic.Name = "rohan_pic";
            this.rohan_pic.Size = new System.Drawing.Size(499, 363);
            this.rohan_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rohan_pic.TabIndex = 0;
            this.rohan_pic.TabStop = false;
            this.rohan_pic.Click += new System.EventHandler(this.rohan_pic_Click);
            // 
            // enemy_pic
            // 
            this.enemy_pic.Location = new System.Drawing.Point(935, 57);
            this.enemy_pic.Name = "enemy_pic";
            this.enemy_pic.Size = new System.Drawing.Size(499, 363);
            this.enemy_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_pic.TabIndex = 1;
            this.enemy_pic.TabStop = false;
            // 
            // happeness
            // 
            this.happeness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.happeness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.happeness.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happeness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.happeness.Location = new System.Drawing.Point(220, 423);
            this.happeness.Name = "happeness";
            this.happeness.Size = new System.Drawing.Size(174, 32);
            this.happeness.TabIndex = 16;
            this.happeness.Text = "your power :";
            this.happeness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // your_power
            // 
            this.your_power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.your_power.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.your_power.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.your_power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.your_power.Location = new System.Drawing.Point(239, 464);
            this.your_power.Name = "your_power";
            this.your_power.Size = new System.Drawing.Size(124, 32);
            this.your_power.TabIndex = 17;
            this.your_power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // war_timer
            // 
            this.war_timer.Enabled = true;
            this.war_timer.Tick += new System.EventHandler(this.war_timer_Tick);
            // 
            // enemy_power_count
            // 
            this.enemy_power_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.enemy_power_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enemy_power_count.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy_power_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enemy_power_count.Location = new System.Drawing.Point(1119, 464);
            this.enemy_power_count.Name = "enemy_power_count";
            this.enemy_power_count.Size = new System.Drawing.Size(124, 32);
            this.enemy_power_count.TabIndex = 19;
            this.enemy_power_count.Text = "1000";
            this.enemy_power_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1100, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "enemy power";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_battle
            // 
            this.start_battle.BackgroundImage = global::end_of_war.Properties.Resources.box1;
            this.start_battle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_battle.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_battle.ForeColor = System.Drawing.Color.Green;
            this.start_battle.Location = new System.Drawing.Point(553, 480);
            this.start_battle.Name = "start_battle";
            this.start_battle.Size = new System.Drawing.Size(405, 121);
            this.start_battle.TabIndex = 20;
            this.start_battle.Text = "Start Battle";
            this.start_battle.UseVisualStyleBackColor = true;
            this.start_battle.Click += new System.EventHandler(this.start_battle_Click);
            // 
            // war
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::end_of_war.Properties.Resources.war1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1517, 613);
            this.Controls.Add(this.start_battle);
            this.Controls.Add(this.enemy_power_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.your_power);
            this.Controls.Add(this.happeness);
            this.Controls.Add(this.enemy_pic);
            this.Controls.Add(this.rohan_pic);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "war";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "war";
            this.Load += new System.EventHandler(this.war_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rohan_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label happeness;
        public System.Windows.Forms.Timer war_timer;
        public System.Windows.Forms.Label your_power;
        public System.Windows.Forms.Label enemy_power_count;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button start_battle;
        public System.Windows.Forms.PictureBox rohan_pic;
        public System.Windows.Forms.PictureBox enemy_pic;
    }
}