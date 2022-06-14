using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BigTaskTest01.Components
{
    class Ground
    {
        //二维数组，用来代表地图上的每一个单元格的类型
        //数组中每一个元素的值对应了每一个格子的类型
        //block[3,2]，代表地图上第三行的第二列
        //在创建Ground对象以后，这个blocks数组的每一个元素的值都是Blank；
        private GroundUnitType[,] blocks = new GroundUnitType[ToolHelp.RowCount, ToolHelp.ColCount];
        /// <summary>
        /// 随机生成对象
        /// </summary>
        /// <param name="g"></param>
        private RandomMaker maker = new RandomMaker();
        //随机的产生1个行列坐标，把数组对应的元素改为食物，然后把食物画出来
        public void MakeAFood(Graphics g,Snake snake)
        {
            loop:
            Position pos = maker.GetARandomPosition();
            foreach(SnakeUnit u in snake.body)
            {
                if (u.Pos.rowIndex == pos.rowIndex && u.Pos.colIndex == pos.colIndex)
                {
                    goto loop;
                }
            }
            blocks[pos.rowIndex, pos.colIndex] = GroundUnitType.Food;
            Brush brush = new SolidBrush(ToolHelp.FoodColor);
            g.FillRectangle(brush, new Rectangle(pos.colIndex*ToolHelp.SquLength+1, pos.rowIndex * ToolHelp.SquLength + 1, ToolHelp.SquLength - 1, ToolHelp.SquLength - 1));
            
        }
        //背景类，1.画背景
        public void DrawMe(Graphics g)
        {
  
            for (int rowIndex = 0; rowIndex < ToolHelp.RowCount; rowIndex++)//外层循环 控制行数
            {
                for (int colIndex = 0; colIndex <ToolHelp.ColCount; colIndex++)//内层循环，控制列数
                {
                    Pen pen = new Pen(ToolHelp.LineColor);
                    //x坐标：列数*小方格的宽度，y坐标：行数*小方格高度
                    g.DrawRectangle(pen, new Rectangle(ToolHelp.SquLength * colIndex, ToolHelp.SquLength * rowIndex, ToolHelp.SquLength, ToolHelp.SquLength));
                    SolidBrush brush = new SolidBrush(ToolHelp.Groundcolor);
                    g.FillRectangle(brush, new Rectangle(ToolHelp.SquLength * colIndex + 1, ToolHelp.SquLength * rowIndex + 1, ToolHelp.SquLength - 1, ToolHelp.SquLength - 1));
                    //地图绘制完毕
                }
            }
            //绘制蛇初体不动
            //int midRow = rowCount / 2;
            //int midCol = colCount / 2;
            //g.FillRectangle(Brushes.Green, new Rectangle(squlength * midCol + 1, squlength * midRow + 1, squlength - 1, squlength - 1));
            //g.FillRectangle(Brushes.Green, new Rectangle(squlength * (midCol + 1) + 1, squlength * midRow + 1, squlength - 1, squlength - 1));
            //g.FillRectangle(Brushes.Green, new Rectangle(squlength * (midCol + 2) + 1, squlength * midRow + 1, squlength - 1, squlength - 1));
        }
        public bool IsMoveable(Snake snake)
        {
            //取出蛇头坐标
            Position pos = snake.SnakeHead.Pos;
            switch (snake.SnakeHead.Dir)
            {
                case Direction.Left:
                    pos.colIndex--;
                    break;
                case Direction.Up:
                    pos.rowIndex--;
                    break;
                case Direction.Right:
                    pos.colIndex++;
                    break;
                case Direction.Down:
                    pos.rowIndex++;
                    break;
                default:
                    break;
            }
            if (pos.colIndex < 0 || pos.rowIndex < 0 || pos.colIndex >= ToolHelp.ColCount|| pos.rowIndex >=ToolHelp.RowCount )
             {
              return false;
              }
            //switch执行完毕后，pos为蛇头的下一个坐标，切记没有去改蛇头坐标
            //判断下一个坐标是否越界
            return true;

            //判断越界
        }


        //判断蛇是否吃到食物
        public bool IsEatFood(Snake snake)
        {
            //取出蛇头的坐标
            Position pos = snake.SnakeHead.Pos;
            //以蛇头的坐标当二维数组的下标，取出对应的元素的值
            GroundUnitType type = blocks[pos.rowIndex, pos.colIndex];
            //若取出来的食物 那么说明吃到了
            if (type == GroundUnitType.Food)
            {
                //如果蛇头的坐标处是1个食物，吃掉以后，要将这个元素的值改回来，以免下一次再过的时候还会当做食物
                blocks[pos.rowIndex, pos.colIndex] = GroundUnitType.Blank;
                return true;
            }
            return false;
        }
    }
}


