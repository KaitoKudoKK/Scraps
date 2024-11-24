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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnAdd = new Button();
            btnAccount = new Button();
            label4 = new Label();
            homeSellerUserControl1 = new HomeSellerUserControl();
            accountSellerUserControl1 = new AccountSellerUserControl();
            addProductUserControl1 = new AddProductUserControl(LoginForm.currentSellerID);
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
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 86);
            panel1.TabIndex = 15;
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
            btnAdd.Location = new Point(222, -3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(241, 86);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            btnAccount.Location = new Point(473, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(215, 86);
            btnAccount.TabIndex = 14;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label4.Location = new Point(650, 25);
            label4.Name = "label4";
            label4.Size = new Size(85, 37);
            label4.TabIndex = 17;
            label4.Text = "   |   ";
            // 
            // homeSellerUserControl1
            // 
            homeSellerUserControl1.Dock = DockStyle.Fill;
            homeSellerUserControl1.Location = new Point(0, 86);
            homeSellerUserControl1.Name = "homeSellerUserControl1";
            homeSellerUserControl1.Size = new Size(1902, 947);
            homeSellerUserControl1.TabIndex = 16;
            // 
            // accountSellerUserControl1
            // 
            accountSellerUserControl1.Dock = DockStyle.Fill;
            accountSellerUserControl1.Location = new Point(0, 86);
            accountSellerUserControl1.Name = "accountSellerUserControl1";
            accountSellerUserControl1.Size = new Size(1902, 947);
            accountSellerUserControl1.TabIndex = 18;
            // 
            // addProductUserControl1
            // 
            addProductUserControl1.Dock = DockStyle.Fill;
            addProductUserControl1.ForeColor = Color.Black;
            addProductUserControl1.Location = new Point(0, 86);
            addProductUserControl1.Name = "addProductUserControl1";
            addProductUserControl1.Size = new Size(1902, 947);
            addProductUserControl1.TabIndex = 17;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(homeSellerUserControl1);
            Controls.Add(accountSellerUserControl1);
            Controls.Add(addProductUserControl1);
            Controls.Add(panel1);
            Name = "SellerForm";
            Text = "SellerForm";
            FormClosed += SellerForm_FormClosed;
            Load += SellerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMyProduct;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnAdd;
        private Label label4;
        private Button btnAccount;
        private HomeSellerUserControl homeSellerUserControl1;
        private AccountSellerUserControl accountSellerUserControl1;
        private AddProductUserControl addProductUserControl1;
    }
}