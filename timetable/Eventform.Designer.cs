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
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.Location = new Point(128, 130);
            txtDate.Margin = new Padding(5, 5, 5, 5);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(755, 50);
            txtDate.TabIndex = 0;
            // 
            // txtEvent
            // 
            txtEvent.Font = new Font("Segoe UI", 12F);
            txtEvent.Location = new Point(128, 272);
            txtEvent.Margin = new Padding(5, 5, 5, 5);
            txtEvent.Name = "txtEvent";
            txtEvent.Size = new Size(755, 50);
            txtEvent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 93);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 32);
            label1.TabIndex = 2;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 237);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 32);
            label2.TabIndex = 3;
            label2.Text = "Event";
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackgroundImageLayout = ImageLayout.None;
            btnsave.Location = new Point(733, 379);
            btnsave.Margin = new Padding(5, 5, 5, 5);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(153, 46);
            btnsave.TabIndex = 4;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // Eventform
            // 
            AcceptButton = btnsave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 478);
            Controls.Add(btnsave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEvent);
            Controls.Add(txtDate);
            Margin = new Padding(5, 5, 5, 5);
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
    }
}