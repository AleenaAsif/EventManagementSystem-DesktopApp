namespace EventManagementSystem
{
    partial class UpdateEventForm
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
            idupdate = new TextBox();
            nameupdate = new TextBox();
            categoryupdate = new TextBox();
            organizerupdate = new TextBox();
            locationupdate = new TextBox();
            timeupdate = new TextBox();
            eventstatusupdate = new TextBox();
            updateEventButton = new Button();
            btnSearch = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // idupdate
            // 
            idupdate.Location = new Point(262, 39);
            idupdate.Name = "idupdate";
            idupdate.Size = new Size(129, 23);
            idupdate.TabIndex = 0;
            idupdate.TextChanged += textBox1_TextChanged;
            // 
            // nameupdate
            // 
            nameupdate.Location = new Point(209, 148);
            nameupdate.Name = "nameupdate";
            nameupdate.Size = new Size(145, 23);
            nameupdate.TabIndex = 1;
            // 
            // categoryupdate
            // 
            categoryupdate.Location = new Point(209, 216);
            categoryupdate.Name = "categoryupdate";
            categoryupdate.Size = new Size(145, 23);
            categoryupdate.TabIndex = 2;
            // 
            // organizerupdate
            // 
            organizerupdate.Location = new Point(209, 285);
            organizerupdate.Name = "organizerupdate";
            organizerupdate.Size = new Size(145, 23);
            organizerupdate.TabIndex = 3;
            // 
            // locationupdate
            // 
            locationupdate.Location = new Point(600, 152);
            locationupdate.Name = "locationupdate";
            locationupdate.Size = new Size(152, 23);
            locationupdate.TabIndex = 4;
            // 
            // timeupdate
            // 
            timeupdate.Location = new Point(600, 220);
            timeupdate.Name = "timeupdate";
            timeupdate.Size = new Size(152, 23);
            timeupdate.TabIndex = 5;
            // 
            // eventstatusupdate
            // 
            eventstatusupdate.Location = new Point(600, 285);
            eventstatusupdate.Name = "eventstatusupdate";
            eventstatusupdate.Size = new Size(152, 23);
            eventstatusupdate.TabIndex = 6;
            // 
            // updateEventButton
            // 
            updateEventButton.BackColor = Color.DarkSalmon;
            updateEventButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            updateEventButton.Location = new Point(320, 346);
            updateEventButton.Name = "updateEventButton";
            updateEventButton.Size = new Size(200, 50);
            updateEventButton.TabIndex = 7;
            updateEventButton.Text = "UPDATE EVENT";
            updateEventButton.UseVisualStyleBackColor = false;
            updateEventButton.Click += updateEventButton_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSalmon;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearch.Location = new Point(262, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(4);
            btnSearch.Size = new Size(92, 41);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Image = Properties.Resources.eevent;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 37);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(154, 29);
            label1.TabIndex = 10;
            label1.Text = "Event ID to update";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 142);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(105, 29);
            label2.TabIndex = 11;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 210);
            label3.Name = "label3";
            label3.Padding = new Padding(4);
            label3.Size = new Size(130, 29);
            label3.TabIndex = 12;
            label3.Text = "Event Category";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 283);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(133, 29);
            label4.TabIndex = 13;
            label4.Text = "Event Oragnizer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(447, 146);
            label5.Name = "label5";
            label5.Padding = new Padding(4);
            label5.Size = new Size(125, 29);
            label5.TabIndex = 14;
            label5.Text = "Event Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(447, 214);
            label6.Name = "label6";
            label6.Padding = new Padding(4);
            label6.Size = new Size(98, 29);
            label6.TabIndex = 15;
            label6.Text = "Event Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(447, 283);
            label7.Name = "label7";
            label7.Padding = new Padding(4);
            label7.Size = new Size(107, 29);
            label7.TabIndex = 16;
            label7.Text = "Event Status";
            // 
            // UpdateEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(updateEventButton);
            Controls.Add(eventstatusupdate);
            Controls.Add(timeupdate);
            Controls.Add(locationupdate);
            Controls.Add(organizerupdate);
            Controls.Add(categoryupdate);
            Controls.Add(nameupdate);
            Controls.Add(idupdate);
            Controls.Add(pictureBox1);
            Name = "UpdateEventForm";
            Text = "UpdateEventForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idupdate;
        private TextBox nameupdate;
        private TextBox categoryupdate;
        private TextBox organizerupdate;
        private TextBox locationupdate;
        private TextBox timeupdate;
        private TextBox eventstatusupdate;
        private Button updateEventButton;
        private Button btnSearch;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}