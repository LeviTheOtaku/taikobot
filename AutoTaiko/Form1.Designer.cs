namespace AutoTaiko
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
            this.Check = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(123, 15);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(56, 20);
            this.xBox.TabIndex = 2;
            this.xBox.Text = "570";
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(123, 41);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(56, 20);
            this.yBox.TabIndex = 3;
            this.yBox.Text = "433";
            // 
            // seenPanel
            // 
            this.seenPanel.Location = new System.Drawing.Point(154, 74);
            this.seenPanel.Name = "seenPanel";
            this.seenPanel.Size = new System.Drawing.Size(25, 25);
            this.seenPanel.TabIndex = 4;
            // 
            // lastHitPanel
            // 
            this.lastHitPanel.Location = new System.Drawing.Point(185, 15);
            this.lastHitPanel.Name = "lastHitPanel";
            this.lastHitPanel.Size = new System.Drawing.Size(87, 84);
            this.lastHitPanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.lastHitPanel);
            this.Controls.Add(this.seenPanel);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Check;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Panel seenPanel;
        private System.Windows.Forms.Panel lastHitPanel;
    }
}

