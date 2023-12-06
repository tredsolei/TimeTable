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
            daycontainer.BackColor = Color.White;
            daycontainer.Location = new Point(31, 270);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1520, 800);
            daycontainer.TabIndex = 0;
            // 
            // btnprevious
            // 
            btnprevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnprevious.Location = new Point(1289, 1092);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(50, 50);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "<";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.White;
            btnnext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnext.Location = new Point(1502, 1092);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(50, 50);
            btnnext.TabIndex = 2;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(254, 150, 149);
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(1333, 208);
            label7.Name = "label7";
            label7.Size = new Size(213, 59);
            label7.TabIndex = 13;
            label7.Text = "Sunday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(234, 209, 188);
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(1116, 208);
            label6.Name = "label6";
            label6.Size = new Size(213, 59);
            label6.TabIndex = 12;
            label6.Text = "Saturday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(241, 181, 157);
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(900, 208);
            label5.Name = "label5";
            label5.Size = new Size(213, 59);
            label5.TabIndex = 11;
            label5.Text = "Friday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(150, 180, 232);
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(684, 208);
            label4.Name = "label4";
            label4.Size = new Size(213, 59);
            label4.TabIndex = 10;
            label4.Text = "Thursday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(201, 217, 188);
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(467, 208);
            label3.Name = "label3";
            label3.Size = new Size(213, 59);
            label3.TabIndex = 9;
            label3.Text = "Wednesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(201, 218, 235);
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(251, 208);
            label2.Name = "label2";
            label2.Size = new Size(213, 59);
            label2.TabIndex = 8;
            label2.Text = "Tuesday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 217, 136);
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 208);
            label1.Name = "label1";
            label1.Size = new Size(213, 59);
            label1.TabIndex = 7;
            label1.Text = "Monday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbmonth
            // 
            lbmonth.AutoSize = true;
            lbmonth.Font = new Font("Arial", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbmonth.ForeColor = Color.Black;
            lbmonth.Location = new Point(54, 99);
            lbmonth.Name = "lbmonth";
            lbmonth.Size = new Size(472, 69);
            lbmonth.TabIndex = 14;
            lbmonth.Text = "MONTH + YEAR";
            lbmonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btntoday
            // 
            btntoday.BackColor = Color.White;
            btntoday.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btntoday.Location = new Point(1346, 1092);
            btntoday.Name = "btntoday";
            btntoday.Size = new Size(150, 50);
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
            lbtoday.Location = new Point(804, 110);
            lbtoday.Name = "lbtoday";
            lbtoday.Size = new Size(715, 62);
            lbtoday.TabIndex = 16;
            lbtoday.Text = "TODAY";
            lbtoday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 154, 154);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(33, 18);
            button1.Name = "button1";
            button1.Size = new Size(99, 50);
            button1.TabIndex = 17;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnexit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(222, 221, 221);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            menuStrip1.Location = new Point(139, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(87, 48);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.AutoSize = false;
            viewToolStripMenuItem.BackColor = Color.FromArgb(222, 221, 221);
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { overdueEventsToolStripMenuItem });
            viewToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Padding = new Padding(3);
            viewToolStripMenuItem.Size = new Size(75, 42);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // overdueEventsToolStripMenuItem
            // 
            overdueEventsToolStripMenuItem.Name = "overdueEventsToolStripMenuItem";
            overdueEventsToolStripMenuItem.Size = new Size(325, 44);
            overdueEventsToolStripMenuItem.Text = "Overdue events";
            overdueEventsToolStripMenuItem.Click += overdueEventsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 251);
            ClientSize = new Size(2052, 1161);
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
