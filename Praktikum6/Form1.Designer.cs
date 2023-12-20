namespace Praktikum6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rock;
            pictureBox1.Location = new Point(173, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.paper;
            pictureBox2.Location = new Point(379, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.scissors;
            pictureBox3.Location = new Point(585, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 200);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.rock;
            pictureBox4.Location = new Point(173, 312);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 200);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 277);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 4;
            label1.Text = "Choose one:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.paper;
            pictureBox5.Location = new Point(379, 312);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 200);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.scissors;
            pictureBox6.Location = new Point(585, 312);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(200, 200);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 551);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 7;
            label2.Text = "Score:";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(0, 583);
            label3.Name = "label3";
            label3.Size = new Size(974, 146);
            label3.TabIndex = 8;
            label3.Text = "You 0 : 0 CPU";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 729);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label2;
        private Label label3;
    }
}
