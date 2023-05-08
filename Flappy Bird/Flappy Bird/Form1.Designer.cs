
namespace Flappy_Bird
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.Label();
            this.quit_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu.BackgroundImage = global::Flappy_Bird.Properties.Resources.background;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.txtScore);
            this.menu.Controls.Add(this.quit_button);
            this.menu.Controls.Add(this.start_button);
            this.menu.Controls.Add(this.title);
            this.menu.Location = new System.Drawing.Point(-31, -17);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(696, 611);
            this.menu.TabIndex = 4;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Enabled = false;
            this.txtScore.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtScore.Location = new System.Drawing.Point(29, 190);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(648, 47);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: ";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Visible = false;
            // 
            // quit_button
            // 
            this.quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_button.Location = new System.Drawing.Point(278, 386);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(141, 61);
            this.quit_button.TabIndex = 2;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(278, 276);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(141, 61);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.title.Location = new System.Drawing.Point(162, 79);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(383, 87);
            this.title.TabIndex = 0;
            this.title.Text = "Flappy Bird";
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-18, 483);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(683, 88);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeUp.Location = new System.Drawing.Point(678, 319);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(84, 184);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 2;
            this.pipeUp.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeDown.Location = new System.Drawing.Point(360, -46);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(84, 195);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 1;
            this.pipeDown.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(22, 170);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(63, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 561);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label txtScore;
    }
}

