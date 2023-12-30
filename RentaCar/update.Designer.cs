namespace RentaCar
{
    partial class update
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
            plakaTextBox1 = new MaskedTextBox();
            label1 = new Label();
            yıilTextBox1 = new MaskedTextBox();
            fiyatTextBox2 = new MaskedTextBox();
            renkTextBox3 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(273, 333);
            button1.Name = "button1";
            button1.Size = new Size(203, 46);
            button1.TabIndex = 0;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // plakaTextBox1
            // 
            plakaTextBox1.Location = new Point(308, 38);
            plakaTextBox1.Name = "plakaTextBox1";
            plakaTextBox1.Size = new Size(125, 27);
            plakaTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 2;
            label1.Text = "Güncellemek istediğiniz araç plakası :";
            // 
            // yıilTextBox1
            // 
            yıilTextBox1.Location = new Point(308, 211);
            yıilTextBox1.Mask = "00/00/0000";
            yıilTextBox1.Name = "yıilTextBox1";
            yıilTextBox1.Size = new Size(125, 27);
            yıilTextBox1.TabIndex = 3;
            yıilTextBox1.ValidatingType = typeof(DateTime);
            // 
            // fiyatTextBox2
            // 
            fiyatTextBox2.Location = new Point(308, 153);
            fiyatTextBox2.Name = "fiyatTextBox2";
            fiyatTextBox2.Size = new Size(125, 27);
            fiyatTextBox2.TabIndex = 4;
            // 
            // renkTextBox3
            // 
            renkTextBox3.Location = new Point(308, 93);
            renkTextBox3.Name = "renkTextBox3";
            renkTextBox3.Size = new Size(125, 27);
            renkTextBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 96);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 6;
            label2.Text = "yeni renk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 218);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "yeni yıl:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 156);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "yeni fiyat:";
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(renkTextBox3);
            Controls.Add(fiyatTextBox2);
            Controls.Add(yıilTextBox1);
            Controls.Add(label1);
            Controls.Add(plakaTextBox1);
            Controls.Add(button1);
            Name = "update";
            Text = "update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox plakaTextBox1;
        private Label label1;
        private MaskedTextBox yıilTextBox1;
        private MaskedTextBox fiyatTextBox2;
        private MaskedTextBox renkTextBox3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}