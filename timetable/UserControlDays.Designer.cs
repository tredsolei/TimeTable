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
            lbdays.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbdays.Location = new Point(148, 16);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(47, 33);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            lbdays.TextAlign = ContentAlignment.TopRight;
            // 
            // lbevent
            // 
            lbevent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbevent.BackColor = SystemColors.HighlightText;
            lbevent.Location = new Point(5, 51);
            lbevent.Margin = new Padding(5, 0, 5, 0);
            lbevent.Name = "lbevent";
            lbevent.Size = new Size(195, 77);
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
            Controls.Add(lbevent);
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(213, 128);
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Label lbevent;
        private System.Windows.Forms.Timer timer1;
    }
}
