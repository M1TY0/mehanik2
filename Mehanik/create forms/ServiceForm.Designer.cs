namespace Mehanik
{
    partial class ServiceForm
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
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(777, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 52);
            textBox3.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(12, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 52);
            textBox1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 215);
            dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(816, 320);
            button1.Name = "button1";
            button1.Size = new Size(166, 171);
            button1.TabIndex = 15;
            button1.Text = "Добави нова услуга";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(352, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 53);
            comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(31, 82);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 21;
            label1.Text = "Име на услугата";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(452, 82);
            label2.Name = "label2";
            label2.Size = new Size(89, 46);
            label2.TabIndex = 22;
            label2.Text = "Част";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(750, 82);
            label3.Name = "label3";
            label3.Size = new Size(459, 46);
            label3.TabIndex = 23;
            label3.Text = "Цена на услугата без частта ";
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 589);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ServiceForm";
            Text = "ServiceForm";
            Load += ServiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}