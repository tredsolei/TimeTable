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
            btnaddback.Location = new Point(11, 11);
            btnaddback.Margin = new Padding(2);
            btnaddback.Name = "btnaddback";
            btnaddback.Size = new Size(92, 29);
            btnaddback.TabIndex = 13;
            btnaddback.Text = "Back";
            btnaddback.UseVisualStyleBackColor = true;
            btnaddback.Click += btnaddback_Click_1;
            // 
            // btnaddsave
            // 
            btnaddsave.Anchor = AnchorStyles.None;
            btnaddsave.BackgroundImageLayout = ImageLayout.None;
            btnaddsave.Location = new Point(495, 282);
            btnaddsave.Name = "btnaddsave";
            btnaddsave.Size = new Size(94, 29);
            btnaddsave.TabIndex = 12;
            btnaddsave.Text = "Save";
            btnaddsave.UseVisualStyleBackColor = true;
            btnaddsave.Click += btnaddsave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(74, 172);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 11;
            label2.Text = "Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(74, 82);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 10;
            label1.Text = "Date";
            // 
            // txtaddEvent
            // 
            txtaddEvent.Font = new Font("Segoe UI", 12F);
            txtaddEvent.Location = new Point(75, 194);
            txtaddEvent.Name = "txtaddEvent";
            txtaddEvent.Size = new Size(466, 34);
            txtaddEvent.TabIndex = 9;
            // 
            // txtaddDate
            // 
            txtaddDate.Font = new Font("Segoe UI", 12F);
            txtaddDate.Location = new Point(75, 105);
            txtaddDate.Name = "txtaddDate";
            txtaddDate.Size = new Size(466, 34);
            txtaddDate.TabIndex = 7;
            // 
            // Addeventform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 341);
            Controls.Add(btnaddback);
            Controls.Add(btnaddsave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtaddEvent);
            Controls.Add(txtaddDate);
            FormBorderStyle = FormBorderStyle.None;
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