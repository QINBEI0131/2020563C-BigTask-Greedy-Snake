
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using BigTaskTest01.Components;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTaskTest01
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 游戏控制器对象
        /// </summary>
        private GameController gameController;
        public Form1()
        {
            InitializeComponent();
            //在窗体构造函数中调用ToolHelp方法
            Components.ToolHelp.InitializeEnvironment(this.gamepanel.Width, this.gamepanel.Height);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnbegin_Click(object sender, EventArgs e)
        {
            //创建一个画家对象
            Graphics g = Graphics.FromHwnd(this.gamepanel.Handle);
            //创建一个游戏控制器对象
            gameController = new GameController(g,this);
            //调用开始游戏
            gameController.NewGame();
        }

        //键盘控制器，自动调用方法
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //将用户按下的案件传递给控制器对象
            this.gameController.ProcessDialogKey(keyData);
            return base.ProcessDialogKey(keyData);
        }
      public void ShowScore()
        {
            labScore.Text = "Score:"+ToolHelp.Score;
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            Choices choices = new Choices();
            choices.Show();
            this.Close();
        }
    }
}
   
