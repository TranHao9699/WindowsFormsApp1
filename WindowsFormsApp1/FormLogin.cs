using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        List<User> users;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           using (var db = new Context())
           {
                var query = from u in db.Users
                            select u;
                users = query.ToList<User>();
                if (users.Count == 0)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        string pw = GetMd5Hash(md5Hash, "123456");
                        User user = new User
                        {
                            DisplayName = "Administrator",
                            Username = "Admin",
                            Password = pw
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                        //textBoxTenDangNhap.Text = "Admin";
                        //textBoxMatKhau.Text = "123456";
                        //query = from u in db.Users
                            //select u;
                        users = query.ToList<User>();
                    }
                }
                
           }
        }
        

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        /// <summary>
        /// xac thuc ng dung
        /// </summary>
        /// <param name="username"> Ten mat khau</param>
        /// <param name="password"> Mat khau</param>
        /// <returns> true Dang nhap thanh cong</returns>
        bool IsAuthorized(string username, string password)
        {
           using (MD5 md5Hash = MD5.Create())
            {
                string pw = GetMd5Hash(md5Hash, password);
                foreach (var user in users)
                {
                    if (user.Username == username && user.Password == pw)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelChanTrang_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            //string username = textBoxTenDangNhap.Text.Trim();
            //string password = textBoxMatKhau.Text.Trim();
            //if (username == "Admin" && password == "123456")
            //{
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            //}
         // Xác thực người dùng
            if (IsAuthorized(textBoxTenDangNhap.Text, textBoxMatKhau.Text))
            {
                // Người dùng được chấp nhận đóng form
                this.Close();
            }
            else
            {
                const string message = " Sai tên đăng nhập hoặc mật khẩu";
                const string caption = " Thông báo";
                _ = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
        }

        private void labelDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTieuDe_Enter(object sender, EventArgs e)
        {

        }
    }
}
