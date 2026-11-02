using System;
using System.Collections.Generic;
using System.Text;

namespace Addition_to_lab_1
{
    internal class TRPiramidF : TRPiramid
    {
        public TRPiramidF(double a, double b, double h) : base(a, b, h) { }

        public override bool Equals(object obj)
        {
            if (obj is TRPiramidF other)
            {
                return base.Equals(other) && this.Height == other.Height;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Height);
        }

    }
}
