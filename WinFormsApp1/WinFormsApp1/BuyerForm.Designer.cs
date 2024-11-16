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
            btnHome.Location = new Point(51, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(209, 86);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(225, 20);
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
            btnCart.Location = new Point(266, 0);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(150, 86);
            btnCart.TabIndex = 2;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label2.Location = new Point(379, 20);
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
            btnChat.Location = new Point(422, 0);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(156, 86);
            btnChat.TabIndex = 4;
            btnChat.Text = "Chat";
            btnChat.UseVisualStyleBackColor = false;
            btnChat.Click += btnChat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.Location = new Point(543, 20);
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
            btnAccount.Location = new Point(585, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(215, 86);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 86);
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
            btnTransaction.Location = new Point(809, -1);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(326, 86);
            btnTransaction.TabIndex = 12;
            btnTransaction.Text = "Transaction History";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label4.Location = new Point(767, 19);
            label4.Name = "label4";
            label4.Size = new Size(85, 37);
            label4.TabIndex = 11;
            label4.Text = "   |   ";
            // 
            // transactionHistoryBuyer1
            // 
            transactionHistoryBuyer1.Dock = DockStyle.Fill;
            transactionHistoryBuyer1.Location = new Point(0, 86);
            transactionHistoryBuyer1.Name = "transactionHistoryBuyer1";
            transactionHistoryBuyer1.Size = new Size(1902, 947);
            transactionHistoryBuyer1.TabIndex = 8;
            // 
            // BuyerForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(transactionHistoryBuyer1);
            Controls.Add(btnHome);
            Controls.Add(btnAccount);
            Controls.Add(btnChat);
            Controls.Add(btnCart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            KeyPreview = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 360);
            Name = "BuyerForm";
            Text = "USer";
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