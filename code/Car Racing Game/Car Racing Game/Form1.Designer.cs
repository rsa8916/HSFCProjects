namespace Car_Racing_Game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trophy = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.exsplosion = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exsplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance:";
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.Location = new System.Drawing.Point(247, 447);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(38, 25);
            this.distance.TabIndex = 1;
            this.distance.Text = "00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(135, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "avoid other cars and get points\r\n\r\nuse left and right keys to move car";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.trophy);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.exsplosion);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 424);
            this.panel1.TabIndex = 4;
            // 
            // trophy
            // 
            this.trophy.Image = global::Car_Racing_Game.Properties.Resources.bronze;
            this.trophy.Location = new System.Drawing.Point(66, 157);
            this.trophy.Name = "trophy";
            this.trophy.Size = new System.Drawing.Size(250, 100);
            this.trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy.TabIndex = 9;
            this.trophy.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::Car_Racing_Game.Properties.Resources.carGrey;
            this.AI1.Location = new System.Drawing.Point(66, 19);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            // 
            // exsplosion
            // 
            this.exsplosion.BackColor = System.Drawing.Color.Transparent;
            this.exsplosion.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.exsplosion.Location = new System.Drawing.Point(153, 234);
            this.exsplosion.Name = "exsplosion";
            this.exsplosion.Size = new System.Drawing.Size(64, 64);
            this.exsplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exsplosion.TabIndex = 7;
            this.exsplosion.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::Car_Racing_Game.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(294, 85);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 6;
            this.AI2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.BackColor = System.Drawing.Color.Black;
            this.roadTrack1.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.roadTrack1.ImageLocation = "";
            this.roadTrack1.Location = new System.Drawing.Point(3, -637);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(385, 853);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 5;
            this.roadTrack1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(3, 222);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(385, 632);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 6;
            this.roadTrack2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Car_Racing_Game.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(137, 263);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 101);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 8;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exsplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox exsplosion;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox trophy;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.EventLog eventLog1;
    }
}

