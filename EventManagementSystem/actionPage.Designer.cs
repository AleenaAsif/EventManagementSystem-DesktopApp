namespace EventManagementSystem
{
    partial class actionPage
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
            viewbtn = new Button();
            addbtn = new Button();
            updatebtn = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // viewbtn
            // 
            viewbtn.AccessibleRole = AccessibleRole.TitleBar;
            viewbtn.BackColor = Color.DarkSalmon;
            viewbtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewbtn.Location = new Point(272, 47);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(280, 60);
            viewbtn.TabIndex = 0;
            viewbtn.Text = "VIEW EVENTS";
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.DarkSalmon;
            addbtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.Location = new Point(272, 131);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(280, 59);
            addbtn.TabIndex = 1;
            addbtn.Text = "ADD EVENTS";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.DarkSalmon;
            updatebtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtn.Location = new Point(272, 219);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(280, 57);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "UPDATE EVENTS";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unnamed__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(272, 309);
            button1.Name = "button1";
            button1.Size = new Size(280, 54);
            button1.TabIndex = 4;
            button1.Text = "DELETE EVENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(681, 12);
            button2.Name = "button2";
            button2.Padding = new Padding(4);
            button2.Size = new Size(107, 62);
            button2.TabIndex = 5;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // actionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(viewbtn);
            Controls.Add(pictureBox1);
            Name = "actionPage";
            Text = "actionPage";
            Load += actionPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Button viewbtn;
        private Button addbtn;
        private Button updatebtn;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}