namespace EventManagementSystem
{
    partial class AddEventForm
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
            eventid = new TextBox();
            eventname = new TextBox();
            eventcategory = new TextBox();
            organizer = new TextBox();
            location = new TextBox();
            time = new TextBox();
            eventstatus = new TextBox();
            btnAddEvent = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AttendeesNames = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // eventid
            // 
            eventid.Location = new Point(260, 57);
            eventid.Name = "eventid";
            eventid.Size = new Size(134, 23);
            eventid.TabIndex = 0;
            // 
            // eventname
            // 
            eventname.Location = new Point(260, 114);
            eventname.Name = "eventname";
            eventname.Size = new Size(134, 23);
            eventname.TabIndex = 1;
            // 
            // eventcategory
            // 
            eventcategory.Location = new Point(260, 167);
            eventcategory.Name = "eventcategory";
            eventcategory.Size = new Size(134, 23);
            eventcategory.TabIndex = 2;
            // 
            // organizer
            // 
            organizer.Location = new Point(260, 235);
            organizer.Name = "organizer";
            organizer.Size = new Size(134, 23);
            organizer.TabIndex = 3;
            // 
            // location
            // 
            location.Location = new Point(260, 298);
            location.Name = "location";
            location.Size = new Size(134, 23);
            location.TabIndex = 4;
            // 
            // time
            // 
            time.Location = new Point(260, 361);
            time.Name = "time";
            time.Size = new Size(134, 23);
            time.TabIndex = 5;
            // 
            // eventstatus
            // 
            eventstatus.Location = new Point(641, 63);
            eventstatus.Name = "eventstatus";
            eventstatus.Size = new Size(122, 23);
            eventstatus.TabIndex = 6;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackColor = Color.DarkSalmon;
            btnAddEvent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEvent.Location = new Point(604, 361);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(171, 63);
            btnAddEvent.TabIndex = 7;
            btnAddEvent.Text = "ADD EVENT";
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unnamed__1_;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(824, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 51);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(120, 29);
            label1.TabIndex = 9;
            label1.Text = "Enter Event ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 112);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(144, 29);
            label2.TabIndex = 10;
            label2.Text = "Enter Event name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 165);
            label3.Name = "label3";
            label3.Padding = new Padding(4);
            label3.Size = new Size(172, 29);
            label3.TabIndex = 11;
            label3.Text = "Enter Event Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 229);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(175, 29);
            label4.TabIndex = 12;
            label4.Text = "Enter Organizer name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 296);
            label5.Name = "label5";
            label5.Padding = new Padding(4);
            label5.Size = new Size(123, 29);
            label5.TabIndex = 13;
            label5.Text = "Enter Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(51, 361);
            label6.Name = "label6";
            label6.Padding = new Padding(4);
            label6.Size = new Size(137, 29);
            label6.TabIndex = 14;
            label6.Text = "Enter Event time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(470, 57);
            label7.Name = "label7";
            label7.Padding = new Padding(4);
            label7.Size = new Size(149, 29);
            label7.TabIndex = 15;
            label7.Text = "Enter Event Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(470, 120);
            label8.Name = "label8";
            label8.Padding = new Padding(4);
            label8.Size = new Size(123, 29);
            label8.TabIndex = 17;
            label8.Text = "Attendees List";
            // 
            // AttendeesNames
            // 
            AttendeesNames.Location = new Point(617, 120);
            AttendeesNames.Multiline = true;
            AttendeesNames.Name = "AttendeesNames";
            AttendeesNames.ScrollBars = ScrollBars.Vertical;
            AttendeesNames.Size = new Size(180, 189);
            AttendeesNames.TabIndex = 16;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(label8);
            Controls.Add(AttendeesNames);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddEvent);
            Controls.Add(eventstatus);
            Controls.Add(time);
            Controls.Add(location);
            Controls.Add(organizer);
            Controls.Add(eventcategory);
            Controls.Add(eventname);
            Controls.Add(eventid);
            Controls.Add(pictureBox1);
            Name = "AddEventForm";
            Text = "AddEventForm";
            Load += AddEventForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eventid;
        private TextBox eventname;
        private TextBox eventcategory;
        private TextBox organizer;
        private TextBox location;
        private TextBox time;
        private TextBox eventstatus;
        private Button btnAddEvent;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox AttendeesNames;
    }
}