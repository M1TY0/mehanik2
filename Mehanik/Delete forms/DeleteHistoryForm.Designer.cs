namespace Mehanik
{
    partial class DeleteHistoryForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(339, 315);
            button1.Name = "button1";
            button1.Size = new Size(313, 150);
            button1.TabIndex = 0;
            button1.Text = "Изтриване на работата";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 30F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(395, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 75);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(160, 53);
            label1.Name = "label1";
            label1.Size = new Size(668, 67);
            label1.TabIndex = 2;
            label1.Text = "Id на работата за изтриване";
            // 
            // DeleteHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "DeleteHistoryForm";
            Text = "DeleteHistoryForm";
            Load += DeleteHistoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}