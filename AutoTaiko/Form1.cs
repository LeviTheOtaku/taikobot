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

namespace AutoTaiko
{
    public partial class Form1 : Form

       
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int typehitred = 1;
        int typehitblue = 1;

        private void Check_Tick(object sender, EventArgs e)
        {
            try
            {
                var x = Convert.ToInt32(xBox.Text);
                var y = Convert.ToInt32(yBox.Text);
                Rectangle rect = new Rectangle(x, y, 2, 2);
                Bitmap screenshot = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
                Graphics screenGraph = Graphics.FromImage(screenshot);
                screenGraph.CopyFromScreen(rect.Left, rect.Top, 0, 0, screenshot.Size, CopyPixelOperation.SourceCopy);


                screenshot.Save("Screenshot.png", System.Drawing.Imaging.ImageFormat.Png);

            Color target = screenshot.GetPixel(1, 1);
                screenshot.Dispose();
                screenGraph.Dispose();

                seenPanel.BackColor = target;

                if (target.R == 243)
                {
                    if (target.G == 71)
                    {
                        if (target.B == 40)
                        {
                            if (typehitred == 1)
                            {
                                Random rnd = new Random();

                                InputSimulator sim = new InputSimulator();
                                sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                                System.Threading.Thread.Sleep(rnd.Next(20, 26));
                                sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                                typehitred = 2;
                                lastHitPanel.BackColor = Color.FromArgb(255, 0, 0);
                            }
                            else
                            {
                                if (typehitred == 2)
                                {
                                    Random rnd = new Random();

                                    InputSimulator sim = new InputSimulator();
                                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                                    System.Threading.Thread.Sleep(rnd.Next(20, 26));
                                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                                    typehitred = 1;
                                    lastHitPanel.BackColor = Color.FromArgb(240, 100, 100);
                                }
                            }
                        }
                    }
                }
                if (target.R == 101)
                {
                    if (target.G == 189)
                    {
                        if (target.B == 187)
                        {
                            if (typehitblue == 1)
                            {
                                Random rnd = new Random();

                                InputSimulator sim = new InputSimulator();
                                sim.Keyboard.KeyDown(VirtualKeyCode.VK_D);
                                System.Threading.Thread.Sleep(rnd.Next(20, 26));
                                sim.Keyboard.KeyUp(VirtualKeyCode.VK_D);
                                typehitblue = 2;
                                lastHitPanel.BackColor = Color.FromArgb(0, 0, 255);
                            }
                            else
                            {
                                if (typehitblue == 2)
                                {
                                    Random rnd = new Random();

                                    InputSimulator sim = new InputSimulator();
                                    sim.Keyboard.KeyDown(VirtualKeyCode.VK_K);
                                    System.Threading.Thread.Sleep(rnd.Next(20, 26));
                                    sim.Keyboard.KeyUp(VirtualKeyCode.VK_K);
                                    typehitblue = 1;
                                    lastHitPanel.BackColor = Color.FromArgb(100, 100, 240);
                                }
                            }
                        }
                    }
                }
                if (target.R == 243)
                {
                    if (target.G == 181)
                    {
                        if (target.B == 0)
                        {
                            InputSimulator sim = new InputSimulator();
                            sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                            System.Threading.Thread.Sleep(7);
                            sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                            lastHitPanel.BackColor = Color.FromArgb(243, 181, 0);
                            sim.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                            System.Threading.Thread.Sleep(7);
                            sim.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                            lastHitPanel.BackColor = Color.FromArgb(233, 171, 0);
                        }
                    }
                }
                if (target.R == 248)
                {
                    if (target.G == 119)
                    {
                        if (target.B == 0)
                        {
                            InputSimulator sim = new InputSimulator();
                            sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                            System.Threading.Thread.Sleep(7);
                            sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                            lastHitPanel.BackColor = Color.FromArgb(248, 119, 0);
                            sim.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                            System.Threading.Thread.Sleep(7);
                            sim.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                            lastHitPanel.BackColor = Color.FromArgb(238, 109, 0);
                        }
                    }
                }

            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check.Start();
        }
    }
}
