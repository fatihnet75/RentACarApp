using RentaCar.Service;

namespace RentaCar
{
    public partial class Arac_bilgileri : Form
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
            devamButton = new Button();
            dataGridView1 = new DataGridView();
            plakaText = new TextBox();
            toplambütce = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // devamButton
            // 
            devamButton.BackColor = SystemColors.GrayText;
            devamButton.ForeColor = SystemColors.ActiveCaptionText;
            devamButton.Location = new Point(146, 367);
            devamButton.Margin = new Padding(3, 4, 3, 4);
            devamButton.Name = "devamButton";
            devamButton.Size = new Size(93, 52);
            devamButton.TabIndex = 0;
            devamButton.Text = "DEVAM";
            devamButton.UseVisualStyleBackColor = false;
            devamButton.Click += devamButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(648, 217);
            dataGridView1.TabIndex = 1;
            // 
            // plakaText
            // 
            plakaText.BackColor = SystemColors.ControlLight;
            plakaText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            plakaText.Location = new Point(122, 305);
            plakaText.Multiline = true;
            plakaText.Name = "plakaText";
            plakaText.Size = new Size(137, 40);
            plakaText.TabIndex = 2;
            plakaText.Text = "Plaka Giriniz";
            // 
            // toplambütce
            // 
            toplambütce.AutoSize = true;
            toplambütce.Location = new Point(394, 317);
            toplambütce.Name = "toplambütce";
            toplambütce.Size = new Size(0, 20);
            toplambütce.TabIndex = 3;
            // 
            // Arac_bilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(649, 601);
            Controls.Add(toplambütce);
            Controls.Add(plakaText);
            Controls.Add(dataGridView1);
            Controls.Add(devamButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Arac_bilgileri";
            Text = "kiralamaBilgileri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button devamButton;
        private DataGridView dataGridView1;
        private TextBox plakaText;
        private Label toplambütce;
    }
}
