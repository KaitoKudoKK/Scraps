﻿
namespace WinFormsApp1
{
    partial class TransactionHistorySeller
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            pesananMasuk1 = new PesananMasuk();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 157);
            button1.Name = "button1";
            button1.Size = new Size(229, 59);
            button1.TabIndex = 14;
            button1.Text = "Order Received";
            button1.UseVisualStyleBackColor = true;
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
            panel1.TabIndex = 16;
            // 
            // pesananMasuk1
            // 
            pesananMasuk1.Location = new Point(3, 239);
            pesananMasuk1.Name = "pesananMasuk1";
            pesananMasuk1.Size = new Size(1899, 666);
            pesananMasuk1.TabIndex = 17;
            // 
            // TransactionHistorySeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pesananMasuk1);
            Controls.Add(panel1);
            Name = "TransactionHistorySeller";
            Size = new Size(1902, 908);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private PesananMasuk pesananMasuk1;
        private EventHandler button1_Click;
        private EventHandler button2_Click;
        private PaintEventHandler panel1_Paint;
        private EventHandler pesananMasuk1_Load;
    }
}