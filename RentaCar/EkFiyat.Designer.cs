namespace RentaCar
{
    partial class EkFiyat
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
            Label label5;
            Label label6;
            Label label8;
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            sonGecerlilikTarihTextBox = new MaskedTextBox();
            label1 = new Label();
            kaskoTextBox = new MaskedTextBox();
            label3 = new Label();
            sonGecerlilikTarihTextBox1 = new MaskedTextBox();
            label2 = new Label();
            sigortaTextBox = new MaskedTextBox();
            label4 = new Label();
            soyadTextBox = new TextBox();
            adTextBox = new TextBox();
            tcTextBox = new MaskedTextBox();
            label7 = new Label();
            ehliyetTipiTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sonGecerlilikTarihTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(kaskoTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(2, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kasko";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(sonGecerlilikTarihTextBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(sigortaTextBox);
            groupBox2.Location = new Point(317, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 416);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sigorta";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ehliyetTipiTextBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(soyadTextBox);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(adTextBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tcTextBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(628, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 416);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sofor ";
            // 
            // sonGecerlilikTarihTextBox
            // 
            sonGecerlilikTarihTextBox.Location = new Point(144, 132);
            sonGecerlilikTarihTextBox.Mask = "00/00/0000";
            sonGecerlilikTarihTextBox.Name = "sonGecerlilikTarihTextBox";
            sonGecerlilikTarihTextBox.Size = new Size(125, 27);
            sonGecerlilikTarihTextBox.TabIndex = 20;
            sonGecerlilikTarihTextBox.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 132);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 19;
            label1.Text = "Son Gecerlilik Tarihi:";
            // 
            // kaskoTextBox
            // 
            kaskoTextBox.Location = new Point(134, 56);
            kaskoTextBox.Mask = "000000000";
            kaskoTextBox.Name = "kaskoTextBox";
            kaskoTextBox.Size = new Size(125, 27);
            kaskoTextBox.TabIndex = 18;
            kaskoTextBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 59);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 17;
            label3.Text = "Kasko Numarasi:";
            // 
            // sonGecerlilikTarihTextBox1
            // 
            sonGecerlilikTarihTextBox1.Location = new Point(146, 129);
            sonGecerlilikTarihTextBox1.Mask = "00/00/0000";
            sonGecerlilikTarihTextBox1.Name = "sonGecerlilikTarihTextBox1";
            sonGecerlilikTarihTextBox1.Size = new Size(125, 27);
            sonGecerlilikTarihTextBox1.TabIndex = 24;
            sonGecerlilikTarihTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 129);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 23;
            label2.Text = "Son Gecerlilik Tarihi:";
            // 
            // sigortaTextBox
            // 
            sigortaTextBox.Location = new Point(136, 53);
            sigortaTextBox.Mask = "000000000";
            sigortaTextBox.Name = "sigortaTextBox";
            sigortaTextBox.Size = new Size(125, 27);
            sigortaTextBox.TabIndex = 22;
            sigortaTextBox.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 21;
            label4.Text = "Sigorta Numarasi:";
            // 
            // soyadTextBox
            // 
            soyadTextBox.Location = new Point(108, 122);
            soyadTextBox.Name = "soyadTextBox";
            soyadTextBox.Size = new Size(125, 27);
            soyadTextBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 129);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 16;
            label5.Text = "Soyad:";
            // 
            // adTextBox
            // 
            adTextBox.Location = new Point(108, 49);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(125, 27);
            adTextBox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 56);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 14;
            label6.Text = "Ad:";
            // 
            // tcTextBox
            // 
            tcTextBox.Location = new Point(108, 177);
            tcTextBox.Mask = "00000000000";
            tcTextBox.Name = "tcTextBox";
            tcTextBox.Size = new Size(125, 27);
            tcTextBox.TabIndex = 13;
            tcTextBox.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 184);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 12;
            label7.Text = "TC:";
            // 
            // ehliyetTipiTextBox
            // 
            ehliyetTipiTextBox.Location = new Point(119, 250);
            ehliyetTipiTextBox.Name = "ehliyetTipiTextBox";
            ehliyetTipiTextBox.Size = new Size(125, 27);
            ehliyetTipiTextBox.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 257);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 18;
            label8.Text = "Ehliyet Tipi:";
            // 
            // EkFiyat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EkFiyat";
            Text = "EkFiyat";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MaskedTextBox sonGecerlilikTarihTextBox;
        private Label label1;
        private MaskedTextBox kaskoTextBox;
        private Label label3;
        private MaskedTextBox sonGecerlilikTarihTextBox1;
        private Label label4;
        private Label label2;
        private MaskedTextBox sigortaTextBox;
        private TextBox ehliyetTipiTextBox;
        private TextBox soyadTextBox;
        private TextBox adTextBox;
        private MaskedTextBox tcTextBox;
        private Label label7;
    }
}