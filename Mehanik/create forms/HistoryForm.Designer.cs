namespace Mehanik
{
    partial class HistoryForm
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
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
            button1.Location = new Point(764, 313);
            button1.Name = "button1";
            button1.Size = new Size(271, 159);
            button1.TabIndex = 0;
            button1.Text = "Добави нова работа";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(591, 242);
            dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(354, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 53);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 20F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(37, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(290, 53);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 20F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(692, 113);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(297, 53);
            comboBox3.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(1036, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 52);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(380, 51);
            label1.Name = "label1";
            label1.Size = new Size(291, 46);
            label1.TabIndex = 10;
            label1.Text = "Име на механика";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(114, 51);
            label2.Name = "label2";
            label2.Size = new Size(119, 46);
            label2.TabIndex = 11;
            label2.Text = "Услуга";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(702, 51);
            label3.Name = "label3";
            label3.Size = new Size(266, 46);
            label3.TabIndex = 12;
            label3.Text = "Име на клиента";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(991, 51);
            label4.Name = "label4";
            label4.Size = new Size(248, 46);
            label4.TabIndex = 13;
            label4.Text = "Часове работа";
            label4.Click += label4_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 589);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "HistoryForm";
            Text = "HistoryForm";
            Load += HistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}