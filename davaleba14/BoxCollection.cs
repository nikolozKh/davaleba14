using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba14
{
    internal class BoxCollection
    {
        private Box[] boxes;

        public BoxCollection(int size)
        {
            boxes = new Box[size];
        }

        public Box this[int index]
        {
            get => boxes[index];
            set => boxes[index] = value;
        }

        public int Length => boxes.Length;
    }
}
