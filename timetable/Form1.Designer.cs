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

        private System.Windows.Forms.DataGridView dataGridViewEvents;
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
            dataGridViewEvents = new DataGridView();
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
            upcomingEventsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.Location = new Point(0, 0);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.Size = new Size(240, 150);
            dataGridViewEvents.TabIndex = 0;
            // 
            // daycontainer
            // 
            daycontainer.BackColor = Color.FromArgb(234, 246, 251);
            daycontainer.Location = new Point(17, 127);
            daycontainer.Margin = new Padding(2);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(816, 379);
            daycontainer.TabIndex = 0;
            // 
            // btnprevious
            // 
            btnprevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnprevious.Location = new Point(691, 512);
            btnprevious.Margin = new Padding(2);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(27, 23);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "<";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.White;
            btnnext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnext.Location = new Point(806, 512);
            btnnext.Margin = new Padding(2);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(27, 23);
            btnnext.TabIndex = 2;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(254, 150, 149);
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(716, 98);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 13;
            label7.Text = "Sunday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(234, 209, 188);
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(599, 98);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 12;
            label6.Text = "Saturday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(241, 181, 157);
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(483, 98);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 11;
            label5.Text = "Friday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(150, 180, 232);
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(367, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 10;
            label4.Text = "Thursday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(201, 217, 188);
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(249, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 9;
            label3.Text = "Wednesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(201, 218, 235);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(133, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 8;
            label2.Text = "Tuesday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 217, 136);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(18, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 7;
            label1.Text = "Monday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbmonth
            // 
            lbmonth.AutoSize = true;
            lbmonth.Font = new Font("Arial", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbmonth.ForeColor = Color.Black;
            lbmonth.Location = new Point(29, 46);
            lbmonth.Margin = new Padding(2, 0, 2, 0);
            lbmonth.Name = "lbmonth";
            lbmonth.Size = new Size(241, 35);
            lbmonth.TabIndex = 14;
            lbmonth.Text = "MONTH + YEAR";
            lbmonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btntoday
            // 
            btntoday.BackColor = Color.White;
            btntoday.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntoday.Location = new Point(722, 512);
            btntoday.Margin = new Padding(2);
            btntoday.Name = "btntoday";
            btntoday.Size = new Size(80, 23);
            btntoday.TabIndex = 15;
            btntoday.Text = "Today";
            btntoday.UseVisualStyleBackColor = false;
            btntoday.Click += btntoday_Click;
            // 
            // lbtoday
            // 
            lbtoday.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbtoday.ForeColor = Color.Black;
            lbtoday.ImageAlign = ContentAlignment.MiddleRight;
            lbtoday.Location = new Point(433, 52);
            lbtoday.Margin = new Padding(2, 0, 2, 0);
            lbtoday.Name = "lbtoday";
            lbtoday.Size = new Size(385, 29);
            lbtoday.TabIndex = 16;
            lbtoday.Text = "TODAY";
            lbtoday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 154, 154);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(14, 10);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(49, 27);
            button1.TabIndex = 17;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnexit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            menuStrip1.Location = new Point(59, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(1);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(46, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { overdueEventsToolStripMenuItem, upcomingEventsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Padding = new Padding(3);
            viewToolStripMenuItem.RightToLeft = RightToLeft.No;
            viewToolStripMenuItem.Size = new Size(42, 22);
            viewToolStripMenuItem.Text = "View";
            // 
            // overdueEventsToolStripMenuItem
            // 
            overdueEventsToolStripMenuItem.Name = "overdueEventsToolStripMenuItem";
            overdueEventsToolStripMenuItem.Size = new Size(180, 22);
            overdueEventsToolStripMenuItem.Text = "Overdue events";
            overdueEventsToolStripMenuItem.Click += overdueEventsToolStripMenuItem_Click;
            // 
            // upcomingEventsToolStripMenuItem
            // 
            upcomingEventsToolStripMenuItem.Name = "upcomingEventsToolStripMenuItem";
            upcomingEventsToolStripMenuItem.Size = new Size(180, 22);
            upcomingEventsToolStripMenuItem.Text = "Upcoming events";
            upcomingEventsToolStripMenuItem.Click += upcomingEventsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 231, 249);
            ClientSize = new Size(856, 543);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
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
        private ToolStripMenuItem upcomingEventsToolStripMenuItem;
    }
}
