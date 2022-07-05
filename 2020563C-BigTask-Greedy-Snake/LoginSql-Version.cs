using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTaskTest01
{
    public partial class LoginSql_Version : Form
    {
        public static string thisStr = @"Data Source=.; Database = GREEDYSNAKE-USER; Integrated Security=true";
        public LoginSql_Version()
        {
            InitializeComponent();
        }

        private void btnLoginSql_Click(object sender, EventArgs e)
        {
            SqlConnection thisConnect = new SqlConnection(thisStr);
            SqlCommand cmd = new SqlCommand("login_proc", thisConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", txtName.Text);
            cmd.Parameters.AddWithValue("@pws", txtPsw.Text);
            SqlParameter par = cmd.Parameters.Add("@status", SqlDbType.Int);　　//定义输出参数
            par.Direction = ParameterDirection.Output;　　//参数类型为Output
            thisConnect.Open();
            cmd.ExecuteNonQuery();
            switch ((int)par.Value)
            {
                case 0:
                    //MessageBox.Show("登陆成功！");
                    this.Hide();
                    Choices choices = new Choices();
                    MessageBox.Show("Loading.........");
                    choices.Show();
                    break;
                case 1:
                    MessageBox.Show("管理员账号不存在，请重试");
                    break;
                case 2:
                    MessageBox.Show("管理员密码错误，请重试");
                    break;
            }
            thisConnect.Close();
            thisConnect.Dispose();
        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
