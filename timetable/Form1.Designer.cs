namespace timetable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            daycontainer = new FlowLayoutPanel();
            btnprevious = new Button();
            btnnext = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbmonth = new Label();
            btntoday = new Button();
            lbtoday = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(31, 216);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1549, 800);
            daycontainer.TabIndex = 0;
            // 
            // btnprevious
            // 
            btnprevious.Location = new Point(1317, 1031);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(50, 50);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "<";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(1530, 1031);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(50, 50);
            btnnext.TabIndex = 2;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(1389, 154);
            label7.Name = "label7";
            label7.Size = new Size(130, 37);
            label7.TabIndex = 13;
            label7.Text = "Sunday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(1162, 154);
            label6.Name = "label6";
            label6.Size = new Size(153, 37);
            label6.TabIndex = 12;
            label6.Text = "Saturday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(967, 154);
            label5.Name = "label5";
            label5.Size = new Size(114, 37);
            label5.TabIndex = 11;
            label5.Text = "Friday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(720, 154);
            label4.Name = "label4";
            label4.Size = new Size(160, 37);
            label4.TabIndex = 10;
            label4.Text = "Thursday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(486, 154);
            label3.Name = "label3";
            label3.Size = new Size(193, 37);
            label3.TabIndex = 9;
            label3.Text = "Wednesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(290, 154);
            label2.Name = "label2";
            label2.Size = new Size(144, 37);
            label2.TabIndex = 8;
            label2.Text = "Tuesday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(83, 154);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 7;
            label1.Text = "Monday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbmonth
            // 
            lbmonth.AutoSize = true;
            lbmonth.Font = new Font("Arial", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbmonth.Location = new Point(53, 37);
            lbmonth.Name = "lbmonth";
            lbmonth.Size = new Size(472, 69);
            lbmonth.TabIndex = 14;
            lbmonth.Text = "MONTH + YEAR";
            lbmonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btntoday
            // 
            btntoday.Location = new Point(1374, 1031);
            btntoday.Name = "btntoday";
            btntoday.Size = new Size(150, 50);
            btntoday.TabIndex = 15;
            btntoday.Text = "Today";
            btntoday.UseVisualStyleBackColor = true;
            btntoday.Click += btntoday_CLick;
            // 
            // lbtoday
            // 
            lbtoday.AutoSize = true;
            lbtoday.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbtoday.ImageAlign = ContentAlignment.MiddleRight;
            lbtoday.Location = new Point(954, 62);
            lbtoday.Name = "lbtoday";
            lbtoday.Size = new Size(123, 37);
            lbtoday.TabIndex = 16;
            lbtoday.Text = "TODAY";
            lbtoday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1608, 1099);
            Controls.Add(lbtoday);
            Controls.Add(btntoday);
            Controls.Add(lbmonth);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnnext);
            Controls.Add(btnprevious);
            Controls.Add(daycontainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "timetable";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button btnprevious;
        private Button btnnext;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbmonth;
        private Button btntoday;
        private Label lbtoday;
    }
}
