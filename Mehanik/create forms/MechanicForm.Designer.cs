namespace Mehanik
{
    partial class MechanicForm
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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(665, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 52);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(131, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 52);
            textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(534, 242);
            dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(696, 327);
            button1.Name = "button1";
            button1.Size = new Size(212, 118);
            button1.TabIndex = 6;
            button1.Text = "Създавне на механик";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(117, 29);
            label1.Name = "label1";
            label1.Size = new Size(274, 46);
            label1.TabIndex = 10;
            label1.Text = "Име на механик";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(691, 29);
            label2.Name = "label2";
            label2.Size = new Size(207, 46);
            label2.TabIndex = 11;
            label2.Text = "Цена на час";
            // 
            // MechanicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 589);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "MechanicForm";
            Text = "MechanicForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}