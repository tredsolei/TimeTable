namespace timetable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            daycontainer = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(12, 146);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1538, 804);
            daycontainer.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1240, 960);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 1;
            button1.Text = "Trước";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1400, 960);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 2;
            button2.Text = "Sau";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label7.Location = new Point(1342, 94);
            label7.Name = "label7";
            label7.Size = new Size(185, 44);
            label7.TabIndex = 13;
            label7.Text = "Chủ Nhật";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label6.Location = new Point(1133, 94);
            label6.Name = "label6";
            label6.Size = new Size(170, 44);
            label6.TabIndex = 12;
            label6.Text = "Thứ Bảy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label5.Location = new Point(911, 94);
            label5.Name = "label5";
            label5.Size = new Size(171, 44);
            label5.TabIndex = 11;
            label5.Text = "Thứ Sáu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label4.Location = new Point(687, 94);
            label4.Name = "label4";
            label4.Size = new Size(183, 44);
            label4.TabIndex = 10;
            label4.Text = "Thứ Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label3.Location = new Point(486, 94);
            label3.Name = "label3";
            label3.Size = new Size(152, 44);
            label3.TabIndex = 9;
            label3.Text = "Thứ Tư";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label2.Location = new Point(266, 94);
            label2.Name = "label2";
            label2.Size = new Size(150, 44);
            label2.TabIndex = 8;
            label2.Text = "Thứ Ba";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Bold);
            label1.Location = new Point(42, 94);
            label1.Name = "label1";
            label1.Size = new Size(160, 44);
            label1.TabIndex = 7;
            label1.Text = "Thứ Hai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 1023);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(daycontainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "timetable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
