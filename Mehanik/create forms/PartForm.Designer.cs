namespace Mehanik
{
    partial class PartForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(454, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 52);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(93, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 52);
            textBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(490, 188);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(778, 315);
            button1.Name = "button1";
            button1.Size = new Size(227, 136);
            button1.TabIndex = 10;
            button1.Text = "Създаване на част";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(804, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 52);
            textBox3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(75, 67);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 15;
            label1.Text = "Име на частта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(769, 67);
            label2.Name = "label2";
            label2.Size = new Size(340, 46);
            label2.TabIndex = 16;
            label2.Text = "Наличност на частта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(429, 67);
            label3.Name = "label3";
            label3.Size = new Size(252, 46);
            label3.TabIndex = 17;
            label3.Text = "Цена на частта";
            // 
            // PartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 589);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "PartForm";
            Text = "PartForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}