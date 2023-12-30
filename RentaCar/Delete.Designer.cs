namespace RentaCar
{
    partial class Delete
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
            Silbutton1 = new Button();
            textbox = new Label();
            deletetextBox1 = new TextBox();
            SuspendLayout();
            // 
            // Silbutton1
            // 
            Silbutton1.Location = new Point(305, 290);
            Silbutton1.Name = "Silbutton1";
            Silbutton1.Size = new Size(247, 77);
            Silbutton1.TabIndex = 0;
            Silbutton1.Text = "Sil";
            Silbutton1.UseVisualStyleBackColor = true;
            Silbutton1.Click += Silbutton1_Click;
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Location = new Point(125, 81);
            textbox.Name = "textbox";
            textbox.Size = new Size(168, 20);
            textbox.TabIndex = 1;
            textbox.Text = "Silmek için plaka giriniz.";
            // 
            // deletetextBox1
            // 
            deletetextBox1.Location = new Point(351, 78);
            deletetextBox1.Name = "deletetextBox1";
            deletetextBox1.Size = new Size(125, 27);
            deletetextBox1.TabIndex = 2;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deletetextBox1);
            Controls.Add(textbox);
            Controls.Add(Silbutton1);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Silbutton1;
        private Label textbox;
        private TextBox deletetextBox1;
    }
}