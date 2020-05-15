using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public class Context: DbContext
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<Group> Groups { get; set; }
    }
}