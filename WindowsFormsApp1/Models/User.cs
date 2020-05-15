using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    public class User
    {
        // Tên đăng nhập
        [Key]
        public string Username { get; set; }
        // Mật khẩu
        public string Password { get; set; }

        // Tên hiển thị
        public string DisplayName { get; set; }

        public virtual Group Group { get; set; }
        
    }
}