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
            labelday = new Label();
            btnback = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelday
            // 
            labelday.AutoSize = true;
            labelday.Font = new Font("Arial", 11F);
            labelday.Location = new Point(31, 104);
            labelday.Name = "labelday";
            labelday.Size = new Size(95, 35);
            labelday.TabIndex = 0;
            labelday.Text = "label1";
            // 
            // btnback
            // 
            btnback.Font = new Font("Arial", 11F);
            btnback.Location = new Point(31, 28);
            btnback.Name = "btnback";
            btnback.Size = new Size(113, 46);
            btnback.TabIndex = 1;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 37);
            label1.Name = "label1";
            label1.Size = new Size(249, 56);
            label1.TabIndex = 2;
            label1.Text = "All events";
            // 
            // Allevent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnback;
            ClientSize = new Size(1075, 535);
            Controls.Add(label1);
            Controls.Add(btnback);
            Controls.Add(labelday);
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

        private Label labelday;
        private Button btnback;
        private Label label1;
    }
}