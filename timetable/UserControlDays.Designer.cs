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
            lbdays = new Label();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbdays.Location = new Point(15, 14);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(47, 33);
            lbdays.TabIndex = 0;
            lbdays.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbdays);
            Name = "UserControlDays";
            Size = new Size(213, 128);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
    }
}
