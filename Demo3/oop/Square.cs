using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Square
    {
        private int length;

        public int Length
        {
            get
            {
                return length; 
            }
            set
            {
                if (value < 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }
        private int width;


        public int Width
        {
            get 
            {
                return width;
            }
            set
            {
                if (value < 0)
                { 
                    width = 0;
                }
                else
                {
                    width = value;
                }

            }
        }

        public int area()
        {
            int result = 0;
            result = width * length;
            return result;
        }
    }
}
