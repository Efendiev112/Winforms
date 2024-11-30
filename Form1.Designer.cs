namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            WriteButton = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // WriteButton
            // 
            WriteButton.BackColor = Color.IndianRed;
            WriteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            WriteButton.ForeColor = SystemColors.ActiveCaptionText;
            WriteButton.Location = new Point(10, 202);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(186, 50);
            WriteButton.TabIndex = 2;
            WriteButton.Text = "Запись в файл";
            WriteButton.UseVisualStyleBackColor = false;
            WriteButton.Click += WriteButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(10, 122);
            button4.Name = "button4";
            button4.Size = new Size(186, 50);
            button4.TabIndex = 3;
            button4.Text = "Чтение файла";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(229, 122);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(339, 217);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 387);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(605, 0);
            label1.Name = "label1";
            label1.Size = new Size(548, 75);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(814, 113);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(339, 217);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(622, 202);
            button3.Name = "button3";
            button3.Size = new Size(186, 50);
            button3.TabIndex = 8;
            button3.Text = "Запись в файл \r\nс учетом задания";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(622, 122);
            button1.Name = "button1";
            button1.Size = new Size(186, 50);
            button1.TabIndex = 9;
            button1.Text = "Чтение файла";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 659);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(WriteButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button WriteButton;
        private Button button4;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private RichTextBox richTextBox2;
        private Button button3;
        private Button button1;
    }
}