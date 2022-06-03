namespace end_of_war
{
    partial class Flappy_Bird_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy_Bird_game));
            this.flappy_bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score_label = new System.Windows.Forms.Label();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipeDown2 = new System.Windows.Forms.PictureBox();
            this.Air = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // flappy_bird
            // 
            this.flappy_bird.Image = global::end_of_war.Properties.Resources.bird;
            this.flappy_bird.Location = new System.Drawing.Point(74, 104);
            this.flappy_bird.Name = "flappy_bird";
            this.flappy_bird.Size = new System.Drawing.Size(31, 29);
            this.flappy_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy_bird.TabIndex = 0;
            this.flappy_bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::end_of_war.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-37, 307);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(796, 114);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::end_of_war.Properties.Resources.pipedown;
            this.pipeDown.Location = new System.Drawing.Point(282, -63);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(37, 152);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.Image = global::end_of_war.Properties.Resources.pipe;
            this.pipe.Location = new System.Drawing.Point(325, 170);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(37, 156);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 4;
            this.pipe.TabStop = false;
            this.pipe.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.score_label.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.Location = new System.Drawing.Point(12, 346);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(160, 41);
            this.score_label.TabIndex = 5;
            this.score_label.Text = "score : 0";
            // 
            // pipe2
            // 
            this.pipe2.Image = global::end_of_war.Properties.Resources.pipe;
            this.pipe2.Location = new System.Drawing.Point(523, 199);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(37, 127);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 8;
            this.pipe2.TabStop = false;
            // 
            // pipeDown2
            // 
            this.pipeDown2.Image = global::end_of_war.Properties.Resources.pipedown;
            this.pipeDown2.Location = new System.Drawing.Point(483, -75);
            this.pipeDown2.Name = "pipeDown2";
            this.pipeDown2.Size = new System.Drawing.Size(37, 152);
            this.pipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown2.TabIndex = 9;
            this.pipeDown2.TabStop = false;
            // 
            // Air
            // 
            this.Air.Location = new System.Drawing.Point(-2, -23);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(278, 28);
            this.Air.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "START";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Speed
            // 
            this.Speed.Enabled = true;
            this.Speed.Interval = 5000;
            this.Speed.Tick += new System.EventHandler(this.Speed_Tick);
            // 
            // Flappy_Bird_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(563, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Air);
            this.Controls.Add(this.pipeDown2);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappy_bird);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flappy_Bird_game";
            this.Text = "Flappy_Bird_game";
            this.Load += new System.EventHandler(this.Flappy_Bird_game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappy_bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.PictureBox pipeDown2;
        private System.Windows.Forms.Label Air;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Speed;
    }
}