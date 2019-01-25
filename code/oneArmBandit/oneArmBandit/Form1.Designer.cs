namespace oneArmBandit
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nudge1 = new System.Windows.Forms.Button();
            this.nudge3 = new System.Windows.Forms.Button();
            this.nudge2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Location = new System.Drawing.Point(54, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 246);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox2.Location = new System.Drawing.Point(292, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 246);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox3.Location = new System.Drawing.Point(530, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 246);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(339, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Spin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudge1
            // 
            this.nudge1.BackColor = System.Drawing.Color.Beige;
            this.nudge1.Location = new System.Drawing.Point(106, 61);
            this.nudge1.Name = "nudge1";
            this.nudge1.Size = new System.Drawing.Size(120, 23);
            this.nudge1.TabIndex = 5;
            this.nudge1.Text = "NUDGE";
            this.nudge1.UseVisualStyleBackColor = false;
            this.nudge1.Click += new System.EventHandler(this.nudge1_Click);
            // 
            // nudge3
            // 
            this.nudge3.BackColor = System.Drawing.Color.Beige;
            this.nudge3.Location = new System.Drawing.Point(600, 61);
            this.nudge3.Name = "nudge3";
            this.nudge3.Size = new System.Drawing.Size(110, 23);
            this.nudge3.TabIndex = 6;
            this.nudge3.Text = "NUDGE";
            this.nudge3.UseVisualStyleBackColor = false;
            this.nudge3.Click += new System.EventHandler(this.nudge3_Click);
            // 
            // nudge2
            // 
            this.nudge2.BackColor = System.Drawing.Color.Beige;
            this.nudge2.Location = new System.Drawing.Point(352, 61);
            this.nudge2.Name = "nudge2";
            this.nudge2.Size = new System.Drawing.Size(128, 23);
            this.nudge2.TabIndex = 7;
            this.nudge2.Text = "NUDGE";
            this.nudge2.UseVisualStyleBackColor = false;
            this.nudge2.Click += new System.EventHandler(this.nudge2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudge2);
            this.Controls.Add(this.nudge3);
            this.Controls.Add(this.nudge1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nudge1;
        private System.Windows.Forms.Button nudge3;
        private System.Windows.Forms.Button nudge2;
    }
}

