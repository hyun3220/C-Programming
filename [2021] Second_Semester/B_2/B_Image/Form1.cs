using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int imgCount = 0;   // 이미지 번호

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picImg.Image = (Image)this.ImgList.Images[0];
            imgCount = this.ImgList.Images.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            imgCount--;

            if(imgCount < 0)
            {
                imgCount = this.ImgList.Images.Count - 1;
            }

            this.picImg.Image = (Image)this.ImgList.Images[imgCount];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            imgCount++;

            if(imgCount >= ImgList.Images.Count)
            {
                imgCount = this.ImgList.Images.Count - 1;
            }

            this.picImg.Image = (Image)this.ImgList.Images[imgCount];
        }
    }
}
