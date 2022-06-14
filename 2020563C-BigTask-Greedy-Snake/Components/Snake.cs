using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace BigTaskTest01.Components
{
    class Snake
    {
        //用一个字段来表示蛇的小方格
        //用集合来存储蛇的身体单元，所以选择链表
        //后续要快速的得到蛇头与蛇尾
        public LinkedList<SnakeUnit> body= new LinkedList<SnakeUnit>();
        public SnakeUnit SnakeHead
        {
            get
            {
                return this.body.First.Value;
            }
        }
        public Snake()
        {
            //创造一个身体单元对象
            //坐标应在正中行，从toolhelp里调出来总行数和总列数
            SnakeUnit unit = new SnakeUnit(ToolHelp.RowCount/2,ToolHelp.ColCount/2);
            //加到链表当表头
            body.AddFirst(unit);
            AddBody();
            AddBody();
        }
        public void AddBody()
        {
            Position pos = body.Last.Value.Pos;
            //行不变 列加1
            pos.colIndex++;
            //坐标为pos
            SnakeUnit unit = new SnakeUnit(pos);
            //将身体单元对象加入身体中
            body.AddLast(unit);
        }
        //自己画蛇的方法
        public void DrawMe(Graphics g)
        {
            //遍历body链表中里的每一个子填充绘画
            foreach(SnakeUnit u in body)
            {
                u.DrawMe(g);
            }
        }
        private void WipeMe(Graphics g)
        {
            //自己擦除自己
            foreach (SnakeUnit u in body)
            {
                u.WipeMe(g);
            }
        }
          public void AutoMove(Graphics g)
        {
            //擦除整条蛇
            this.WipeMe(g);
            LinkedListNode<SnakeUnit> node = body.First;
            while(node!=null)
            {
                //先将遍历出来的元素按照现在的方向更改坐标
                switch (node.Value.Dir)
                {
                    case Direction.Left:
                        node.Value.MoveToLeft();
                        break;
                    case Direction.Up:
                        node.Value.MoveToUp();
                        break;
                    case Direction.Right:
                        node.Value.MoveToRight();
                        break;
                    case Direction.Down:
                        node.Value.MoveToDown();
                        break;

                }
                //将刚才的移动的方向保存起来
                node.Value.OldDir = node.Value.Dir;
                //设置下一次移动的方向
                if(node.Previous!=null)
                {
                node.Value.Dir = node.Previous.Value.OldDir;
                }

                node = node.Next;
            }
            //根据每一个身体单元的前进方向 改变身体的单元坐标
            //将遍历出来的元素方向做判断
            //foreach (SnakeUnit u in body)
            //{
            //    switch (u.Dir)//判断遍历出来的身体单元的前进方向
            //    {
            //        case Direction.Left:
            //            u.MoveToLeft();
            //            break;
            //        case Direction.Up:
            //            u.MoveToUp();
            //            break;
            //        case Direction.Right:
            //            u.MoveToRight();
            //            break;
            //        case Direction.Down:
            //            u.MoveToDown();
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //根据新的坐标绘制整条的蛇
            this.DrawMe(g);
       
}

    }
}
