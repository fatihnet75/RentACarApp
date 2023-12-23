namespace RentaCar
{
    partial class pesin
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
            tarihTextBox = new MaskedTextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tarihTextBox
            // 
            tarihTextBox.Location = new Point(199, 46);
            tarihTextBox.Mask = "00/00/0000";
            tarihTextBox.Name = "tarihTextBox";
            tarihTextBox.Size = new Size(125, 27);
            tarihTextBox.TabIndex = 4;
            tarihTextBox.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 53);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 3;
            label1.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 115);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Toplam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // pesin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(tarihTextBox);
            Controls.Add(label1);
            Name = "pesin";
            Text = "pesin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tarihTextBox;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}