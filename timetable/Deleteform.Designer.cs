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
            btndelete = new Button();
            id = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            eventColumn = new DataGridViewTextBoxColumn();
            isCompletedColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // btndeleteback
            // 
            btndeleteback.Location = new Point(11, 11);
            btndeleteback.Margin = new Padding(2);
            btndeleteback.Name = "btndeleteback";
            btndeleteback.Size = new Size(92, 29);
            btndeleteback.TabIndex = 14;
            btndeleteback.Text = "Back";
            btndeleteback.UseVisualStyleBackColor = true;
            btndeleteback.Click += btndeleteback_Click;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEvents.BackgroundColor = Color.Gainsboro;
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
            dataGridViewEvents.Columns.AddRange(new DataGridViewColumn[] { id, dateColumn, eventColumn, isCompletedColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEvents.Location = new Point(88, 72);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEvents.Size = new Size(447, 203);
            dataGridViewEvents.TabIndex = 15;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(523, 300);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(86, 29);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
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
            // isCompletedColumn
            // 
            isCompletedColumn.DataPropertyName = "IsCompleted";
            isCompletedColumn.HeaderText = "Complete Status";
            isCompletedColumn.MinimumWidth = 6;
            isCompletedColumn.Name = "isCompletedColumn";
            isCompletedColumn.ReadOnly = true;
            // 
            // DeleteEventform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 341);
            Controls.Add(btndelete);
            Controls.Add(dataGridViewEvents);
            Controls.Add(btndeleteback);
            FormBorderStyle = FormBorderStyle.None;
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
        private DataGridViewCheckBoxColumn isCompletedColumn;
    }
}