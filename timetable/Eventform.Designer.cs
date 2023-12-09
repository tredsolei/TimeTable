namespace timetable
{
    partial class Eventform
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
            txtDate = new TextBox();
            txtEvent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnsave = new Button();
            btnback = new Button();
            lblStatus = new Label();
            checkCompleted = new CheckBox();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.Location = new Point(62, 74);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(408, 29);
            txtDate.TabIndex = 0;
            // 
            // txtEvent
            // 
            txtEvent.Font = new Font("Segoe UI", 12F);
            txtEvent.Location = new Point(62, 141);
            txtEvent.Margin = new Padding(3, 2, 3, 2);
            txtEvent.Name = "txtEvent";
            txtEvent.Size = new Size(408, 29);
            txtEvent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(62, 57);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(62, 124);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Event";
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(201, 217, 188);
            btnsave.BackgroundImageLayout = ImageLayout.None;
            btnsave.Location = new Point(439, 218);
            btnsave.Margin = new Padding(3, 2, 3, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(82, 27);
            btnsave.TabIndex = 4;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(10, 8);
            btnback.Margin = new Padding(2);
            btnback.Name = "btnback";
            btnback.Size = new Size(80, 27);
            btnback.TabIndex = 5;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(87, 191);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Not Completed";
            // 
            // checkCompleted
            // 
            checkCompleted.AutoSize = true;
            checkCompleted.Location = new Point(67, 192);
            checkCompleted.Margin = new Padding(3, 2, 3, 2);
            checkCompleted.Name = "checkCompleted";
            checkCompleted.Size = new Size(15, 14);
            checkCompleted.TabIndex = 6;
            checkCompleted.UseVisualStyleBackColor = true;
            checkCompleted.CheckedChanged += checkCompleted_CheckedChanged;
            // 
            // Eventform
            // 
            AcceptButton = btnsave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 231, 249);
            CancelButton = btnback;
            ClientSize = new Size(543, 256);
            Controls.Add(checkCompleted);
            Controls.Add(btnback);
            Controls.Add(btnsave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEvent);
            Controls.Add(txtDate);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Eventform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eventform";
            Load += Eventform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDate;
        private TextBox txtEvent;
        private Label label1;
        private Label label2;
        private Button btnsave;
        private Button btnback;
        private Label lblStatus;
        private CheckBox checkCompleted;
    }
}