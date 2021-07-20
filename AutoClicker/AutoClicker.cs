using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public int intervals = 1000;
        public bool Clicks = false;
        public int MouseClicks = 0;
        public bool MouseRepeat = false;
        public int parsedValue;

        delegate void UpdateMouseCoordLabelsCallback(string xCoord, string yCoord);

        public AutoClicker()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }
        private void AutoClicker_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            AC.IsBackground = true;
            AC.Start();
            Thread BC = new Thread(keyboardd);
            BC.IsBackground = true;
            BC.Start();
            Thread mouseCoordinateLabelThread = new Thread(() => ContinuallyUpdateMouseCoordLabel());
            mouseCoordinateLabelThread.IsBackground = true;
            mouseCoordinateLabelThread.Start();
            Thread CC = new Thread(AutoRepeatClick);
            CC.IsBackground = true;
            CC.Start();
        }
        private void AutoClick()
        {
            while (true)
            {
                if (Clicks == true)
                {
                    mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    MouseClicks += 1;
                    Thread.Sleep(intervals);
                }
                Thread.Sleep(2);
            }
        }

        private void AutoRepeatClick()
        {
            while (true)
            {
                if (MouseRepeat)
                {
                    IEnumerable<string> strings = Enumerable.Repeat("I like programming.", int.Parse(RepeatNumber.Text) + 1);

                    foreach (String str in strings)
                    {
                        mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        Thread.Sleep(1);
                        mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                        MouseClicks += 1;
                        Thread.Sleep(intervals);
                    }
                    Start.Enabled = true;
                    Start.BackColor = Color.LawnGreen;
                    Stop.Enabled = false;
                    Stop.BackColor = Color.DarkRed;
                    this.Text = "AutoClicker - Off";
                    RepeatButton.Enabled = true;
                    InfinityButton.Enabled = true;
                    RepeatNumber.Enabled = true;
                    ButtonSelect.Enabled = true;
                    IntervalsBox.Enabled = true;
                    MouseClicks = 0;
                    MouseRepeat = false;
                }
            }
        }

        private void ContinuallyUpdateMouseCoordLabel(int precisionMilliseconds = 60)
        {
            while (true)
            {
                Thread.Sleep(precisionMilliseconds); //Update every 60 milliseconds

                UpdateMouseCoordLabelsCallback updateMouseCoordInvoker = new UpdateMouseCoordLabelsCallback(SetMouseCoordLabels);

                string currentXCoord = Cursor.Position.X.ToString();
                string currentYCoord = Cursor.Position.Y.ToString();

                try
                {
                    this.Invoke(updateMouseCoordInvoker, new object[] { currentXCoord, currentYCoord });
                }
                catch (Exception) { };
            }
        }

        private void SetMouseCoordLabels(string xPos, string yPos)
        {
            MouseX.Text = "Mouse X: " + xPos;
            MouseY.Text = "Mouse Y: " + yPos;
            ClicksLabel.Text = "Clicks: " + MouseClicks;
        }

        void keyboardd()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.F3) < 0)
                {
                    if (InfinityButton.Checked)
                    {
                        Clicks = false;
                        Start.Enabled = true;
                        Start.BackColor = Color.LawnGreen;
                        Stop.Enabled = false;
                        Stop.BackColor = Color.DarkRed;
                        this.Text = "AutoClicker - Off";
                        RepeatButton.Enabled = true;
                        InfinityButton.Enabled = true;
                        RepeatNumber.Enabled = true;
                        ButtonSelect.Enabled = true;
                        IntervalsBox.Enabled = true;
                        MouseClicks = 0;
                    }
                    else if (RepeatButton.Checked)
                    {
                    
                    }
                }
                else if (GetAsyncKeyState(Keys.F4) < 0)
                {
                    if (!int.TryParse(IntervalsBox.Text, out parsedValue))
                    {
                        MessageBox.Show("Please enter a valid intervals number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (int.Parse(IntervalsBox.Text) > 0)
                        {
                            if (InfinityButton.Checked)
                            {
                                intervals = int.Parse(IntervalsBox.Text);
                                Clicks = true;
                                Stop.Enabled = true;
                                Stop.BackColor = Color.Red;
                                Start.Enabled = false;
                                Start.BackColor = Color.DarkGreen;
                                this.Text = "AutoClicker - On";
                                RepeatButton.Enabled = false;
                                InfinityButton.Enabled = false;
                                RepeatNumber.Enabled = false;
                                ButtonSelect.Enabled = false;
                                IntervalsBox.Enabled = false;
                            }
                            else if (RepeatButton.Checked)
                            {
                                if (!int.TryParse(RepeatNumber.Text, out parsedValue))
                                {
                                    MessageBox.Show("Please enter a valid repeat number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (int.Parse(RepeatNumber.Text) > 0)
                                    {
                                        intervals = int.Parse(IntervalsBox.Text);
                                        Stop.Enabled = false;
                                        Stop.BackColor = Color.DarkRed;
                                        Start.Enabled = false;
                                        Start.BackColor = Color.DarkGreen;
                                        this.Text = "AutoClicker - On";
                                        RepeatButton.Enabled = false;
                                        InfinityButton.Enabled = false;
                                        RepeatNumber.Enabled = false;
                                        ButtonSelect.Enabled = false;
                                        IntervalsBox.Enabled = false;
                                        IEnumerable<string> strings = Enumerable.Repeat("I like programming.", int.Parse(RepeatNumber.Text) + 1);

                                        foreach (String str in strings)
                                        {
                                            mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                                            Thread.Sleep(1);
                                            mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                                            MouseClicks += 1;
                                            Thread.Sleep(intervals);
                                        }
                                        Start.Enabled = true;
                                        Start.BackColor = Color.LawnGreen;
                                        Stop.Enabled = false;
                                        Stop.BackColor = Color.DarkRed;
                                        this.Text = "AutoClicker - Off";
                                        RepeatButton.Enabled = true;
                                        InfinityButton.Enabled = true;
                                        RepeatNumber.Enabled = true;
                                        ButtonSelect.Enabled = true;
                                        IntervalsBox.Enabled = true;
                                        MouseClicks = 0;

                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a repeat number > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a intervals number > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(IntervalsBox.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a valid intervals number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(int.Parse(IntervalsBox.Text) > 0)
                {
                    if (InfinityButton.Checked)
                    {
                        intervals = int.Parse(IntervalsBox.Text);
                        Clicks = true;
                        Stop.Enabled = true;
                        Stop.BackColor = Color.Red;
                        Start.Enabled = false;
                        Start.BackColor = Color.DarkGreen;
                        this.Text = "AutoClicker - On";
                        RepeatButton.Enabled = false;
                        InfinityButton.Enabled = false;
                        RepeatNumber.Enabled = false;
                        ButtonSelect.Enabled = false;
                        IntervalsBox.Enabled = false;
                    }
                    else if (RepeatButton.Checked)
                    {
                        if (!int.TryParse(RepeatNumber.Text, out parsedValue))
                        {
                            MessageBox.Show("Please enter a valid repeat number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (int.Parse(RepeatNumber.Text) > 0)
                            {
                                intervals = int.Parse(IntervalsBox.Text);
                                Stop.Enabled = false;
                                Stop.BackColor = Color.DarkRed;
                                Start.Enabled = false;
                                Start.BackColor = Color.DarkGreen;
                                this.Text = "AutoClicker - On";
                                RepeatButton.Enabled = false;
                                InfinityButton.Enabled = false;
                                RepeatNumber.Enabled = false;
                                ButtonSelect.Enabled = false;
                                IntervalsBox.Enabled = false;
                                MouseRepeat = true;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a repeat number > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a intervals number > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (InfinityButton.Checked)
            {
                Clicks = false;
                Start.Enabled = true;
                Start.BackColor = Color.LawnGreen;
                Stop.Enabled = false;
                Stop.BackColor = Color.DarkRed;
                this.Text = "AutoClicker - Off";
                RepeatButton.Enabled = true;
                InfinityButton.Enabled = true;
                RepeatNumber.Enabled = true;
                ButtonSelect.Enabled = true;
                IntervalsBox.Enabled = true;
                MouseClicks = 0;
            }
            else if (RepeatButton.Checked)
            {
            
            }
        }
    }
}
