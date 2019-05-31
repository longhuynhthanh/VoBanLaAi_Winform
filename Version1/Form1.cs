using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ListAnhVo;
        string[,] ThongTin = {
                               { "Ngoại Hình: Cười Đẹp", "Tính Tình: Tốt Bụng"},
                               {"Ngoại Hình: Mắt Đẹp", "Tính Tình: Siêng Năng"},
                               {"Ngoại Hình: Da Đẹp", "Tính Tình: Tốt Tính"},
                               {"Ngoại Hình: Dáng Đẹp", "Tính Tình: Hiền Lành" },
                               { "Ngoại Hình: Dáng Chuẩn", "Tính Tình: Kute" }
                             };
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 600);
            ListAnhVo = new string[5];
            for (int i = 1; i <= 5; i++)
            {
                ListAnhVo[i - 1] = "VoTuongLai/" + i + ".png";
            }
            ThemHinhVo();
        }

        private void ThemHinhVo()
        {
            Random rd = new Random();
            index = rd.Next(0, ListAnhVo.Length);

            ptrVo.Image = Image.FromFile(ListAnhVo[index]);
            ptrVo.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int i = 0; i < ThongTin.GetLength(1); i++)
            {
                lblThongTin.Text += "\n" + ThongTin[index, i];
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblThongTin.ResetText();
            ThemHinhVo();
        }
    }
}
