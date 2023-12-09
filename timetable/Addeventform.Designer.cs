namespace timetable
{
    partial class Addeventform
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
            btnaddback = new Button();
            btnaddsave = new Button();
            label2 = new Label();
            label1 = new Label();
            txtaddEvent = new TextBox();
            txtaddDate = new TextBox();
            SuspendLayout();
            // 
            // btnaddback
            // 
            btnaddback.Location = new Point(10, 8);
            btnaddback.Margin = new Padding(2);
            btnaddback.Name = "btnaddback";
            btnaddback.Size = new Size(80, 27);
            btnaddback.TabIndex = 13;
            btnaddback.Text = "Back";
            btnaddback.UseVisualStyleBackColor = true;
            btnaddback.Click += btnaddback_Click_1;
            // 
            // btnaddsave
            // 
            btnaddsave.Anchor = AnchorStyles.None;
            btnaddsave.BackColor = Color.FromArgb(201, 217, 188);
            btnaddsave.BackgroundImageLayout = ImageLayout.None;
            btnaddsave.Location = new Point(433, 212);
            btnaddsave.Margin = new Padding(3, 2, 3, 2);
            btnaddsave.Name = "btnaddsave";
            btnaddsave.Size = new Size(82, 27);
            btnaddsave.TabIndex = 12;
            btnaddsave.Text = "Save";
            btnaddsave.UseVisualStyleBackColor = false;
            btnaddsave.Click += btnaddsave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(65, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(65, 62);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 10;
            label1.Text = "Date";
            // 
            // txtaddEvent
            // 
            txtaddEvent.Font = new Font("Segoe UI", 12F);
            txtaddEvent.Location = new Point(66, 146);
            txtaddEvent.Margin = new Padding(3, 2, 3, 2);
            txtaddEvent.Name = "txtaddEvent";
            txtaddEvent.Size = new Size(408, 29);
            txtaddEvent.TabIndex = 9;
            // 
            // txtaddDate
            // 
            txtaddDate.Font = new Font("Segoe UI", 12F);
            txtaddDate.Location = new Point(66, 79);
            txtaddDate.Margin = new Padding(3, 2, 3, 2);
            txtaddDate.Name = "txtaddDate";
            txtaddDate.Size = new Size(408, 29);
            txtaddDate.TabIndex = 7;
            // 
            // Addeventform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 231, 249);
            ClientSize = new Size(543, 256);
            Controls.Add(btnaddback);
            Controls.Add(btnaddsave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtaddEvent);
            Controls.Add(txtaddDate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Addeventform";
            Text = "Addeventform";
            Load += Addeventform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnaddback;
        private Button btnaddsave;
        private Label label2;
        private Label label1;
        private TextBox txtaddEvent;
        private TextBox txtaddDate;
    }
}