using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil01
{
    public class Circle
    {
// please add comment
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);

        }



    }
}
