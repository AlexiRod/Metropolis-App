using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metropolis
{
    public partial class QuizForm : Form
    {
        public QuizForm()
        {
            InitializeComponent();
        }

        int time = 0;
        int questTime = SchemeEditor.timeForQuestion;
        List<Image> back = new List<Image>();
        List<int> questions = new List<int>();

        private void QuizForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (SchemeEditor.Lang == "Ru")
            {

                lblTime.Text = "Оставшееся время на ответ: " + questTime;
                lblCorrect.Text = "Правильных ответов: " + SchemeEditor.rightAnswers;
                lblWrong.Text = "Неправильных ответов: " + SchemeEditor.wrongAnswers;
                btnNext.Text = "Следующий";
            }
            else
            {
                lblTime.Text = "Time for answer: " + questTime;
                lblCorrect.Text = "Right answers: " + SchemeEditor.rightAnswers;
                lblWrong.Text = "Wrong answers: " + SchemeEditor.wrongAnswers;
                btnNext.Text = "Next";
            }

            if (questTime == 0)
            {
                if (SchemeEditor.Lang == "Ru")
                    lblTime.Text = "Оставшееся время на ответ: ∞";
                else
                    lblTime.Text = "Time for answer: ∞";

            }
 

            int halfx = this.Width / 2;
            int halfy = this.Height / 2;
            btn1.Left = halfx - btn1.Width - 8;
            btn3.Left = halfx + 8;
            btn2.Left = btn1.Left;
            btn4.Left = btn3.Left;
            lblQuestion.Left = halfx - lblQuestion.Width / 2;
            btnNext.Left = btn4.Left + btn4.Width - btnNext.Width;

            btn1.Top = halfy;
            btn3.Top = halfy;
            btn2.Top = btn1.Top + btn1.Height + 5;
            btn4.Top = btn3.Top + btn1.Height + 5;
            lblQuestion.Top = this.Height / 4;
            btnNext.Top = btn4.Top + 100;


            if (SchemeEditor.timeForBack != 0)
                timerBack.Enabled = true;

            Random random = new Random();
            back = SchemeEditor.back;

            this.BackgroundImage = back[random.Next(back.Count)];
            NextQuestion();
        }


        private void timerBack_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > SchemeEditor.timeForBack)
            {
                Random random = new Random();
                this.BackgroundImage = back[random.Next(back.Count)];
                time = 0;
            }
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            timerTime.Enabled = false;
            Button b = sender as Button;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer(Properties.Resources.Wait);
            if (SchemeEditor.playSounds)
            {
                sp1.Play();
                Thread.Sleep(5500);
            }
            else
                Thread.Sleep(1500);
            
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;


            if (b.Text != correct)
            {
                SchemeEditor.wrongAnswers++;
                if (SchemeEditor.Lang == "Ru")
                    lblWrong.Text = "Неправильных ответов: " + SchemeEditor.wrongAnswers;
                else
                    lblWrong.Text = "Wrong answers: " + SchemeEditor.wrongAnswers;
                sp = new System.Media.SoundPlayer(Properties.Resources.WA);
                b.BackColor = Color.Orange;
                foreach (var item in Controls.OfType<Button>())
                {
                    if (item.Text == correct)
                    {
                        item.BackColor = Color.Lime;
                        break;
                    }
                }

                if (SchemeEditor.playSounds)
                    sp.Play();
            }
            else
            {
                b.BackColor = Color.Lime;

                SchemeEditor.rightAnswers++;
                if (SchemeEditor.Lang == "Ru")
                    lblCorrect.Text = "Правильных ответов: " + SchemeEditor.rightAnswers;
                else
                    lblCorrect.Text = "Right answers: " + SchemeEditor.rightAnswers;

                sp = new System.Media.SoundPlayer(Properties.Resources.RA);

                if (SchemeEditor.playSounds)
                    sp.Play();
            }

            btnNext.Enabled = true;
            btnNext.BackColor = Color.White;
            sp.Dispose();
            sp1.Dispose();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            questTime = SchemeEditor.timeForQuestion;
            timerTime.Enabled = true;
            if (SchemeEditor.Lang == "Ru")
                lblTime.Text = "Оставшееся время на ответ: " + questTime;
            else
                lblTime.Text = "Time for answer: " + questTime;

            btnNext.Enabled = false;
            btnNext.BackColor = Color.LightGray;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            NextQuestion();
        }

        string correct = "";
        public void NextQuestion()
        {
            btnNext.Enabled = false;
            btnNext.BackColor = Color.LightGray;
            btn1.BackColor = SchemeEditor.DefColor;
            btn2.BackColor = SchemeEditor.DefColor;
            btn3.BackColor = SchemeEditor.DefColor;
            btn4.BackColor = SchemeEditor.DefColor;
            btnNext.BackColor = SchemeEditor.DefColor;

            var l_con = prvCommon.f_GetDBConnection(prvCommon.curDB);

            if (l_con == null) { MessageBox.Show("Read вопросов невозможно. Ошибка установления соединения"); return; }
            try
            {
                using (l_con)
                {
                    var cmd = prvCommon.f_GetSQLCommandVar(prvCommon.curDB, l_con);
                    Random r = new Random();

                    cmd.CommandText = "select count() from QuizTable";
                    cmd.ExecuteNonQuery();
                    System.Data.Common.DbDataReader reader = prvCommon.f_GetDataReader(prvCommon.curDB, cmd, l_con);
                    int count = 0;
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            count = reader.GetInt32(0);
                        }
                    }

                    reader.Close();

                    if (SchemeEditor.Lang == "Ru")
                    {
                        lblQuestion.Text = "Вопрос:\n";
                    }
                    else
                    {
                        lblQuestion.Text = "Question:\n";
                    }

                    Random random = new Random();
                    int plus = 0;
                    bool flag = true;

                    while (flag)
                    {
                        plus = random.Next(1, count + 1);
                        cmd.CommandText = "select lang from QuizTable where num = " + plus.ToString();
                        cmd.ExecuteNonQuery();
                        reader = prvCommon.f_GetDataReader(prvCommon.curDB, cmd, l_con);
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())
                            {
                                if (SchemeEditor.Lang == reader.GetString(0) && !questions.Contains(plus))
                                {
                                    flag = false;
                                    if (questions.Count >= 15)
                                        questions.Clear();
                                    questions.Add(plus);
                                    break;
                                }
                            }
                        }
                        reader.Close();
                    }


                    cmd.CommandText = "select question, v1, v2, v3, v4, correct from QuizTable where num = " + plus.ToString();
                    cmd.ExecuteNonQuery();
                    reader = prvCommon.f_GetDataReader(prvCommon.curDB, cmd, l_con);

                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            lblQuestion.Text += reader.GetString(0);
                            btn1.Text = reader.GetString(1);
                            btn2.Text = reader.GetString(2);
                            btn3.Text = reader.GetString(3);
                            btn4.Text = reader.GetString(4);
                            correct = reader.GetString(5);
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Ошибка чтения вопросов: " + ex.Message); }



        }

        private void btn_MouseEnter(object sender, EventArgs e) // персонализация 
        {
            Button btn = sender as Button;
            btn.BackColor = SchemeEditor.MyColor;
        }

        private void btn_MouseLeave(object sender, EventArgs e) // персонализация 
        {
            if (!btnNext.Enabled)
            {
                Button btn = sender as Button;
                btn.BackColor = SchemeEditor.DefColor;
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            if (SchemeEditor.timeForQuestion == 0)
                timerTime.Enabled = false;
            else
            {
                if (SchemeEditor.Lang == "Ru")
                    lblTime.Text = "Оставшееся время на ответ: " + --questTime;
                else
                    lblTime.Text = "Time for answer: " + --questTime;

                if (questTime <= 0)
                {
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btnNext.Enabled = true;

                    btn1.BackColor = Color.Orange;
                    btn2.BackColor = Color.Orange;
                    btn3.BackColor = Color.Orange;
                    btn4.BackColor = Color.Orange;

                    //if (SchemeEditor.playSounds)
                    //{
                    //    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.WA);
                    //    sp.Play();
                    //}

                    timerTime.Enabled = false;
                }
            }
        }
    }
}
