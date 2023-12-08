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
            txtDate.Location = new Point(76, 96);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(466, 34);
            txtDate.TabIndex = 0;
            // 
            // txtEvent
            // 
            txtEvent.Font = new Font("Segoe UI", 12F);
            txtEvent.Location = new Point(76, 185);
            txtEvent.Name = "txtEvent";
            txtEvent.Size = new Size(466, 34);
            txtEvent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(75, 73);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(75, 163);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Event";
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackgroundImageLayout = ImageLayout.None;
            btnsave.Location = new Point(490, 287);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 4;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(11, 11);
            btnback.Margin = new Padding(2, 2, 2, 2);
            btnback.Name = "btnback";
            btnback.Size = new Size(92, 29);
            btnback.TabIndex = 5;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(104, 252);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(112, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Not Completed";
            // 
            // checkCompleted
            // 
            checkCompleted.AutoSize = true;
            checkCompleted.Location = new Point(81, 254);
            checkCompleted.Name = "checkCompleted";
            checkCompleted.Size = new Size(18, 17);
            checkCompleted.TabIndex = 6;
            checkCompleted.UseVisualStyleBackColor = true;
            checkCompleted.CheckedChanged += checkCompleted_CheckedChanged;
            // 
            // Eventform
            // 
            AcceptButton = btnsave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnback;
            ClientSize = new Size(621, 341);
            Controls.Add(checkCompleted);
            Controls.Add(btnback);
            Controls.Add(btnsave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEvent);
            Controls.Add(txtDate);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.None;
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