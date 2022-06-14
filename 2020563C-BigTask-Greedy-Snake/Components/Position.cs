using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTaskTest01.Components
{
    struct Position
    {
        //身体单元坐标
        //行列坐标
        public int rowIndex;
        public int colIndex;
        //构造函数 初始化当前结构体对象
        public Position(int rowIndex,int colIndex)
        {
            this.rowIndex = rowIndex;
            this.colIndex = colIndex;
        }
    }
}
