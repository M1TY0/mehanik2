namespace Mehanik.Main_Menu
{
    partial class ShowForm
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 30F);
            button7.Location = new Point(941, 96);
            button7.Name = "button7";
            button7.Size = new Size(388, 224);
            button7.TabIndex = 14;
            button7.Text = "Съществуващи работи";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 30F);
            button8.Location = new Point(487, 96);
            button8.Name = "button8";
            button8.Size = new Size(388, 224);
            button8.TabIndex = 13;
            button8.Text = "Съществуващи части";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 30F);
            button9.Location = new Point(709, 434);
            button9.Name = "button9";
            button9.Size = new Size(388, 224);
            button9.TabIndex = 12;
            button9.Text = "Съществуващи услуги";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 30F);
            button10.Location = new Point(222, 434);
            button10.Name = "button10";
            button10.Size = new Size(388, 224);
            button10.TabIndex = 11;
            button10.Text = "Съществуващи Механици";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 30F);
            button6.Location = new Point(34, 96);
            button6.Name = "button6";
            button6.Size = new Size(388, 224);
            button6.TabIndex = 10;
            button6.Text = "Съществуващи клиенти";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 767);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button6);
            Name = "ShowForm";
            Text = "ShowForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button6;
    }
}