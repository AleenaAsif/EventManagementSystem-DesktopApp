namespace EventManagementSystem
{
    partial class DeleteEventForm
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
            delete = new Button();
            label1 = new Label();
            delEventId = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // delete
            // 
            delete.BackColor = Color.DarkSalmon;
            delete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delete.ForeColor = SystemColors.ControlText;
            delete.Location = new Point(340, 161);
            delete.Name = "delete";
            delete.Size = new Size(202, 42);
            delete.TabIndex = 0;
            delete.Text = "DELETE EVENT";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 103);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(244, 29);
            label1.TabIndex = 1;
            label1.Text = "Enter Id of event to be deleted";
            // 
            // delEventId
            // 
            delEventId.Location = new Point(340, 109);
            delEventId.Name = "delEventId";
            delEventId.Size = new Size(202, 23);
            delEventId.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eevent;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DeleteEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delEventId);
            Controls.Add(label1);
            Controls.Add(delete);
            Controls.Add(pictureBox1);
            Name = "DeleteEventForm";
            Text = "DeleteEventForm";
            Load += DeleteEventForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delete;
        private Label label1;
        private TextBox delEventId;
        private PictureBox pictureBox1;
    }
}