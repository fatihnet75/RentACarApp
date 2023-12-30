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
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Silbutton1);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
        }

        #endregion

        private Button Silbutton1;
    }
}