namespace Mehanik.Main_Menu
{
    partial class CreateForm
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 30F);
            button5.Location = new Point(845, 91);
            button5.Name = "button5";
            button5.Size = new Size(308, 224);
            button5.TabIndex = 9;
            button5.Text = "Създаване на работа";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 30F);
            button4.Location = new Point(458, 91);
            button4.Name = "button4";
            button4.Size = new Size(308, 224);
            button4.TabIndex = 8;
            button4.Text = "Създаване на част";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F);
            button3.Location = new Point(665, 434);
            button3.Name = "button3";
            button3.Size = new Size(308, 224);
            button3.TabIndex = 7;
            button3.Text = "Създаване на услуга";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(211, 434);
            button2.Name = "button2";
            button2.Size = new Size(308, 224);
            button2.TabIndex = 6;
            button2.Text = "Създаване на Механик";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(55, 91);
            button1.Name = "button1";
            button1.Size = new Size(308, 224);
            button1.TabIndex = 5;
            button1.Text = "Създаване на клиент";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 767);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CreateForm";
            Text = "CreateForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}