using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTaskTest01.Components
{
    class RandomMaker
    {
        private Random random;
        public RandomMaker() 
        {
            this.random = new Random();
        }
        private int GetARandomRowIndex()
        {
            return random.Next(0, ToolHelp.RowCount);
        }
        private int GetARandomColIndex()
        {
            return random.Next(0, ToolHelp.ColCount);
        }
        //得到一个随机坐标
        public Position GetARandomPosition()
        {
            Position p = new Position();
            p.rowIndex = this.GetARandomRowIndex();
            p.colIndex = this.GetARandomColIndex();
            return p;
        }
    }
}
