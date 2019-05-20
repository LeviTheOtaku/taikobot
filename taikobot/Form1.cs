using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace taikobot
{
    public partial class taikobot : Form

       
    {
        public taikobot()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(KeyDownHandler);
        }

        //CO-ORDINATES CONTROL
        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                xBox.Text = System.Windows.Forms.Cursor.Position.X.ToString();
                yBox.Text = System.Windows.Forms.Cursor.Position.Y.ToString();
            }

            if (e.KeyCode.ToString() == "NumPad8")
            {
                yBox.Text = (Convert.ToInt32(yBox.Text) + 1).ToString();
            }
            if (e.KeyCode.ToString() == "NumPad5")
            {
                yBox.Text = (Convert.ToInt32(yBox.Text) - 1).ToString();
            }

            if (e.KeyCode.ToString() == "NumPad6")
            {
                xBox.Text = (Convert.ToInt32(xBox.Text) + 1).ToString();
            }
            if (e.KeyCode.ToString() == "NumPad4")
            {
                xBox.Text = (Convert.ToInt32(xBox.Text) - 1).ToString();
            }
        }

        //GLOBAL VALUES
        int typehitred = 1;
        int typehitblue = 1;

        //KEYPRESS FUNCTION
        public async void CustomKeyPress(VirtualKeyCode vk, int wait1, int wait2)
        {
            Random rnd = new Random();
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyDown(vk);
            await Task.Delay(rnd.Next(wait1, wait2));
            sim.Keyboard.KeyUp(vk);
        }

        //GRABBING PIXEL FUNCTION
        static Color GetPixelColor(int xPixel, int yPixel)
        {
            try
            {
                var x = Convert.ToInt32(xPixel);
                var y = Convert.ToInt32(yPixel);
                Rectangle rect = new Rectangle(x, y, 1, 1);
                Bitmap screenshot = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
                Graphics screenGraph = Graphics.FromImage(screenshot);
                screenGraph.CopyFromScreen(rect.Left, rect.Top, 0, 0, screenshot.Size, CopyPixelOperation.SourceCopy);

                Color target = screenshot.GetPixel(0, 0);
                screenshot.Dispose();
                screenGraph.Dispose();

                return target;
            }
            catch
            {
                Color target = Color.FromArgb(0, 0, 0);
                return target;
            }
        }

        //MAIN FUNCTION
        private void Check_Tick(object sender, EventArgs e)
        {
                Color target = GetPixelColor(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text));
                seenPanel.BackColor = target;

                // RED ONES!
                if (target.R == 243 && target.G == 71 && target.B == 40)
                {
                    if (typehitred == 1)
                    {
                        CustomKeyPress(VirtualKeyCode.VK_F, 20, 26);
                        typehitred = 2;
                        lastHitPanel.BackColor = Color.FromArgb(243, 71, 40);

                    }
                    else
                    {
                        if (typehitred == 2)
                        {
                            CustomKeyPress(VirtualKeyCode.VK_J, 20, 26);
                            typehitred = 1;
                            lastHitPanel.BackColor = Color.FromArgb(233, 61, 30);
                        }
                    }
                }

                
                // BLUE ONES
                if (target.R == 101 && target.G == 189 && target.B == 187)
                {
                    if (typehitblue == 1)
                    {
                        CustomKeyPress(VirtualKeyCode.VK_D, 20, 26);
                        typehitblue = 2;
                        lastHitPanel.BackColor = Color.FromArgb(101, 189, 187);
                    }
                    else
                    {
                        if (typehitblue == 2)
                        {
                            CustomKeyPress(VirtualKeyCode.VK_K, 20, 26);
                            typehitblue = 1;
                            lastHitPanel.BackColor = Color.FromArgb(91, 179, 177);
                        }
                    }
                }
                
                //BALLOON/DRUMROLL
                if (target.R == 243 && target.G == 181 && target.B == 0)
                {
                    CustomKeyPress(VirtualKeyCode.VK_F, 7, 13);
                    CustomKeyPress(VirtualKeyCode.VK_J, 7, 13);
                    lastHitPanel.BackColor = Color.FromArgb(243, 181, 0);
                }

                //BALLOON/DRUMROLL
                if (target.R == 248 && target.G == 119 && target.B == 0)
                {
                    CustomKeyPress(VirtualKeyCode.VK_F, 7, 13);
                    CustomKeyPress(VirtualKeyCode.VK_J, 7, 13);
                    lastHitPanel.BackColor = Color.FromArgb(248, 119, 0);
                }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Check.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Check.Stop();
        }
    }

}
