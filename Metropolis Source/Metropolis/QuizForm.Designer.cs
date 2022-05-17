namespace Metropolis
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timerBack = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pScores = new System.Windows.Forms.Panel();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.pScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(48, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1220, 244);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Вопрос:\r\n";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 3;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(166, 316);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(489, 116);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Вариант 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 3;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(166, 438);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(489, 116);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Вариант 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 3;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(679, 316);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(489, 116);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "Вариант 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 3;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(679, 438);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(489, 116);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "Вариант 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 3;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(812, 602);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(283, 79);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Следующий";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timerBack
            // 
            this.timerBack.Interval = 1000;
            this.timerBack.Tick += new System.EventHandler(this.timerBack_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(11, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(484, 38);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Оставшееся время на ответ: 0";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pScores
            // 
            this.pScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pScores.Controls.Add(this.lblWrong);
            this.pScores.Controls.Add(this.lblCorrect);
            this.pScores.Controls.Add(this.lblTime);
            this.pScores.Location = new System.Drawing.Point(18, 36);
            this.pScores.Name = "pScores";
            this.pScores.Size = new System.Drawing.Size(543, 151);
            this.pScores.TabIndex = 14;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold);
            this.lblWrong.Location = new System.Drawing.Point(11, 88);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(403, 38);
            this.lblWrong.TabIndex = 15;
            this.lblWrong.Text = "Неправильных ответов: 0";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Bold);
            this.lblCorrect.Location = new System.Drawing.Point(11, 48);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(368, 38);
            this.lblCorrect.TabIndex = 14;
            this.lblCorrect.Text = "Правильных ответов: 0";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 703);
            this.Controls.Add(this.pScores);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.Text = "Викторина";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.pScores.ResumeLayout(false);
            this.pScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timerBack;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel pScores;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblCorrect;
    }
}