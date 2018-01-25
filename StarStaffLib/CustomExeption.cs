using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace StarStaffLib
{
    public class TriangleTypeExeption:Exception
    {
        public TriangleTypeExeption(string Message)
            : base(Message)
        {
        }
    }
    public class TriangleSideExeption : Exception
    {
        public TriangleSideExeption(string Message)
            : base(Message)
        {
        }
    }
    public class CircleRadiusExeption : Exception
    {
        public CircleRadiusExeption(string Message)
            : base(Message)
        {
        }
    }
}
