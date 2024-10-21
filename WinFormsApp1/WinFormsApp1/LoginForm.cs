namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public class Buyer
        {
            public int BuyerID { get; set; }
            public string LoginUsername { get; set; }
            public string LoginEmail { get; set; }
            public string Password { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public Buyer() { }
            public Buyer(string loginUsername, string loginEmail, string password)
            {
                LoginUsername = loginUsername;
                LoginEmail = loginEmail;
                Password = password;
            }
            public bool Login(string LoginUsername, string LoginEmail, string Password)
            {
                if (LoginUsername == "Steven" && LoginEmail == "kaitokudokk@gmail.com" && Password == "halo")
                {
                    BuyerID = 1;
                    Address = "Jalan Kaliurang KM 5 Pogung Baru E/17A, Sinduadi, Mlati, Sleman, DI Yogyakarta, 55284";
                    PhoneNumber = "+6282212345871";
                    return true;
                }
                else if (LoginUsername == "2" && LoginEmail == "2" && Password == "2")
                {
                    BuyerID = 2;
                    Address = "Jalan Kaliurang KM 5 Pogung Baru E/18A, Sinduadi, Mlati, Sleman, DI Yogyakarta, 55284";
                    PhoneNumber = "+6282212345872";
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F11)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.FormBorderStyle = FormBorderStyle.None;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Buyer buyer = new Buyer(tbUsername.Text, tbEmail.Text, tbPassword.Text);
            if (buyer.Login(buyer.LoginUsername, buyer.LoginEmail, buyer.Password))
            {
                MessageBox.Show("Login Berhasil");
                // Buka BuyerForm dan tutup LoginForm
                BuyerForm buyerForm = new BuyerForm();
                buyerForm.Show();
                this.Hide(); // Menyembunyikan form login setelah berhasil login
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
