using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BigTaskTest01
{
    public partial class Choices : Form
    {
        public static int x;
        public Choices()
        {
            InitializeComponent();
        }

        private void Choices_Load(object sender, EventArgs e)
        {

        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (radioButton1.Checked)
            {
                x = 1000;
                Thread.Sleep(x);
            }
            else if (radioButton2.Checked)
            {
                x = 500;
                Thread.Sleep(x);
            }
            else if (radioButton3.Checked)
            {
                x = 150;
                Thread.Sleep(x);
            }
            else
            {
                x = 90;
                Thread.Sleep(x);
            }
            form.Show();
            this.Hide();

        }
    }
}
