using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace BigTaskTest01.Components
{
    //提供所有需要共享的数据
    static class ToolHelp
    {
    #region 游戏面板总行数14行 + static int RowCount
        private static int rowCount = 14;
            public static int RowCount { get => rowCount; set => rowCount = value; }
        #endregion

    #region 游戏面板总列数14行 + static int ColCount
        private static int colCount = 14;

        public static int ColCount { get => colCount; set => colCount = value; }
        #endregion

    #region 方块边长
        private static int squLength;
       public static int SquLength { get => squLength; set => squLength = value; }
        #endregion

    #region 初始化游戏环+ static  void InitializeEnvironment(int panelWidth, int panelHeight)
        public static  void InitializeEnvironment(int panelWidth, int panelHeight)
        {
            //据面板宽度高度 总行数列数来为squlength赋值
            //据传入宽度算出小方格宽度
            int width = panelWidth / colCount;
            //据传入宽度算出小方格高度
            int height = panelHeight / rowCount;
            //取较小变赋值边长
            squLength = width > height ? height : width;
        }
        #endregion

    #region 默认黑色线条
        private static Color lineColor = Color.Black;
        public static Color LineColor { get => lineColor; set => lineColor = value; }

        #endregion

    #region 默认蓝背景+static Color groundcolor
        private static Color groundcolor = Color.Azure;
        public static Color Groundcolor { get => groundcolor; set => groundcolor = value; }
        #endregion

    #region 食物默认颜色
        private static Color foodColor = Color.Red;
        public static Color FoodColor { get => foodColor; set => foodColor = value; }

        #endregion
        #region 分数变量
        private static int score;
        public static int Score { get =>ToolHelp. score; set =>ToolHelp.score = value; }
        #endregion
    }


}
