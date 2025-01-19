using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class Rectangle
    {
        #region attribute
        public int width { get; set; }
        private int height {  get; set; }   
        #endregion
        #region constructor
        public  Rectangle()
        {
            width = 0;
            height = 0;
        }
        public  Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle( int  width)
        {
            this.width = width;
            this.height = height;

        }
        public  override string ToString()
        {
            return $"Rectangle Width: {width}, Height: {height}";
        }


        #endregion


    }
}
