namespace RentaCar
{
    partial class Kiraci
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
            baslangicTextBox = new MaskedTextBox();
            bitisTextBox = new MaskedTextBox();
            tcTextBox = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            telTextBox = new MaskedTextBox();
            label5 = new Label();
            adTextBox = new TextBox();
            soyadTextBox = new TextBox();
            label6 = new Label();
            ePostaTextBox = new TextBox();
            label7 = new Label();
            DEVAM = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 54);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Baslangic Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Bitis Tarihi:";
            // 
            // baslangicTextBox
            // 
            baslangicTextBox.Location = new Point(192, 47);
            baslangicTextBox.Mask = "00/00/0000";
            baslangicTextBox.Name = "baslangicTextBox";
            baslangicTextBox.Size = new Size(125, 27);
            baslangicTextBox.TabIndex = 2;
            baslangicTextBox.ValidatingType = typeof(DateTime);
            // 
            // bitisTextBox
            // 
            bitisTextBox.Location = new Point(480, 47);
            bitisTextBox.Mask = "00/00/0000";
            bitisTextBox.Name = "bitisTextBox";
            bitisTextBox.Size = new Size(125, 27);
            bitisTextBox.TabIndex = 3;
            bitisTextBox.ValidatingType = typeof(DateTime);
            // 
            // tcTextBox
            // 
            tcTextBox.Location = new Point(192, 114);
            tcTextBox.Mask = "00000000000";
            tcTextBox.Name = "tcTextBox";
            tcTextBox.Size = new Size(125, 27);
            tcTextBox.TabIndex = 5;
            tcTextBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 117);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 4;
            label3.Text = "TC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 251);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "Soyad:";
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(480, 117);
            telTextBox.Mask = "00000000000";
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(125, 27);
            telTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 188);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 6;
            label5.Text = "Ad:";
            // 
            // adTextBox
            // 
            adTextBox.Location = new Point(192, 188);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(125, 27);
            adTextBox.TabIndex = 10;
            // 
            // soyadTextBox
            // 
            soyadTextBox.Location = new Point(192, 248);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(125, 27);
            soyadTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 120);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 12;
            label6.Text = "Tel No:";
            // 
            // ePostaTextBox
            // 
            ePostaTextBox.Location = new Point(480, 181);
            ePostaTextBox.Name = "ePostaTextBox";
            ePostaTextBox.Size = new Size(125, 27);
            ePostaTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 188);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 13;
            label7.Text = "E-Posta:";
            // 
            // DEVAM
            // 
            DEVAM.Location = new Point(332, 361);
            DEVAM.Name = "DEVAM";
            DEVAM.Size = new Size(147, 49);
            DEVAM.TabIndex = 15;
            DEVAM.Text = "devamButton";
            DEVAM.UseVisualStyleBackColor = true;
            DEVAM.Click += DEVAM_Click;
            // 
            // Kiraci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DEVAM);
            Controls.Add(ePostaTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(soyadTextBox);
            Controls.Add(adTextBox);
            Controls.Add(label4);
            Controls.Add(telTextBox);
            Controls.Add(label5);
            Controls.Add(tcTextBox);
            Controls.Add(label3);
            Controls.Add(bitisTextBox);
            Controls.Add(baslangicTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Kiraci";
            Text = "Kiraci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox baslangicTextBox;
        private MaskedTextBox bitisTextBox;
        private MaskedTextBox tcTextBox;
        private Label label3;
        private Label label4;
        private MaskedTextBox telTextBox;
        private Label label5;
        private TextBox adTextBox;
        private TextBox soyadTextBox;
        private Label label6;
        private TextBox ePostaTextBox;
        private Label label7;
        private Button DEVAM;
    }
}