namespace SdfHazirliq
{
    partial class StudentForm
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(183, 38);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 1;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(45, 109);
            label2.Name = "label2";
            label2.Size = new Size(46, 32);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(45, 229);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 4;
            label3.Text = "Soyad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(45, 349);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 6;
            label4.Text = "Sinif Nomresi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 400);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 27);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(45, 463);
            button1.Name = "button1";
            button1.Size = new Size(224, 46);
            button1.TabIndex = 8;
            button1.Text = "Add Student List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(330, 463);
            button2.Name = "button2";
            button2.Size = new Size(90, 46);
            button2.TabIndex = 9;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(478, 545);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}