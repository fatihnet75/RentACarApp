namespace RentaCar
{
    partial class aracSahibi
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
            Label label3;
            Label label2;
            Label label4;
            meslekTextBox = new TextBox();
            adSoyadTextBox = new TextBox();
            tcTextBox = new MaskedTextBox();
            label1 = new Label();
            telPozisyonTextBox = new TextBox();
            devamButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // meslekTextBox
            // 
            meslekTextBox.Location = new Point(168, 193);
            meslekTextBox.Name = "meslekTextBox";
            meslekTextBox.Size = new Size(125, 27);
            meslekTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 200);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 10;
            label3.Text = "Meslek:";
            // 
            // adSoyadTextBox
            // 
            adSoyadTextBox.Location = new Point(168, 64);
            adSoyadTextBox.Name = "adSoyadTextBox";
            adSoyadTextBox.Size = new Size(125, 27);
            adSoyadTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 71);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Ad-Soyad:";
            // 
            // tcTextBox
            // 
            tcTextBox.Location = new Point(168, 132);
            tcTextBox.Mask = "00000000000";
            tcTextBox.Name = "tcTextBox";
            tcTextBox.Size = new Size(125, 27);
            tcTextBox.TabIndex = 7;
            tcTextBox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 139);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "TC:";
            // 
            // telPozisyonTextBox
            // 
            telPozisyonTextBox.Location = new Point(220, 262);
            telPozisyonTextBox.Name = "telPozisyonTextBox";
            telPozisyonTextBox.Size = new Size(125, 27);
            telPozisyonTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 269);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 12;
            label4.Text = "Tel veya Pozisyon:";
            // 
            // devamButton
            // 
            devamButton.Location = new Point(356, 354);
            devamButton.Name = "devamButton";
            devamButton.Size = new Size(94, 29);
            devamButton.TabIndex = 15;
            devamButton.Text = "DEVAM";
            devamButton.UseVisualStyleBackColor = true;
            devamButton.Click += devamButton_Click;
            // 
            // aracSahibi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(devamButton);
            Controls.Add(telPozisyonTextBox);
            Controls.Add(label4);
            Controls.Add(meslekTextBox);
            Controls.Add(label3);
            Controls.Add(adSoyadTextBox);
            Controls.Add(label2);
            Controls.Add(tcTextBox);
            Controls.Add(label1);
            Name = "aracSahibi";
            Text = "aracSahibi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox meslekTextBox;
        private TextBox adSoyadTextBox;
        private MaskedTextBox tcTextBox;
        private Label label1;
        private TextBox telPozisyonTextBox;
        private Button devamButton;
    }
}