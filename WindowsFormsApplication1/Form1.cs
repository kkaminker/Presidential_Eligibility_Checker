using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_checkEligible_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtbx_age.Text);
            int yearsResided = int.Parse(txtbx_yearsResided.Text);
            int timesElected = int.Parse(txtbx_timesElected.Text);
            Boolean convicted;
            if (chkbx_convicted.Checked)
            {
                convicted = true;
            }
            else convicted = false;

            Boolean usBorn;
            if (chkbx_usBorn.Checked)
            {
                usBorn = true;
            }
            else usBorn = false;

            Classes.EligibilityChecker check = new Classes.EligibilityChecker(age, usBorn, yearsResided, timesElected, convicted);
            if (check.isEligible())
            {
                bttn_checkEligible.Text = "You are presidentially eligible!";
                bttn_checkEligible.Size = new System.Drawing.Size(150,41);
                bttn_checkEligible.Location=new System.Drawing.Point(62, 208);
                bttn_checkEligible.BackColor = Color.LightBlue;
            }
            else
            {
                bttn_checkEligible.Text = "Sorry, you are ineligible.";
                bttn_checkEligible.BackColor = Color.FromArgb(255, 0, 0);
            }
        }
    }
}
