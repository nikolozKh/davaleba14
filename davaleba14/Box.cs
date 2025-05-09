using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba14
{
    internal class Box
    {
        public double Size { get; set; }

        public Box(double size)
        {
            Size = size;
        }

        public static Box operator +(Box a, Box b) => new Box(a.Size + b.Size);
        public static Box operator -(Box a, Box b) => new Box(a.Size - b.Size);
        public static bool operator ==(Box a, Box b) => a.Size == b.Size;
        public static bool operator !=(Box a, Box b) => a.Size != b.Size;
        public static bool operator >(Box a, Box b) => a.Size > b.Size;
        public static bool operator <(Box a, Box b) => a.Size < b.Size;

        public override string ToString() => $"Box with Size: {Size}";
    }

}

