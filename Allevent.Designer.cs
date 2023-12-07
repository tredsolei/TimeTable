namespace timetable
{
    partial class Allevent
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
            lbdays = new Label();
            btnback = new Button();
            label1 = new Label();
            displayallev = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.Font = new Font("Segoe UI", 12F);
            lbdays.Location = new Point(310, 24);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(732, 46);
            lbdays.TabIndex = 0;
            lbdays.Text = "day";
            lbdays.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 9F);
            btnback.Location = new Point(31, 28);
            btnback.Name = "btnback";
            btnback.Size = new Size(150, 46);
            btnback.TabIndex = 1;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(421, 87);
            label1.Name = "label1";
            label1.Size = new Size(199, 51);
            label1.TabIndex = 2;
            label1.Text = "All events";
            // 
            // displayallev
            // 
            displayallev.Font = new Font("Segoe UI", 12F);
            displayallev.Location = new Point(53, 161);
            displayallev.Name = "displayallev";
            displayallev.Size = new Size(963, 342);
            displayallev.TabIndex = 3;
            displayallev.Text = "You have no events added!";
            // 
            // Allevent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnback;
            ClientSize = new Size(1075, 535);
            Controls.Add(displayallev);
            Controls.Add(label1);
            Controls.Add(btnback);
            Controls.Add(lbdays);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Allevent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Allevent";
            Load += Allevent_Load;
            Leave += btnback_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private Button btnback;
        private Label label1;
        private Label displayallev;
    }
}