
namespace Mousetracker
{
    partial class MouseTracker
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
            System.Windows.Forms.Button ButAbout;
            this.label3 = new System.Windows.Forms.Label();
            this.TargX = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.Label();
            this.Scorel = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.TargY = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ButAbout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.Visible = false;
            // 
            // TargX
            // 
            this.TargX.AutoSize = true;
            this.TargX.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargX.Location = new System.Drawing.Point(141, 50);
            this.TargX.Name = "TargX";
            this.TargX.Size = new System.Drawing.Size(72, 25);
            this.TargX.TabIndex = 0;
            this.TargX.Text = "0000";
            this.TargX.Visible = false;
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target.Location = new System.Drawing.Point(140, 25);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(82, 25);
            this.Target.TabIndex = 0;
            this.Target.Text = "Target";
            this.Target.Visible = false;
            // 
            // Scorel
            // 
            this.Scorel.AutoSize = true;
            this.Scorel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorel.Location = new System.Drawing.Point(231, 50);
            this.Scorel.Name = "Scorel";
            this.Scorel.Size = new System.Drawing.Size(72, 25);
            this.Scorel.TabIndex = 0;
            this.Scorel.Text = "0000";
            this.Scorel.Visible = false;
            this.Scorel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.Location = new System.Drawing.Point(231, 25);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(73, 25);
            this.Score2.TabIndex = 0;
            this.Score2.Text = "Score";
            this.Score2.Visible = false;
            // 
            // TargY
            // 
            this.TargY.AutoSize = true;
            this.TargY.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargY.Location = new System.Drawing.Point(141, 72);
            this.TargY.Name = "TargY";
            this.TargY.Size = new System.Drawing.Size(72, 25);
            this.TargY.TabIndex = 0;
            this.TargY.Text = "0000";
            this.TargY.Visible = false;
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(82, 53);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(143, 44);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "Start tracking";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // ButAbout
            // 
            ButAbout.Location = new System.Drawing.Point(3, 124);
            ButAbout.Name = "ButAbout";
            ButAbout.Size = new System.Drawing.Size(44, 23);
            ButAbout.TabIndex = 2;
            ButAbout.Text = "About";
            ButAbout.UseVisualStyleBackColor = true;
            ButAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButAbout_MouseClick);
            // 
            // GameButton
            // 
            this.GameButton.Location = new System.Drawing.Point(264, 126);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(46, 23);
            this.GameButton.TabIndex = 3;
            this.GameButton.Text = "Game";
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Visible = false;
            this.GameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(3, 3);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(46, 23);
            this.EndButton.TabIndex = 4;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Visible = false;
            this.EndButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.EndButton);
            this.panel1.Controls.Add(this.GameButton);
            this.panel1.Controls.Add(ButAbout);
            this.panel1.Controls.Add(this.buttonstart);
            this.panel1.Controls.Add(this.TargY);
            this.panel1.Controls.Add(this.Score2);
            this.panel1.Controls.Add(this.Scorel);
            this.panel1.Controls.Add(this.Target);
            this.panel1.Controls.Add(this.TargX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 152);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(113, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(313, 69);
            this.vScrollBar1.Minimum = 5;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Value = 20;
            this.vScrollBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Difficulty tweak";
            this.label1.Visible = false;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hard";
            this.label2.Visible = false;
            // 
            // MouseTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 152);
            this.Controls.Add(this.panel1);
            this.Name = "MouseTracker";
            this.Text = "MouseTracking";
            this.Load += new System.EventHandler(this.MouseTracker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TargX;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Label Scorel;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label TargY;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label label2;
    }
}

