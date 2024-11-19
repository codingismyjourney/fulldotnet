using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class fiveInheritanceClassBase
    {
        protected int _width;
        protected int _height;

        public int width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
