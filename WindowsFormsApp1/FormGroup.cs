using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
        }

        private void DisplayGroup()
        {
            using ( Context db = new Context())
            {
                //Truy xuất tất cả các bản ghi Blog của dữ liệu
                var query = from g in db.Groups
                            orderby g.GroupName
                            select g;
                //Xóa lisbox trước
                listBox1.Items.Clear();

                //Duyệt tất cả các bản ghi được thêm vào listbox
                foreach (var item in query)
                {
                    listBox1.Items.Add(item.GroupName);
                }
            } 
        }
        private void FormGroup_Load(object sender, EventArgs e)
        {

        }

        private void FormGroup_Shown(object sender, EventArgs e)
        {
            DisplayGroup();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Đọc nội dung nhập vào từ ô text
            var name = textBox1.Text;
            // Tạo một nội dung blog ( tạo bản ghi)
            var item = new Group { GroupName = name };
            // Thêm vào cơ sở dữ liệu
            using (var db = new Context())
            {
                // Thêm đối tượng vào thực thể blog
                db.Groups.Add(item);
                // Lưu vào cơ sở dữ liệu
                db.SaveChanges();
                //Gọi hàm hiển thị danh sách bản ghi blog
                DisplayGroup();
            }
        }
    }
}
