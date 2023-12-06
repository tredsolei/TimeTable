namespace timetable
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbdays = new Label();
            lbevent = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbdays.Location = new Point(153, 6);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(56, 45);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            lbdays.TextAlign = ContentAlignment.TopRight;
            lbdays.Click += lbevent_Click;
            // 
            // lbevent
            // 
            lbevent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbevent.BackColor = SystemColors.HighlightText;
            lbevent.Location = new Point(9, 51);
            lbevent.Margin = new Padding(5, 0, 5, 0);
            lbevent.Name = "lbevent";
            lbevent.Size = new Size(193, 77);
            lbevent.TabIndex = 1;
            lbevent.Text = " ";
            lbevent.TextAlign = ContentAlignment.MiddleCenter;
            lbevent.Click += lbevent_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbevent);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(211, 126);
            Click += lbevent_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label lbevent;
        private System.Windows.Forms.Timer timer1;
    }
}
