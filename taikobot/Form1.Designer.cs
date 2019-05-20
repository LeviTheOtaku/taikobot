namespace AutoTaiko
{
    partial class taikobot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taikobot));
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.seenPanel = new System.Windows.Forms.Panel();
            this.lastHitPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Interval = 1;
            this.Check.Tick += new System.EventHandler(this.Check_Tick);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(12, 76);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // xBox
            // 
            this.xBox.BackColor = System.Drawing.Color.Black;
            this.xBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xBox.ForeColor = System.Drawing.Color.White;
            this.xBox.Location = new System.Drawing.Point(123, 15);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(56, 20);
            this.xBox.TabIndex = 2;
            this.xBox.Text = "566";
            // 
            // yBox
            // 
            this.yBox.BackColor = System.Drawing.Color.Black;
            this.yBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yBox.ForeColor = System.Drawing.Color.White;
            this.yBox.Location = new System.Drawing.Point(123, 41);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(56, 20);
            this.yBox.TabIndex = 3;
            this.yBox.Text = "437";
            // 
            // seenPanel
            // 
            this.seenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.seenPanel.Location = new System.Drawing.Point(154, 74);
            this.seenPanel.Name = "seenPanel";
            this.seenPanel.Size = new System.Drawing.Size(25, 25);
            this.seenPanel.TabIndex = 4;
            // 
            // lastHitPanel
            // 
            this.lastHitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lastHitPanel.Location = new System.Drawing.Point(185, 15);
            this.lastHitPanel.Name = "lastHitPanel";
            this.lastHitPanel.Size = new System.Drawing.Size(87, 84);
            this.lastHitPanel.TabIndex = 5;
            // 
            // taikobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lastHitPanel);
            this.Controls.Add(this.seenPanel);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "taikobot";
            this.Opacity = 0.7D;
            this.Text = "taikobot";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Check;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Panel seenPanel;
        private System.Windows.Forms.Panel lastHitPanel;
    }
}

