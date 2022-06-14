using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTaskTest01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Choices choices = new Choices();
        private static int pwdNum = 0;
        private static int RuleNum = 3;

        private void btnTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U Code:012031");

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text == "012031")
            {
                this.Hide();
                MessageBox.Show("Loading.........");
                choices.Show();
            }
            else
            {
                pwdNum++;
                if (pwdNum < RuleNum)
                {
                    MessageBox.Show("Error,U've wasted" + "‘" +pwdNum+"’" + "chances to Log in our game");
                    txtPwd.Text = "";
                }
                else
                {
                    MessageBox.Show("Reach the maximum number,please look through my Tip");
                    this.Hide();
                }

            }
        }
    }
}
