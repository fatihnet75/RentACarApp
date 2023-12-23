namespace RentaCar
{
    partial class odeme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            krediButton = new Button();
            pesinButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 50);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 106);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 106);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 2;
            label4.Text = "Tarih:";
            // 
            // krediButton
            // 
            krediButton.Location = new Point(166, 236);
            krediButton.Name = "krediButton";
            krediButton.Size = new Size(94, 29);
            krediButton.TabIndex = 4;
            krediButton.Text = "Kredi";
            krediButton.UseVisualStyleBackColor = true;
            krediButton.Click += krediButton_Click;
            // 
            // pesinButton
            // 
            pesinButton.Location = new Point(413, 236);
            pesinButton.Name = "pesinButton";
            pesinButton.Size = new Size(94, 29);
            pesinButton.TabIndex = 5;
            pesinButton.Text = "pesin";
            pesinButton.UseVisualStyleBackColor = true;
            pesinButton.Click += pesinButton_Click;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pesinButton);
            Controls.Add(krediButton);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "odeme";
            Text = "odeme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button krediButton;
        private Button pesinButton;
    }
}