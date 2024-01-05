namespace RentaCar
{
    partial class aracOzellik
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
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            label1 = new Label();
            yilTextBox = new MaskedTextBox();
            plakaTextBox = new TextBox();
            fiyatTextBox = new TextBox();
            renkTextBox = new TextBox();
            modelkTextBox = new TextBox();
            markaTextBox = new TextBox();
            label7 = new Label();
            benzinRadioButton = new RadioButton();
            elektrikRadioButton = new RadioButton();
            devamButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 120);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Plaka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 189);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 260);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "Renk:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 116);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 10;
            label5.Text = "Model:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 45);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 8;
            label6.Text = "Marka:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 45);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Yil:";
            // 
            // yilTextBox
            // 
            yilTextBox.BackColor = SystemColors.ControlLight;
            yilTextBox.Location = new Point(163, 38);
            yilTextBox.Mask = "00/00/0000";
            yilTextBox.Name = "yilTextBox";
            yilTextBox.Size = new Size(125, 27);
            yilTextBox.TabIndex = 1;
            yilTextBox.ValidatingType = typeof(DateTime);
            // 
            // plakaTextBox
            // 
            plakaTextBox.BackColor = SystemColors.ControlLight;
            plakaTextBox.Location = new Point(163, 113);
            plakaTextBox.Name = "plakaTextBox";
            plakaTextBox.Size = new Size(125, 27);
            plakaTextBox.TabIndex = 3;
            // 
            // fiyatTextBox
            // 
            fiyatTextBox.BackColor = SystemColors.ControlLight;
            fiyatTextBox.Location = new Point(163, 182);
            fiyatTextBox.Name = "fiyatTextBox";
            fiyatTextBox.Size = new Size(125, 27);
            fiyatTextBox.TabIndex = 5;
            // 
            // renkTextBox
            // 
            renkTextBox.BackColor = SystemColors.ControlLight;
            renkTextBox.Location = new Point(163, 253);
            renkTextBox.Name = "renkTextBox";
            renkTextBox.Size = new Size(125, 27);
            renkTextBox.TabIndex = 7;
            // 
            // modelkTextBox
            // 
            modelkTextBox.BackColor = SystemColors.ControlLight;
            modelkTextBox.Location = new Point(474, 109);
            modelkTextBox.Name = "modelkTextBox";
            modelkTextBox.Size = new Size(125, 27);
            modelkTextBox.TabIndex = 11;
            // 
            // markaTextBox
            // 
            markaTextBox.BackColor = SystemColors.ControlLight;
            markaTextBox.Location = new Point(474, 38);
            markaTextBox.Name = "markaTextBox";
            markaTextBox.Size = new Size(125, 27);
            markaTextBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 185);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 12;
            label7.Text = "Yakit turunu girin:";
            // 
            // benzinRadioButton
            // 
            benzinRadioButton.AutoSize = true;
            benzinRadioButton.Location = new Point(431, 239);
            benzinRadioButton.Name = "benzinRadioButton";
            benzinRadioButton.Size = new Size(74, 24);
            benzinRadioButton.TabIndex = 13;
            benzinRadioButton.TabStop = true;
            benzinRadioButton.Text = "Benzin";
            benzinRadioButton.UseVisualStyleBackColor = true;
            // 
            // elektrikRadioButton
            // 
            elektrikRadioButton.AutoSize = true;
            elektrikRadioButton.Location = new Point(571, 239);
            elektrikRadioButton.Name = "elektrikRadioButton";
            elektrikRadioButton.Size = new Size(78, 24);
            elektrikRadioButton.TabIndex = 14;
            elektrikRadioButton.TabStop = true;
            elektrikRadioButton.Text = "Elektrik";
            elektrikRadioButton.UseVisualStyleBackColor = true;
            // 
            // devamButton
            // 
            devamButton.BackColor = SystemColors.GrayText;
            devamButton.Location = new Point(327, 360);
            devamButton.Name = "devamButton";
            devamButton.Size = new Size(94, 29);
            devamButton.TabIndex = 15;
            devamButton.Text = "Devam";
            devamButton.UseVisualStyleBackColor = false;
            devamButton.Click += devamButton_Click;
            // 
            // aracOzellik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(devamButton);
            Controls.Add(elektrikRadioButton);
            Controls.Add(benzinRadioButton);
            Controls.Add(label7);
            Controls.Add(modelkTextBox);
            Controls.Add(label5);
            Controls.Add(markaTextBox);
            Controls.Add(label6);
            Controls.Add(renkTextBox);
            Controls.Add(label4);
            Controls.Add(fiyatTextBox);
            Controls.Add(label3);
            Controls.Add(plakaTextBox);
            Controls.Add(label2);
            Controls.Add(yilTextBox);
            Controls.Add(label1);
            Name = "aracOzellik";
            Text = "aracOzellik";
            Load += aracOzellik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox yilTextBox;
        private TextBox plakaTextBox;
        private TextBox fiyatTextBox;
        private TextBox renkTextBox;
        private TextBox modelkTextBox;
        private TextBox markaTextBox;
        private Label label7;
        private RadioButton benzinRadioButton;
        private RadioButton elektrikRadioButton;
        private Button devamButton;
    }
}