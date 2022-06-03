namespace end_of_war
{
    partial class sing_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sing_in));
            this.name_confirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_confirm
            // 
            this.name_confirm.Location = new System.Drawing.Point(23, 116);
            this.name_confirm.Name = "name_confirm";
            this.name_confirm.Size = new System.Drawing.Size(278, 23);
            this.name_confirm.TabIndex = 5;
            this.name_confirm.Text = "confirm";
            this.name_confirm.UseVisualStyleBackColor = true;
            this.name_confirm.Click += new System.EventHandler(this.name_confirm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 65);
            this.textBox1.MaxLength = 15;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 35);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.NavajoWhite;
            this.user.Location = new System.Drawing.Point(307, 49);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 51);
            this.user.TabIndex = 3;
            this.user.Text = "Enter a Display Name";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sing_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 204);
            this.Controls.Add(this.name_confirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sing_in";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sing in ";
            this.Load += new System.EventHandler(this.sing_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button name_confirm;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label user;
    }
}

