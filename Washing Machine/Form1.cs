using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Washing_Machine
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        int hours, mins, secs;

        private void WM_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GB_water_level.Visible = true;
            GB_water_temperature.Visible = true;
            GB_spin_speed.Visible = true;

            LB_washing_cycle.Visible = true;

            CB_delicate.Visible = true;
            CB_favourite.Visible = true;
            CB_heavyduty.Visible = true;
            CB_permanentpress.Visible = true;
            CB_regular.Visible = true;
            CB_wool.Visible = true;

            LB_timeH.Visible = true;
            LB_timeM.Visible = true;
            LB_timeS.Visible = true;
            LB_H.Visible = true;
            LB_M.Visible = true;
            LB_S.Visible = true;

            button_start.Visible = true;
            button_pause.Visible = true;

            dateTimePicker1.Visible = true;

            CB_reset.Visible = true;




        }

        private void CB_regular_Click(object sender, EventArgs e)
        {
            RB_waterlevel_automatic.Checked = true;
            RB_waterlevel_high.Enabled = false;
            RB_waterlevel_medium.Enabled = false;
            RB_waterlevel_low.Enabled = false;

            RB_watertemp_warm.Checked = true;
            RB_watertemp_hot.Enabled = false;
            RB_watertemp_cold.Enabled = false;

            RB_spinspeed_fast.Checked = true;
            RB_spinspeed_medium.Enabled = false;
            RB_spinspeed_slow.Enabled = false;

            LB_timeH.Text = "00";
            LB_timeM.Text = "12";
            LB_timeS.Text = "59";

        }

        private void CB_heavyduty_Click(object sender, EventArgs e)
        {
            RB_waterlevel_automatic.Checked = true;
            RB_waterlevel_high.Enabled = false;
            RB_waterlevel_medium.Enabled = false;
            RB_waterlevel_low.Enabled = false;

            RB_watertemp_hot.Checked = true;
            RB_watertemp_warm.Enabled = false;
            RB_watertemp_cold.Enabled = false;

            RB_spinspeed_fast.Checked = true;
            RB_spinspeed_medium.Enabled = false;
            RB_spinspeed_slow.Enabled = false;

            LB_timeH.Text = "00";
            LB_timeM.Text = "30";
            LB_timeS.Text = "59";
     
        }
      

        private void CB_delicate_Click(object sender, EventArgs e)
        {
            RB_waterlevel_automatic.Checked = true;
            RB_waterlevel_high.Enabled = false;
            RB_waterlevel_medium.Enabled = false;
            RB_waterlevel_low.Enabled = false;

            RB_watertemp_warm.Checked = true;
            RB_watertemp_hot.Enabled = false;
            RB_watertemp_cold.Enabled = false;

            RB_spinspeed_slow.Checked = true;
            RB_spinspeed_medium.Enabled = false;
            RB_spinspeed_fast.Enabled = false;

            LB_timeH.Text = "00";
            LB_timeM.Text = "06";
            LB_timeS.Text = "59";

        }

        private void CB_wool_Click(object sender, EventArgs e)
        {
            RB_waterlevel_automatic.Checked = true;
            RB_waterlevel_high.Enabled = false;
            RB_waterlevel_medium.Enabled = false;
            RB_waterlevel_low.Enabled = false;

            RB_watertemp_warm.Checked = true;
            RB_watertemp_hot.Enabled = false;
            RB_watertemp_cold.Enabled = false;

            RB_spinspeed_medium.Checked = true;
            RB_spinspeed_fast.Enabled = false;
            RB_spinspeed_slow.Enabled = false;

            LB_timeH.Text = "00";
            LB_timeM.Text = "08";
            LB_timeS.Text = "59";

        }

        private void CB_permanentpress_Click(object sender, EventArgs e)
        {
            RB_waterlevel_automatic.Checked = true;
            RB_waterlevel_high.Enabled = false;
            RB_waterlevel_medium.Enabled = false;
            RB_waterlevel_low.Enabled = false;

            RB_watertemp_warm.Checked = true;
            RB_watertemp_hot.Enabled = false;
            RB_watertemp_cold.Enabled = false;

            RB_spinspeed_slow.Checked = true;
            RB_spinspeed_medium.Enabled = false;
            RB_spinspeed_fast.Enabled = false;

            LB_timeH.Text = "00";
            LB_timeM.Text = "10";
            LB_timeS.Text = "59";
       

        }

        private void CB_favourite_Click(object sender, EventArgs e)
        {
            LB_timeH.Text = "00";
            LB_timeM.Text = "12";
            LB_timeS.Text = "59";

        }

        private void LB_washing_cycle_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void RB_waterlevel_automatic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RB_waterlevel_automatic.Checked = false;
            RB_waterlevel_high.Enabled = true;
            RB_waterlevel_medium.Enabled = true;
            RB_waterlevel_low.Enabled = true;
            RB_waterlevel_automatic.Enabled = true;

            RB_watertemp_hot.Checked = false;
            RB_watertemp_warm.Checked = false;
            RB_watertemp_cold.Enabled = true;
            RB_watertemp_hot.Enabled = true;
            RB_watertemp_warm.Enabled = true;

            RB_spinspeed_medium.Enabled = true;
            RB_spinspeed_medium.Checked = false;
            RB_spinspeed_fast.Enabled = true;
            RB_spinspeed_fast.Checked = false;
            RB_spinspeed_slow.Enabled = true;
            RB_spinspeed_slow.Checked = false;

            CB_delicate.Enabled = true;
            CB_favourite.Enabled = true;
            CB_heavyduty.Enabled = true;
            CB_permanentpress.Enabled = true;
            CB_regular.Enabled = true;
            CB_wool.Enabled = true;

            Animation.Visible = false;


        }

        private void CB_off_Click(object sender, EventArgs e)
        {
            GB_water_level.Visible = false;
            GB_water_temperature.Visible = false;
            GB_spin_speed.Visible = false;

            LB_washing_cycle.Visible = false;

            CB_delicate.Visible = false;
            CB_favourite.Visible = false;
            CB_heavyduty.Visible = false;
            CB_permanentpress.Visible = false;
            CB_regular.Visible = false;
            CB_wool.Visible = false;

            Animation.Visible = false;
            LB_timeH.Visible = false;
            LB_timeM.Visible = false;
            LB_timeS.Visible = false;
            LB_H.Visible = false;
            LB_M.Visible = false;
            LB_S.Visible = false;

            button_start.Visible = false;
            button_pause.Visible = false;

            dateTimePicker1.Visible = false;

            CB_reset.Visible = false;

            RB_waterlevel_high.Enabled = true;
            RB_waterlevel_medium.Enabled = true;
            RB_waterlevel_low.Enabled = true;
            RB_waterlevel_automatic.Enabled = true;

            RB_watertemp_hot.Checked = false;
            RB_watertemp_warm.Checked = false;
            RB_watertemp_cold.Enabled = true;
            RB_watertemp_hot.Enabled = true;
            RB_watertemp_warm.Enabled = true;

            RB_spinspeed_medium.Enabled = true;
            RB_spinspeed_medium.Checked = false;
            RB_spinspeed_fast.Enabled = true;
            RB_spinspeed_fast.Checked = false;
            RB_spinspeed_slow.Enabled = true;
            RB_spinspeed_slow.Checked = false;

            CB_delicate.Enabled = true;
            CB_favourite.Enabled = true;
            CB_heavyduty.Enabled = true;
            CB_permanentpress.Enabled = true;
            CB_regular.Enabled = true;
            CB_wool.Enabled = true;


        }

        

        private void Animation_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && mins == 0 && secs == 0)
            {
                timer1.Stop();
                MessageBox.Show(new form1() { TopMost = true }, "Times up!!!", "Will you press OK?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LB_timeH.Text = "00";
                LB_timeM.Text = "00";
                LB_timeS.Text = "00";
            }
            else
            {
                if (secs < 1)
                {
                    secs = 59;
                    if (mins < 1)
                    {
                        mins = 59;
                        if (hours != 0)
                            hours -= 1;
                    }
                    else mins -= 1;
                }
                else secs -= 1;
                if (hours > 1)
                    LB_timeH.Text = hours.ToString();
                else LB_timeH.Text = "0" + mins.ToString();
                if (mins > 1)
                    LB_timeM.Text = mins.ToString();
                else LB_timeM.Text = "0" + mins.ToString();
                if (secs > 1)
                    LB_timeS.Text = secs.ToString();
                else LB_timeS.Text = "0" + secs.ToString();
            }
                
        }

        private void H_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animation.Visible = true;
            Animation.Enabled = true;

            CB_regular.Enabled = false;
            CB_permanentpress.Enabled = false;
            CB_heavyduty.Enabled = false;
            CB_favourite.Enabled = false;
            CB_delicate.Enabled = false;
            CB_wool.Enabled = false;

            RB_spinspeed_fast.Enabled = false;
            RB_spinspeed_medium.Enabled = false;
            RB_spinspeed_slow.Enabled = false;
            RB_waterlevel_automatic.Enabled = false;
            RB_waterlevel_high.Enabled = false;
            RB_waterlevel_low.Enabled = false;
            RB_waterlevel_medium.Enabled = false;
            RB_watertemp_cold.Enabled = false;
            RB_watertemp_hot.Enabled = false;
            RB_watertemp_warm.Enabled = false;


            if (LB_timeH.Text =="  " || LB_timeM.Text =="  " || LB_timeS.Text =="  ")
            {
                MessageBox.Show("No Correct Input");
            }
            else
            {
                hours = int.Parse(LB_timeH.Text);
                mins = int.Parse(LB_timeM.Text);
                secs = int.Parse(LB_timeM.Text);
                timer1.Start();
            }
            timer1.Start();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Animation.Enabled = false;
        }
    }
}
