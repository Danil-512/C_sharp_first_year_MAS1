namespace MAS1
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox8 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(14, 207);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 41);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(64, 207);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(44, 41);
            textBox3.TabIndex = 2;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(115, 207);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(44, 41);
            textBox4.TabIndex = 3;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 15F);
            textBox5.Location = new Point(167, 207);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(41, 41);
            textBox5.TabIndex = 4;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 15F);
            textBox6.Location = new Point(215, 207);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(41, 41);
            textBox6.TabIndex = 5;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(14, 129);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(287, 31);
            button1.TabIndex = 6;
            button1.Text = "Заполнить массив";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 168);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(287, 31);
            button2.TabIndex = 7;
            button2.Text = "Вывести максимумы столбцов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(14, 280);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(286, 27);
            textBox8.TabIndex = 9;
            textBox8.TextChanged += textBox8_TextChanged;
            textBox8.KeyPress += textBox8_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 256);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 11;
            label1.Text = "Введите номер столбца";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 25);
            label4.Name = "label4";
            label4.Size = new Size(303, 20);
            label4.TabIndex = 14;
            label4.Text = "-------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 45);
            label5.Name = "label5";
            label5.Size = new Size(303, 20);
            label5.TabIndex = 15;
            label5.Text = "-------------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 65);
            label6.Name = "label6";
            label6.Size = new Size(303, 20);
            label6.TabIndex = 16;
            label6.Text = "-------------------------------------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 85);
            label7.Name = "label7";
            label7.Size = new Size(303, 20);
            label7.TabIndex = 17;
            label7.Text = "-------------------------------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 105);
            label8.Name = "label8";
            label8.Size = new Size(303, 20);
            label8.TabIndex = 18;
            label8.Text = "-------------------------------------------------";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 15F);
            textBox7.Location = new Point(263, 207);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(37, 41);
            textBox7.TabIndex = 20;
            textBox7.KeyPress += textBox7_KeyPress_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 398);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 27);
            textBox1.TabIndex = 21;
            textBox1.KeyPress += textBox1_KeyPress_1;
            // 
            // button3
            // 
            button3.Location = new Point(14, 353);
            button3.Name = "button3";
            button3.Size = new Size(286, 38);
            button3.TabIndex = 22;
            button3.Text = "Отсортировать по возрастанию ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 314);
            button4.Name = "button4";
            button4.Size = new Size(286, 33);
            button4.TabIndex = 23;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 432);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private TextBox textBox8;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
    }
}
