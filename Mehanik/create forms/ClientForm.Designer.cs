namespace Mehanik
{
    partial class ClientForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(731, 355);
            button1.Name = "button1";
            button1.Size = new Size(224, 153);
            button1.TabIndex = 0;
            button1.Text = "Създаване на нов клиент";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(42, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 52);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(372, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 52);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(739, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 52);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(739, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(297, 52);
            textBox4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 242);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(303, 46);
            label1.TabIndex = 6;
            label1.Text = "Имена на клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(342, 67);
            label2.Name = "label2";
            label2.Size = new Size(368, 46);
            label2.TabIndex = 7;
            label2.Text = "Телефонът на клиента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(716, 167);
            label3.Name = "label3";
            label3.Size = new Size(417, 46);
            label3.TabIndex = 8;
            label3.Text = "Марка и модел на колата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(716, 25);
            label4.Name = "label4";
            label4.Size = new Size(386, 46);
            label4.TabIndex = 9;
            label4.Text = "Регистрационен номер";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 589);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "ClientForm";
            Text = "ClientForm";
            Load += ClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}