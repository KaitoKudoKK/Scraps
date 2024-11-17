namespace WinFormsApp1
{
    partial class TransactionHistoryBuyer
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            beingProcessedUserControl2 = new BeingProcessedUserControl();
            completedBuyercs3 = new CompletedBuyercs();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1049, 157);
            button2.Name = "button2";
            button2.Size = new Size(229, 59);
            button2.TabIndex = 15;
            button2.Text = "Completed";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 157);
            button1.Name = "button1";
            button1.Size = new Size(229, 59);
            button1.TabIndex = 14;
            button1.Text = "Being Processed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 64F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(636, 41);
            label1.Name = "label1";
            label1.Size = new Size(603, 73);
            label1.TabIndex = 13;
            label1.Text = "Transaction History";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 238);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint_1;
            // 
            // beingProcessedUserControl2
            // 
            beingProcessedUserControl2.Dock = DockStyle.Fill;
            beingProcessedUserControl2.Location = new Point(0, 238);
            beingProcessedUserControl2.Name = "beingProcessedUserControl2";
            beingProcessedUserControl2.Size = new Size(1902, 670);
            beingProcessedUserControl2.TabIndex = 18;
            // 
            // completedBuyercs3
            // 
            completedBuyercs3.Dock = DockStyle.Fill;
            completedBuyercs3.Location = new Point(0, 0);
            completedBuyercs3.Name = "completedBuyercs3";
            completedBuyercs3.Size = new Size(1902, 908);
            completedBuyercs3.TabIndex = 19;
            // 
            // TransactionHistoryBuyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(beingProcessedUserControl2);
            Controls.Add(panel1);
            Controls.Add(completedBuyercs3);
            Name = "TransactionHistoryBuyer";
            Size = new Size(1902, 908);
            Load += TransactionHistoryBuyer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private BeingProcessedUserControl beingProcessedUserControl1;
        private CompletedBuyercs completedBuyercs1;
        private CompletedBuyercs completedBuyercs2;
        public BeingProcessedUserControl beingProcessedUserControl2;
        public CompletedBuyercs completedBuyercs3;
    }
}
