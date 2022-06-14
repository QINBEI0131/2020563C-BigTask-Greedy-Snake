using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace BigTaskTest01.Components
{
    class SnakeUnit
    {
        #region 身体单元坐标
        private Position pos;
        public  Position Pos { get => pos; set => pos = value; }
        #endregion
       
        #region 身体单元颜色
        //身体单元
        //颜色
        private Color color = Color.Green; public Color Color { get => color; set => color = value; }
        

        #endregion

        #region 各种方式的提供函数们
        public SnakeUnit(int rowIndex,int colIndex)
        {
            this.pos.rowIndex = rowIndex;
            this.pos.colIndex = colIndex;

        }
        public SnakeUnit(int rowIndex, int colIndex,Color color)
       :this(rowIndex,colIndex)
        {
            this.color = color;
        }

        public SnakeUnit (Position pos)
        {
            this.Pos = pos;
        }
        public SnakeUnit(Position pos,Color color)
        :this(pos)
        {
            this.color = color;
        }
        #endregion

        #region 根据当前自身单元绘制自己  
        /// <summary>
        /// 据自己的做标记及其颜色自己绘制
        /// </summary>
        /// <param name="g"></param>
        public void DrawMe(Graphics g)
        {
            //将当前身体单元所在的单元格填充为当前身体单元对象的颜色
            SolidBrush brush = new SolidBrush(this.color);
            g.FillRectangle(brush,new Rectangle(this.pos.colIndex*ToolHelp.SquLength+1, this.pos.rowIndex * ToolHelp.SquLength + 1,
                ToolHelp.SquLength-1, ToolHelp.SquLength - 1));


        }
        #endregion

        #region 方向默认向左
        
        private Direction dir = Direction.Left;
        internal Direction Dir { get => dir; set => dir = value; }
      
        #endregion

        #region 上下左右移动的函数
        public void MoveToLeft()
        {
            //left colpos-1
            this.pos.colIndex--;

        }
        public void MoveToUp()
        {
            //up rowpos-1
            this.pos.rowIndex--;

        }
        public void MoveToRight()
        {
            this.pos.colIndex++;

        }
        public void MoveToDown()
        {
            this.pos.rowIndex++;

        }
        #endregion

        #region 根据当前身体所在单元所在的单元格的颜色填充为背景色
        public void WipeMe(Graphics g)
        {
            //根据当前身体所在单元所在的单元格的颜色填充为背景色
            SolidBrush brush = new SolidBrush(ToolHelp.Groundcolor);
            g.FillRectangle(brush, new Rectangle(this.pos.colIndex * ToolHelp.SquLength + 1, this.pos.rowIndex * ToolHelp.SquLength + 1,
                ToolHelp.SquLength - 1, ToolHelp.SquLength - 1));
        }
        #endregion

        #region 身体单元移动的旧方向
        private Direction oldDir = Direction.Left;
        internal Direction OldDir { get => oldDir; set => oldDir = value; }
        #endregion
    }
}
