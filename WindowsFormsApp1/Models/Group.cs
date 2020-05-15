using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    public class Group
    {
        [Key]

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Desc { get; set; }
        public virtual List<User> Users { get; } // vì chỉ đọc nên ko để set;
    }
}