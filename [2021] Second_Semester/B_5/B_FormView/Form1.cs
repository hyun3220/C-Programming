using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_FormView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SetText = this.btnModal.Text + " 실행";
            form2.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.SetText = this.btnModaless.Text + " 실행";
            form3.ShowDialog();
        }
    }
}
