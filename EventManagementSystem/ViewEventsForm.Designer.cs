namespace EventManagementSystem
{
    partial class ViewEventsForm
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
            dataGridViewEvents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(0, 2);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowTemplate.Height = 25;
            dataGridViewEvents.Size = new Size(920, 447);
            dataGridViewEvents.TabIndex = 0;
            dataGridViewEvents.CellContentClick += dataGridViewEvents_CellContentClick;
            // 
            // ViewEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 450);
            Controls.Add(dataGridViewEvents);
            Name = "ViewEventsForm";
            Text = "ViewEventsForm";
            Load += ViewEventsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEvents;
    }
}