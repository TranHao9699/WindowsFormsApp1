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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void lươngChiTiếtTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            using (FormLogin formLogin = new FormLogin())
            {
                formLogin.StartPosition = FormStartPosition.CenterParent;
                formLogin.ShowDialog();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void Group_Click(object sender, EventArgs e)
        {
            //Hiển thị form group
            using (FormGroup formGroup = new FormGroup())
            {
                formGroup.StartPosition = FormStartPosition.CenterParent;
                formGroup.ShowDialog(); // Thiết lập form con
            }
        }
    }
    
}
