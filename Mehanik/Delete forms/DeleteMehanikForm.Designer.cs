namespace Mehanik
{
    partial class DeleteMehanikForm
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
            comboBox1.Location = new Point(238, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(547, 75);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(349, 279);
            button1.Name = "button1";
            button1.Size = new Size(331, 145);
            button1.TabIndex = 5;
            button1.Text = "Изтриване на механика";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(153, 66);
            label1.Name = "label1";
            label1.Size = new Size(737, 67);
            label1.TabIndex = 6;
            label1.Text = "Име на механика за изтриване";
            // 
            // DeleteMehanikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "DeleteMehanikForm";
            Text = "DeleteMehanikForm";
            Load += DeleteMehanikForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
    }
}