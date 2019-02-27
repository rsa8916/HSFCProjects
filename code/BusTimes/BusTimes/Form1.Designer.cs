namespace BusTimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.Town = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.earliestTime = new System.Windows.Forms.TextBox();
            this.latestTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUS TIMES";
            // 
            // Town
            // 
            this.Town.Location = new System.Drawing.Point(389, 151);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(100, 20);
            this.Town.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please enter town you are traveling to?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please entr your earliest time you would be willing to catch a bus?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please enter your latest time you would be willing to catch a bus?";
            // 
            // earliestTime
            // 
            this.earliestTime.Location = new System.Drawing.Point(389, 196);
            this.earliestTime.Name = "earliestTime";
            this.earliestTime.Size = new System.Drawing.Size(100, 20);
            this.earliestTime.TabIndex = 5;
            // 
            // latestTime
            // 
            this.latestTime.Location = new System.Drawing.Point(389, 243);
            this.latestTime.Name = "latestTime";
            this.latestTime.Size = new System.Drawing.Size(100, 20);
            this.latestTime.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.latestTime);
            this.Controls.Add(this.earliestTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Town);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Town;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox earliestTime;
        private System.Windows.Forms.TextBox latestTime;
    }
}

