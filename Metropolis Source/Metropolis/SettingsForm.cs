using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metropolis
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SchemeEditor s = new SchemeEditor();

            foreach (var l in s.Controls.OfType<Label>())
            {
                l.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SchemeEditor.showInfrastructure = cbShowInfrastructure.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cbShowInfrastructure.Checked = !cbShowInfrastructure.Checked;
        }

        private void cbPlaySounds_CheckedChanged(object sender, EventArgs e)
        {
            SchemeEditor.playSounds = cbPlaySounds.Checked;
        }


        bool isMain = false;
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            isMain = true;
            try
            {
                this.BackColor = SchemeEditor.DefColor;
            }
            catch (Exception)
            {
            }
            cbShowInfrastructure.Checked = SchemeEditor.showInfrastructure;
            cbPlaySounds.Checked = SchemeEditor.playSounds;
            cbMyColor.Text = SchemeEditor.MyColor.Name;
            cbDefColor.Text = SchemeEditor.DefColor.Name;
            pSet.BackColor = SchemeEditor.MyColor;

            if (SchemeEditor.Lang == "En")
            {
                this.Text = "Settings";
                lblSet.Text = "Settings and customization";
                lblShowInfrastructure.Text = "Show information about infrastructure \nand routes in historical reference";
                cbPlaySounds.Text = "Play sounds in Quiz";
                lblMyColor.Text = "Main selection color:";
                lblDefColor.Text = "Additional selection color:";
                lblTime.Text = "Time to change photo on background:";
                lblQuizTime.Text = "Time for answer in Quiz:";
                List<string> source = new List<string>() { "Don't change background", "15 seconds", "30 seconds", "1 minute", "1.5 minutes", "2 minutes", "3 minutes" };
                cbTime.DataSource = source;
                source = new List<string>() { "Don't limit the time", "5 seconds", "10 seconds", "15 seconds", "20 seconds", "30 seconds", "1 minute" };
                cbQuiz.DataSource = source;
            }


            cbMyColor.Left = lblMyColor.Left + lblMyColor.Width;
            cbDefColor.Left = lblDefColor.Left + lblDefColor.Width;

            cbTime.Width = cbDefColor.Width + cbDefColor.Left - cbTime.Left;

            switch (SchemeEditor.timeForBack)
            {
                case 0:
                    cbTime.SelectedIndex = 0;
                    break;
                case 15:
                    cbTime.SelectedIndex = 1;
                    break;
                case 30:
                    cbTime.SelectedIndex = 2;
                    break;
                case 60:
                    cbTime.SelectedIndex = 3;
                    break;
                case 90:
                    cbTime.SelectedIndex = 4;
                    break;
                case 120:
                    cbTime.SelectedIndex = 5;
                    break;
                case 180:
                    cbTime.SelectedIndex = 6;
                    break;
                default:
                    cbTime.SelectedIndex = 2;
                    break;
            }

            switch (SchemeEditor.timeForQuestion)
            {
                case 0:
                    cbQuiz.SelectedIndex = 0;
                    break;
                case 5:
                    cbQuiz.SelectedIndex = 1;
                    break;
                case 10:
                    cbQuiz.SelectedIndex = 2;
                    break;
                case 15:
                    cbQuiz.SelectedIndex = 3;
                    break;
                case 20:
                    cbQuiz.SelectedIndex = 4;
                    break;
                case 30:
                    cbQuiz.SelectedIndex = 5;
                    break;
                case 60:
                    cbQuiz.SelectedIndex = 6;
                    break;
                default:
                    cbQuiz.SelectedIndex = 2;
                    break;
            }

            isMain = false;
        }

        private void cbMyColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchemeEditor.MyColor = Color.FromName(cbMyColor.SelectedItem.ToString());

            pSet.BackColor = SchemeEditor.MyColor;
        }

        private void cbDefColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchemeEditor.DefColor = Color.FromName(cbDefColor.SelectedItem.ToString());

            try
            {
                this.BackColor = SchemeEditor.DefColor;
            }
            catch (Exception)
            {
            }
            
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int t = 0;
            switch (cbTime.SelectedIndex)
            {
                case 0:
                    t = 0;
                    break;
                case 1:
                    t = 15;
                    break;
                case 2:
                    t = 30;
                    break;
                case 3:
                    t = 60;
                    break;
                case 4:
                    t = 90;
                    break;
                case 5:
                    t = 120;
                    break;
                case 6:
                    t = 180;
                    break;
                default: t = 30;
                    break;
            }


            if (!isMain)
                SchemeEditor.timeForBack = t;
            
        }

        private void cbQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int q = 0;

            switch (cbQuiz.SelectedIndex)
            {
                case 0:
                    q = 0;
                    break;
                case 1:
                    q = 5;
                    break;
                case 2:
                    q = 10;
                    break;
                case 3:
                    q = 15;
                    break;
                case 4:
                    q = 20;
                    break;
                case 5:
                    q = 30;
                    break;
                case 6:
                    q = 60;
                    break;
                default:
                    q = 15;
                    break;
            }

            if (!isMain)
                SchemeEditor.timeForQuestion = q;
        }
    }
}
