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
    public partial class Landing_mode : Form
    {
        public Landing_mode()
        {
            InitializeComponent();
        }

        private void btnBetaUser_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            LoginSql_Version adm = new LoginSql_Version();
            adm.Show();
            this.Hide();
        }
    }
}
