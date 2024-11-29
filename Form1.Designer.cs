namespace WeatherApp4GH
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            temperatureTextBox = new TextBox();
            temperatureLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(63, 232);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(653, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Cursor = Cursors.Help;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(63, 353);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(112, 23);
            button1.TabIndex = 1;
            button1.Text = "Temperatura";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.Location = new Point(63, 82);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(100, 23);
            temperatureTextBox.TabIndex = 2;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(62, 64);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(73, 15);
            temperatureLabel.TabIndex = 3;
            temperatureLabel.Text = "Temperatura";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 122);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Wilgotność";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Cursor = Cursors.Help;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(62, 393);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(113, 23);
            button2.TabIndex = 6;
            button2.Text = "Wilgotność";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(345, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 85);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "WMO";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlText;
            button3.Cursor = Cursors.Help;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(345, 363);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(100, 23);
            button3.TabIndex = 9;
            button3.Text = "WMO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(616, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 122);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 11;
            label3.Text = "Prędkość wiatru";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlText;
            button4.Cursor = Cursors.Help;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(603, 393);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(113, 23);
            button4.TabIndex = 12;
            button4.Text = "Prędkość wiatru";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(616, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 64);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 14;
            label4.Text = "Kierunek wiatru";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlText;
            button5.Cursor = Cursors.Help;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(603, 353);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(113, 23);
            button5.TabIndex = 15;
            button5.Text = "Kierunek wiatru";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(temperatureLabel);
            Controls.Add(temperatureTextBox);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox temperatureTextBox;
        private Label temperatureLabel;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private Button button4;
        private TextBox textBox4;
        private Label label4;
        private Button button5;
    }
}
