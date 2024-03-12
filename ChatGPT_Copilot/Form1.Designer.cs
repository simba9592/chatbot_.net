namespace ChatGPT_Copilot
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
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Copilot Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 27);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Question:";
            label2.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(26, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1385, 682);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1369, 628);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(32, 336);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1031, 272);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 284);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 4;
            label3.Text = "Answer : ";
            // 
            // button1
            // 
            button1.Location = new Point(1135, 78);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Reply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1031, 177);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1369, 628);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Database";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1196, 14);
            button2.Name = "button2";
            button2.Size = new Size(80, 46);
            button2.TabIndex = 3;
            button2.Text = "Eng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1282, 14);
            button3.Name = "button3";
            button3.Size = new Size(70, 46);
            button3.TabIndex = 4;
            button3.Text = "Ger";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 775);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ChatGPT App";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private Button button1;
        private RichTextBox richTextBox2;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}