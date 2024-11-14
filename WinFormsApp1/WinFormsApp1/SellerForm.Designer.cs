namespace WinFormsApp1
{
    partial class SellerForm
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
            btnMyProduct = new Button();
            btnAccount = new Button();
            btnChat = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            HomeSellerUserControl = new HomeSellerUserControl();
            btnAdd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMyProduct
            // 
            btnMyProduct.BackColor = Color.White;
            btnMyProduct.BackgroundImageLayout = ImageLayout.None;
            btnMyProduct.Cursor = Cursors.Hand;
            btnMyProduct.FlatAppearance.BorderColor = Color.White;
            btnMyProduct.FlatAppearance.BorderSize = 0;
            btnMyProduct.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnMyProduct.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMyProduct.FlatStyle = FlatStyle.Flat;
            btnMyProduct.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyProduct.Location = new Point(0, 0);
            btnMyProduct.Name = "btnMyProduct";
            btnMyProduct.Size = new Size(209, 86);
            btnMyProduct.TabIndex = 8;
            btnMyProduct.Text = "My Product";
            btnMyProduct.UseVisualStyleBackColor = false;
            btnMyProduct.Click += btnMyProduct_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.White;
            btnAccount.BackgroundImageLayout = ImageLayout.None;
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.FlatAppearance.BorderColor = Color.White;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAccount.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccount.Location = new Point(636, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(215, 86);
            btnAccount.TabIndex = 14;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnChat
            // 
            btnChat.BackColor = Color.White;
            btnChat.BackgroundImageLayout = ImageLayout.None;
            btnChat.Cursor = Cursors.Hand;
            btnChat.FlatAppearance.BorderColor = Color.White;
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnChat.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChat.Location = new Point(473, 0);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(156, 86);
            btnChat.TabIndex = 12;
            btnChat.Text = "Chat";
            btnChat.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.Location = new Point(594, 20);
            label3.Name = "label3";
            label3.Size = new Size(85, 37);
            label3.TabIndex = 13;
            label3.Text = "   |   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label2.Location = new Point(430, 20);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 11;
            label2.Text = "   |   ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(174, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 9;
            label1.Text = "   |   ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnMyProduct);
            panel1.Controls.Add(btnChat);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 86);
            panel1.TabIndex = 15;
            // 
            // HomeSellerUserControl
            // 
            HomeSellerUserControl.Location = new Point(5, 88);
            HomeSellerUserControl.Name = "HomeSellerUserControl";
            HomeSellerUserControl.Size = new Size(1897, 945);
            HomeSellerUserControl.TabIndex = 16;
            HomeSellerUserControl.Load += homeSellerUserControl1_Load;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(226, -3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(241, 86);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(HomeSellerUserControl);
            Controls.Add(panel1);
            Name = "SellerForm";
            Text = "SellerForm";
            Load += SellerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMyProduct;
        private Button btnAccount;
        private Button btnChat;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private HomeSellerUserControl HomeSellerUserControl;
        private Button btnAdd;
    }
}