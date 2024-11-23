namespace WinFormsApp1
{
    partial class BuyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerForm));
            btnHome = new Button();
            label1 = new Label();
            btnCart = new Button();
            label2 = new Label();
            btnChat = new Button();
            label3 = new Label();
            btnAccount = new Button();
            panel1 = new Panel();
            btnTransaction = new Button();
            label4 = new Label();
            transactionHistoryBuyer1 = new TransactionHistoryBuyer();
            cartUserControl1 = new CartUserControl();
            chatUserControl1 = new ChatUserControl();
            accountUserControl1 = new AccountUserControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnHome.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(41, 0);
            btnHome.Margin = new Padding(2, 2, 2, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(167, 69);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(180, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 1;
            label1.Text = "   |   ";
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.White;
            btnCart.BackgroundImageLayout = ImageLayout.None;
            btnCart.Cursor = Cursors.Hand;
            btnCart.FlatAppearance.BorderColor = Color.White;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCart.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCart.Location = new Point(213, 0);
            btnCart.Margin = new Padding(2, 2, 2, 2);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(120, 69);
            btnCart.TabIndex = 2;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label2.Location = new Point(303, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 3;
            label2.Text = "   |   ";
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
            btnChat.Location = new Point(338, 0);
            btnChat.Margin = new Padding(2, 2, 2, 2);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(125, 69);
            btnChat.TabIndex = 4;
            btnChat.Text = "Chat";
            btnChat.UseVisualStyleBackColor = false;
            btnChat.Click += btnChat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.Location = new Point(434, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 37);
            label3.TabIndex = 5;
            label3.Text = "   |   ";
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
            btnAccount.Location = new Point(468, 0);
            btnAccount.Margin = new Padding(2, 2, 2, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(172, 69);
            btnAccount.TabIndex = 6;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 69);
            panel1.TabIndex = 7;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.White;
            btnTransaction.BackgroundImageLayout = ImageLayout.None;
            btnTransaction.Cursor = Cursors.Hand;
            btnTransaction.FlatAppearance.BorderColor = Color.White;
            btnTransaction.FlatAppearance.BorderSize = 0;
            btnTransaction.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnTransaction.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Microsoft Sans Serif", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.Location = new Point(647, -1);
            btnTransaction.Margin = new Padding(2, 2, 2, 2);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(261, 69);
            btnTransaction.TabIndex = 12;
            btnTransaction.Text = "Transaction History";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label4.Location = new Point(614, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 37);
            label4.TabIndex = 11;
            label4.Text = "   |   ";
            // 
            // transactionHistoryBuyer1
            // 
            transactionHistoryBuyer1.Dock = DockStyle.Fill;
            transactionHistoryBuyer1.Location = new Point(0, 0);
            transactionHistoryBuyer1.Margin = new Padding(2, 2, 2, 2);
            transactionHistoryBuyer1.Name = "transactionHistoryBuyer1";
            transactionHistoryBuyer1.Size = new Size(1096, 599);
            transactionHistoryBuyer1.TabIndex = 8;
            // 
            // cartUserControl1
            // 
            cartUserControl1.Dock = DockStyle.Fill;
            cartUserControl1.Location = new Point(0, 0);
            cartUserControl1.Margin = new Padding(2, 2, 2, 2);
            cartUserControl1.Name = "cartUserControl1";
            cartUserControl1.Size = new Size(1096, 599);
            cartUserControl1.TabIndex = 10;
            // 
            // chatUserControl1
            // 
            chatUserControl1.Dock = DockStyle.Fill;
            chatUserControl1.Location = new Point(0, 0);
            chatUserControl1.Margin = new Padding(2, 2, 2, 2);
            chatUserControl1.Name = "chatUserControl1";
            chatUserControl1.Size = new Size(1096, 599);
            chatUserControl1.TabIndex = 11;
            // 
            // accountUserControl1
            // 
            accountUserControl1.AllowDrop = true;
            accountUserControl1.Dock = DockStyle.Fill;
            accountUserControl1.Location = new Point(0, 0);
            accountUserControl1.Margin = new Padding(2, 2, 2, 2);
            accountUserControl1.Name = "accountUserControl1";
            accountUserControl1.Size = new Size(1096, 599);
            accountUserControl1.TabIndex = 12;
            // 
            // BuyerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1096, 599);
            Controls.Add(btnHome);
            Controls.Add(btnAccount);
            Controls.Add(btnChat);
            Controls.Add(btnCart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(transactionHistoryBuyer1);
            Controls.Add(accountUserControl1);
            Controls.Add(chatUserControl1);
            Controls.Add(cartUserControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(1539, 872);
            MinimumSize = new Size(515, 296);
            Name = "BuyerForm";
            Text = "Buyer";
            FormClosed += BuyerForm_FormClosed;
            Load += BuyerForm_Load;
            KeyDown += BuyerForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label label1;
        private Button btnCart;
        private Label label2;
        private Button btnChat;
        private Label label3;
        private Button btnAccount;
        private Panel panel1;
        private HomeUserControl homeUserControl1;
        private CartUserControl cartUserControl1;
        private ChatUserControl chatUserControl1;
        private AccountUserControl accountUserControl1;
        private Button btnTransaction;
        private Label label4;
        private TransactionHistoryBuyer transactionHistoryBuyer1;
    }
}