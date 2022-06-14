using BigTaskTest01.Components;
using System;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTaskTest01
{
    /// <summary>
    /// 控制整个游戏的逻辑
    /// </summary>
    class GameController
    {
        //游戏控制器控制的背景对象
        private Ground ground;
        //游戏控制器控制的蛇对象
        private Snake snake;
        private Graphics graphics;
        private Form1 mform;
        /// <summary>
        /// 构造函数初始化当前的背景字段与蛇字段
        /// </summary>
        public GameController(Graphics g,Form1 mform)
        {
            this.graphics = g;
            this.mform = mform;
            this.ground = new Ground();
            this.snake = new Snake();
         }
        public void NewGame()
        {
            //分数重置
            ToolHelp.Score = 0;
            //分数重置显示
            mform.ShowScore();
            //画背景方格
            this.ground.DrawMe(graphics);
            //画蛇
            this.snake.DrawMe(graphics);
            //画食物
            this.ground.MakeAFood(graphics,snake);
            Thread snakeMobeThread = new Thread(SnakeAutoMoveThread);
            //创建一个线程
            //设置后台线程 ，start方法开启
            snakeMobeThread.IsBackground = true;
            snakeMobeThread.Start();
        }
        public void SnakeAutoMoveThread()
        {   //无论身体单元处于什么坐标位置啊都还在移动
            //目前之所以会出去是因为死循环
            //蛇头坐标小于零结束
            while (ground.IsMoveable(snake))
            {
                //判断一下蛇是否吃到了食物
                if(ground.IsEatFood(snake))
                {
                    snake.AddBody();
                    //再次随机产生1个食物
                    
                    ground.MakeAFood(graphics,snake);
                    ToolHelp.Score++;
                    mform.ShowScore();
                    
                    
                }
                //让蛇动一下
                snake.AutoMove(graphics);
                Thread.Sleep(Choices.x);
            }
            graphics.DrawString("Game Over!", new Font("宋体", 40), Brushes.Aqua, new PointF(60, 16));
        }
        /// <summary>
        /// 控制移动
        /// </summary>
        /// <param name="keyData"></param>
        public void ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    snake.SnakeHead.Dir = Direction.Up;
                    break;
                case Keys.Down:
                    snake.SnakeHead.Dir = Direction.Down;
                    break;
                case Keys.Left:
                    snake.SnakeHead.Dir = Direction.Left;
                    break;
                case Keys.Right:
                    snake.SnakeHead.Dir = Direction.Right;
                    break;
                
            }

        }
    }
}
