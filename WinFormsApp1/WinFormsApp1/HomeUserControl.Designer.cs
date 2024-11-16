namespace WinFormsApp1
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 64F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(108, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 73);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeUserControl";
            Size = new Size(1664, 681);
            Load += HomeUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
    }
}
