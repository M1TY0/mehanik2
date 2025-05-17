namespace Mehanik
{
    partial class DeleteClientForm
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 30F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(598, 75);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(342, 276);
            button1.Name = "button1";
            button1.Size = new Size(300, 172);
            button1.TabIndex = 1;
            button1.Text = "Изтриване на клиента";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(156, 48);
            label1.Name = "label1";
            label1.Size = new Size(701, 67);
            label1.TabIndex = 2;
            label1.Text = "Име на клиента за изтриване";
            // 
            // DeleteClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "DeleteClientForm";
            Text = "DeleteClientForm";
            Load += DeleteClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
    }
}