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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            overdueEventsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(19, 169);
            daycontainer.Margin = new Padding(2);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(953, 500);
            daycontainer.TabIndex = 0;
            // 
            // btnprevious
            // 
            btnprevious.Location = new Point(810, 681);
            btnprevious.Margin = new Padding(2);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(31, 31);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "<";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(942, 681);
            btnnext.Margin = new Padding(2);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(31, 31);
            btnnext.TabIndex = 2;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(855, 130);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 24);
            label7.TabIndex = 13;
            label7.Text = "Sunday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(715, 130);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 24);
            label6.TabIndex = 12;
            label6.Text = "Saturday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(595, 130);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 24);
            label5.TabIndex = 11;
            label5.Text = "Friday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(443, 130);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 10;
            label4.Text = "Thursday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(299, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 24);
            label3.TabIndex = 9;
            label3.Text = "Wednesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(178, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 8;
            label2.Text = "Tuesday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 130);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 7;
            label1.Text = "Monday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbmonth
            // 
            lbmonth.AutoSize = true;
            lbmonth.Font = new Font("Arial", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbmonth.Location = new Point(33, 57);
            lbmonth.Margin = new Padding(2, 0, 2, 0);
            lbmonth.Name = "lbmonth";
            lbmonth.Size = new Size(301, 44);
            lbmonth.TabIndex = 14;
            lbmonth.Text = "MONTH + YEAR";
            lbmonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btntoday
            // 
            btntoday.Location = new Point(846, 681);
            btntoday.Margin = new Padding(2);
            btntoday.Name = "btntoday";
            btntoday.Size = new Size(92, 31);
            btntoday.TabIndex = 15;
            btntoday.Text = "Today";
            btntoday.UseVisualStyleBackColor = true;
            btntoday.Click += btntoday_Click;
            // 
            // lbtoday
            // 
            lbtoday.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbtoday.ImageAlign = ContentAlignment.MiddleRight;
            lbtoday.Location = new Point(495, 64);
            lbtoday.Margin = new Padding(2, 0, 2, 0);
            lbtoday.Name = "lbtoday";
            lbtoday.Size = new Size(440, 39);
            lbtoday.TabIndex = 16;
            lbtoday.Text = "TODAY";
            lbtoday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Location = new Point(13, 12);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(61, 31);
            button1.TabIndex = 17;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnexit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            menuStrip1.Location = new Point(96, 15);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(213, 28);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { overdueEventsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // overdueEventsToolStripMenuItem
            // 
            overdueEventsToolStripMenuItem.Name = "overdueEventsToolStripMenuItem";
            overdueEventsToolStripMenuItem.Size = new Size(224, 26);
            overdueEventsToolStripMenuItem.Text = "Overdue events";
            overdueEventsToolStripMenuItem.Click += overdueEventsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1080, 732);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
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
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "timetable";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem overdueEventsToolStripMenuItem;
    }
}
