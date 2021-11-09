using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Notepad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.btnOk.Enabled = false;
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if(!(this.txtWord.Text == ""))
            {
                this.btnOk.Enabled = true;
            }
            else
            {
                this.btnOk.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
