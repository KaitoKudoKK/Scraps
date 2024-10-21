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
            homeUserControl1 = new HomeUserControl();
            cartUserControl1 = new CartUserControl();
            chatUserControl1 = new ChatUserControl();
            accountUserControl1 = new AccountUserControl();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Montserrat", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label1.Font = new Font("Montserrat Medium", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(225, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 44);
            label1.TabIndex = 1;
            label1.Text = "   |   ";
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.White;
            btnCart.BackgroundImageLayout = ImageLayout.None;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Montserrat", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label2.Font = new Font("Montserrat Medium", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label2.Location = new Point(379, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 44);
            label2.TabIndex = 3;
            label2.Text = "   |   ";
            // 
            // btnChat
            // 
            btnChat.BackColor = Color.White;
            btnChat.BackgroundImageLayout = ImageLayout.None;
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Montserrat", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label3.Font = new Font("Montserrat Medium", 32F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            label3.Location = new Point(543, 20);
            label3.Name = "label3";
            label3.Size = new Size(83, 44);
            label3.TabIndex = 5;
            label3.Text = "   |   ";
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.White;
            btnAccount.BackgroundImageLayout = ImageLayout.None;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Montserrat", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 86);
            panel1.TabIndex = 7;
            // 
            // homeUserControl1
            // 
            homeUserControl1.Dock = DockStyle.Fill;
            homeUserControl1.Location = new Point(0, 86);
            homeUserControl1.Name = "homeUserControl1";
            homeUserControl1.Size = new Size(1902, 947);
            homeUserControl1.TabIndex = 8;
            // 
            // cartUserControl1
            // 
            cartUserControl1.Dock = DockStyle.Fill;
            cartUserControl1.Location = new Point(0, 0);
            cartUserControl1.Name = "cartUserControl1";
            cartUserControl1.Size = new Size(1902, 1033);
            cartUserControl1.TabIndex = 0;
            // 
            // chatUserControl1
            // 
            chatUserControl1.Dock = DockStyle.Fill;
            chatUserControl1.Location = new Point(0, 0);
            chatUserControl1.Name = "chatUserControl1";
            chatUserControl1.Size = new Size(1902, 1033);
            chatUserControl1.TabIndex = 9;
            // 
            // accountUserControl1
            // 
            accountUserControl1.Dock = DockStyle.Fill;
            accountUserControl1.Location = new Point(0, 0);
            accountUserControl1.Name = "accountUserControl1";
            accountUserControl1.Size = new Size(1902, 1033);
            accountUserControl1.TabIndex = 10;
            // 
            // BuyerForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnHome);
            Controls.Add(btnAccount);
            Controls.Add(btnChat);
            Controls.Add(btnCart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(homeUserControl1);
            Controls.Add(panel1);
            Controls.Add(cartUserControl1);
            Controls.Add(chatUserControl1);
            Controls.Add(accountUserControl1);
            KeyPreview = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(640, 360);
            Name = "BuyerForm";
            Text = "BuyerForm";
            FormClosed += BuyerForm_FormClosed;
            Load += BuyerForm_Load;
            KeyDown += BuyerForm_KeyDown;
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
    }
}