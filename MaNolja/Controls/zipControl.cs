using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolza
{
    public partial class zipControl : UserControl
    {
        public string ZipCode
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Address1
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string Address2
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public zipControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZipSearch frm = new ZipSearch();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.Zipcode;
                textBox2.Text = frm.Address1;
                textBox3.Text = frm.Address2;
            }
        }
    }
}
