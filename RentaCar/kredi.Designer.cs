namespace RentaCar
{
    partial class kredi
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
            adTextBox = new TextBox();
            label5 = new Label();
            kartIdTextBox = new MaskedTextBox();
            label3 = new Label();
            CvvTextBox = new MaskedTextBox();
            label1 = new Label();
            Savebutton = new Button();
            SuspendLayout();
            // 
            // adTextBox
            // 
            adTextBox.BackColor = SystemColors.ControlLight;
            adTextBox.Location = new Point(213, 49);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(125, 27);
            adTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 49);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 11;
            label5.Text = "Ad:";
            // 
            // kartIdTextBox
            // 
            kartIdTextBox.BackColor = SystemColors.ControlLight;
            kartIdTextBox.Location = new Point(213, 108);
            kartIdTextBox.Mask = "0000000000000000";
            kartIdTextBox.Name = "kartIdTextBox";
            kartIdTextBox.Size = new Size(125, 27);
            kartIdTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 111);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 13;
            label3.Text = "Kart Numarasi:";
            // 
            // CvvTextBox
            // 
            CvvTextBox.BackColor = SystemColors.ControlLight;
            CvvTextBox.Location = new Point(213, 184);
            CvvTextBox.Mask = "000";
            CvvTextBox.Name = "CvvTextBox";
            CvvTextBox.Size = new Size(125, 27);
            CvvTextBox.TabIndex = 16;
            CvvTextBox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 184);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 15;
            label1.Text = "CVV:";
            // 
            // Savebutton
            // 
            Savebutton.BackColor = SystemColors.GrayText;
            Savebutton.Location = new Point(233, 270);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(188, 58);
            Savebutton.TabIndex = 17;
            Savebutton.Text = "kaydet";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // kredi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(Savebutton);
            Controls.Add(CvvTextBox);
            Controls.Add(label1);
            Controls.Add(kartIdTextBox);
            Controls.Add(label3);
            Controls.Add(adTextBox);
            Controls.Add(label5);
            Name = "kredi";
            Text = "kredi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox adTextBox;
        private Label label5;
        private MaskedTextBox kartIdTextBox;
        private Label label3;
        private MaskedTextBox CvvTextBox;
        private Label label1;
        private Button Savebutton;
    }
}