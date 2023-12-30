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
            label4 = new Label();
            krediButton = new Button();
            pesinButton = new Button();
            DateTextBox1 = new MaskedTextBox();
            idmaskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
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
            // DateTextBox1
            // 
            DateTextBox1.Location = new Point(146, 99);
            DateTextBox1.Mask = "00/00/0000";
            DateTextBox1.Name = "DateTextBox1";
            DateTextBox1.Size = new Size(125, 27);
            DateTextBox1.TabIndex = 6;
            DateTextBox1.ValidatingType = typeof(DateTime);
            // 
            // idmaskedTextBox1
            // 
            idmaskedTextBox1.Location = new Point(146, 162);
            idmaskedTextBox1.Mask = "0000";
            idmaskedTextBox1.Name = "idmaskedTextBox1";
            idmaskedTextBox1.Size = new Size(125, 27);
            idmaskedTextBox1.TabIndex = 7;
            idmaskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 169);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 8;
            label3.Text = "id";
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(idmaskedTextBox1);
            Controls.Add(DateTextBox1);
            Controls.Add(pesinButton);
            Controls.Add(krediButton);
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
        private Label label4;
        private Button krediButton;
        private Button pesinButton;
        private MaskedTextBox DateTextBox1;
        private MaskedTextBox idmaskedTextBox1;
        private Label label3;
    }
}