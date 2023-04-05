using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utils
{
    public class BasicUtils
    {

        static Random random = new Random();

        public static Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public static Point GetRandomPosition(Size parent, Size child)
        {
            return new Point
            {
                X = random.Next(parent.Width - child.Width),
                Y = random.Next(parent.Height - child.Height)
            };
        }
    }
}
