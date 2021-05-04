using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagementSystem.Tools
{
    public partial class StopWatch : Form
    {
        private int seconds;
        private int minutes;
        private int hours;
        private int miliseconds;
        private bool displaySettingsPanel =true;

        public StopWatch()
        {
            InitializeComponent();
            miliseconds = seconds = minutes = hours = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miliseconds++;

            if (miliseconds > 9)
            {
                seconds++;
                miliseconds = 0;
            }

            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }

            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }

            ChangeLabels();

        }

        private void ChangeLabels()
        {
            lblHours.Text = Change(hours);
            lblMinutes.Text = Change(minutes);
            lblSeconds.Text = Change(seconds);
            lblmiliseconds.Text = Change(miliseconds);
        }

        private string Change(int value)
        {
            if (value < 10)//0 to 9
                return "0" + value;
            else
                return value.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ResetWatch();
            timer1.Stop();
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void ResetWatch()
        {
            miliseconds = seconds = minutes = hours = 0;
            ChangeLabels();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (displaySettingsPanel)
            {
                settingsPanel.Visible = true;
                displaySettingsPanel = false;
            }
            else
            {
                settingsPanel.Visible = false;
                displaySettingsPanel = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(txtStartingHours.Text);
            minutes = Convert.ToInt32(txtStartingMinutes.Text);
            seconds = Convert.ToInt32(txtStartingSeconds.Text);

            lblHours.Text = Change(hours);
            lblMinutes.Text = Change(minutes);
            lblSeconds.Text = Change(seconds);
          
        }
    }
}
