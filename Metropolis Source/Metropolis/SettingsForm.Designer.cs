namespace Metropolis
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.cbShowInfrastructure = new System.Windows.Forms.CheckBox();
            this.lblShowInfrastructure = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.pSet = new System.Windows.Forms.Panel();
            this.lblMyColor = new System.Windows.Forms.Label();
            this.lblDefColor = new System.Windows.Forms.Label();
            this.cbMyColor = new System.Windows.Forms.ComboBox();
            this.cbDefColor = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbPlaySounds = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbQuiz = new System.Windows.Forms.ComboBox();
            this.lblQuizTime = new System.Windows.Forms.Label();
            this.pSet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbShowInfrastructure
            // 
            this.cbShowInfrastructure.AutoSize = true;
            this.cbShowInfrastructure.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowInfrastructure.Location = new System.Drawing.Point(39, 44);
            this.cbShowInfrastructure.Name = "cbShowInfrastructure";
            this.cbShowInfrastructure.Size = new System.Drawing.Size(22, 21);
            this.cbShowInfrastructure.TabIndex = 1;
            this.cbShowInfrastructure.UseVisualStyleBackColor = true;
            this.cbShowInfrastructure.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblShowInfrastructure
            // 
            this.lblShowInfrastructure.AutoSize = true;
            this.lblShowInfrastructure.BackColor = System.Drawing.Color.White;
            this.lblShowInfrastructure.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.lblShowInfrastructure.Location = new System.Drawing.Point(67, 14);
            this.lblShowInfrastructure.Name = "lblShowInfrastructure";
            this.lblShowInfrastructure.Size = new System.Drawing.Size(821, 84);
            this.lblShowInfrastructure.TabIndex = 2;
            this.lblShowInfrastructure.Text = "Показывать информацию о инфраструктуре \r\nи маршрутах в исторической справке";
            this.lblShowInfrastructure.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Lucida Fax", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(346, 31);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(463, 38);
            this.lblSet.TabIndex = 3;
            this.lblSet.Text = "Настройки и персонализация";
            // 
            // pSet
            // 
            this.pSet.Controls.Add(this.lblSet);
            this.pSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSet.Location = new System.Drawing.Point(0, 0);
            this.pSet.Name = "pSet";
            this.pSet.Size = new System.Drawing.Size(1135, 88);
            this.pSet.TabIndex = 4;
            // 
            // lblMyColor
            // 
            this.lblMyColor.BackColor = System.Drawing.Color.White;
            this.lblMyColor.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.lblMyColor.Location = new System.Drawing.Point(21, 178);
            this.lblMyColor.Name = "lblMyColor";
            this.lblMyColor.Size = new System.Drawing.Size(640, 42);
            this.lblMyColor.TabIndex = 6;
            this.lblMyColor.Text = "Основной цвет выделения:";
            this.lblMyColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefColor
            // 
            this.lblDefColor.BackColor = System.Drawing.Color.White;
            this.lblDefColor.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.lblDefColor.Location = new System.Drawing.Point(14, 238);
            this.lblDefColor.Name = "lblDefColor";
            this.lblDefColor.Size = new System.Drawing.Size(647, 42);
            this.lblDefColor.TabIndex = 7;
            this.lblDefColor.Text = "Дополнительный цвет выделения:";
            this.lblDefColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMyColor
            // 
            this.cbMyColor.BackColor = System.Drawing.Color.White;
            this.cbMyColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMyColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMyColor.FormattingEnabled = true;
            this.cbMyColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Purple",
            "Pink",
            "AliceBlue",
            "Orange",
            "Lime",
            "WhiteSmoke"});
            this.cbMyColor.Location = new System.Drawing.Point(667, 182);
            this.cbMyColor.Name = "cbMyColor";
            this.cbMyColor.Size = new System.Drawing.Size(331, 33);
            this.cbMyColor.TabIndex = 5;
            this.cbMyColor.SelectedIndexChanged += new System.EventHandler(this.cbMyColor_SelectedIndexChanged);
            // 
            // cbDefColor
            // 
            this.cbDefColor.BackColor = System.Drawing.Color.White;
            this.cbDefColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDefColor.FormattingEnabled = true;
            this.cbDefColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Pink",
            "White",
            "Gainsboro",
            "AliceBlue",
            "Orange",
            "WhiteSmoke"});
            this.cbDefColor.Location = new System.Drawing.Point(667, 242);
            this.cbDefColor.Name = "cbDefColor";
            this.cbDefColor.Size = new System.Drawing.Size(331, 33);
            this.cbDefColor.TabIndex = 8;
            this.cbDefColor.SelectedIndexChanged += new System.EventHandler(this.cbDefColor_SelectedIndexChanged);
            // 
            // cbTime
            // 
            this.cbTime.BackColor = System.Drawing.Color.White;
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "Не менять фото на фоне",
            "15 секунд",
            "30 секунд",
            "1 минута",
            "1.5 минуты",
            "2 минуты",
            "3 минуты"});
            this.cbTime.Location = new System.Drawing.Point(667, 302);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(331, 33);
            this.cbTime.TabIndex = 9;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(21, 297);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(640, 42);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Время на смену фото на фоне:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPlaySounds
            // 
            this.cbPlaySounds.AutoSize = true;
            this.cbPlaySounds.BackColor = System.Drawing.Color.White;
            this.cbPlaySounds.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.cbPlaySounds.Location = new System.Drawing.Point(39, 108);
            this.cbPlaySounds.Name = "cbPlaySounds";
            this.cbPlaySounds.Size = new System.Drawing.Size(616, 46);
            this.cbPlaySounds.TabIndex = 11;
            this.cbPlaySounds.Text = "Проигрывать звуки в Викторине";
            this.cbPlaySounds.UseVisualStyleBackColor = false;
            this.cbPlaySounds.CheckedChanged += new System.EventHandler(this.cbPlaySounds_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbQuiz);
            this.panel1.Controls.Add(this.lblQuizTime);
            this.panel1.Controls.Add(this.cbPlaySounds);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.cbTime);
            this.panel1.Controls.Add(this.lblDefColor);
            this.panel1.Controls.Add(this.cbDefColor);
            this.panel1.Controls.Add(this.lblMyColor);
            this.panel1.Controls.Add(this.cbMyColor);
            this.panel1.Controls.Add(this.lblShowInfrastructure);
            this.panel1.Controls.Add(this.cbShowInfrastructure);
            this.panel1.Location = new System.Drawing.Point(66, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 418);
            this.panel1.TabIndex = 12;
            // 
            // cbQuiz
            // 
            this.cbQuiz.BackColor = System.Drawing.Color.White;
            this.cbQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuiz.FormattingEnabled = true;
            this.cbQuiz.Items.AddRange(new object[] {
            "Не ограничивать время",
            "5 секунд",
            "10 секунд",
            "15 секунд",
            "20 секунд",
            "30 секунд",
            "1 минута"});
            this.cbQuiz.Location = new System.Drawing.Point(667, 362);
            this.cbQuiz.Name = "cbQuiz";
            this.cbQuiz.Size = new System.Drawing.Size(331, 33);
            this.cbQuiz.TabIndex = 13;
            this.cbQuiz.SelectedIndexChanged += new System.EventHandler(this.cbQuiz_SelectedIndexChanged);
            // 
            // lblQuizTime
            // 
            this.lblQuizTime.BackColor = System.Drawing.Color.White;
            this.lblQuizTime.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.lblQuizTime.Location = new System.Drawing.Point(21, 355);
            this.lblQuizTime.Name = "lblQuizTime";
            this.lblQuizTime.Size = new System.Drawing.Size(640, 42);
            this.lblQuizTime.TabIndex = 12;
            this.lblQuizTime.Text = "Время на ответ в Викторине:";
            this.lblQuizTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metropolis.Properties.Resources.back_2;
            this.ClientSize = new System.Drawing.Size(1135, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pSet);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pSet.ResumeLayout(false);
            this.pSet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cbShowInfrastructure;
        private System.Windows.Forms.Label lblShowInfrastructure;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Panel pSet;
        private System.Windows.Forms.Label lblMyColor;
        private System.Windows.Forms.Label lblDefColor;
        private System.Windows.Forms.ComboBox cbMyColor;
        private System.Windows.Forms.ComboBox cbDefColor;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox cbPlaySounds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbQuiz;
        private System.Windows.Forms.Label lblQuizTime;
    }
}