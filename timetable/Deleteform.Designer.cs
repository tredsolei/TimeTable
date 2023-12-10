namespace timetable
{
    partial class DeleteEventform
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btndeleteback = new Button();
            dataGridViewEvents = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            eventColumn = new DataGridViewTextBoxColumn();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // btndeleteback
            // 
            btndeleteback.Location = new Point(10, 8);
            btndeleteback.Margin = new Padding(2);
            btndeleteback.Name = "btndeleteback";
            btndeleteback.Size = new Size(75, 27);
            btndeleteback.TabIndex = 14;
            btndeleteback.Text = "Back";
            btndeleteback.UseVisualStyleBackColor = true;
            btndeleteback.Click += btndeleteback_Click;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEvents.BackgroundColor = Color.FromArgb(234, 246, 251);
            dataGridViewEvents.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Columns.AddRange(new DataGridViewColumn[] { id, dateColumn, eventColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEvents.Location = new Point(79, 51);
            dataGridViewEvents.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEvents.Size = new Size(391, 152);
            dataGridViewEvents.TabIndex = 15;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            // 
            // dateColumn
            // 
            dateColumn.DataPropertyName = "date";
            dateColumn.HeaderText = "Date";
            dateColumn.MinimumWidth = 6;
            dateColumn.Name = "dateColumn";
            // 
            // eventColumn
            // 
            eventColumn.DataPropertyName = "event";
            eventColumn.HeaderText = "Event";
            eventColumn.MinimumWidth = 6;
            eventColumn.Name = "eventColumn";
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(255, 154, 154);
            btndelete.Location = new Point(456, 220);
            btndelete.Margin = new Padding(3, 2, 3, 2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 27);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // DeleteEventform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 231, 249);
            ClientSize = new Size(543, 256);
            Controls.Add(btndelete);
            Controls.Add(dataGridViewEvents);
            Controls.Add(btndeleteback);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeleteEventform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deleteform";
            Load += Deleteform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btndeleteback;
        private DataGridView dataGridViewEvents;
        private Button btndelete;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn eventColumn;
    }
}