
namespace YoketoruVS21
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Beige;
            this.startButton.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(304, 178);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(192, 94);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(185, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(430, 82);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "よけとる2021";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.Location = new System.Drawing.Point(231, 394);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(338, 35);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright©2021 かねた";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(157, 35);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftLabel.Location = new System.Drawing.Point(698, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(94, 35);
            this.leftLabel.TabIndex = 4;
            this.leftLabel.Text = "💛:10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiLabel.Location = new System.Drawing.Point(278, 310);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(244, 35);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "HighScore 100";
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameoverLabel.Location = new System.Drawing.Point(196, 53);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(402, 82);
            this.gameoverLabel.TabIndex = 6;
            this.gameoverLabel.Text = "GameOver";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.Location = new System.Drawing.Point(294, 9);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(228, 82);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "Clear";
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.Color.Beige;
            this.titleButton.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleButton.Location = new System.Drawing.Point(366, 213);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(192, 94);
            this.titleButton.TabIndex = 8;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = false;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempLabel.Location = new System.Drawing.Point(56, 137);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(41, 42);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "★";
            this.tempLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tempLabel;
    }
}

