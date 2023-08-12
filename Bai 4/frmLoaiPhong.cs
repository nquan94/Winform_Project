using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        public void Getdata()
        {
            string truyvan = "select * from LoaiPhong";
            dgvLoaiPhong.DataSource = kn.Laydulieu(truyvan);
        }
    }
}
