using OOP_lab_1;

namespace Addition_to_lab_1
{
    internal class TRTriangleF : TRTriangle
    {
        public TRTriangleF() : base() { }
        public TRTriangleF(double a, double b) : base(a, b) { }
        public TRTriangleF(TRTriangleF t) : base(t) { }
        public override bool Equals (object obj)
        {

            if (obj is TRTriangleF other)
            {
                return (this.SideA == other.SideA && this.SideB == other.SideB) ||
                       (this.SideA == other.SideB && this.SideB == other.SideA);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(SideA + SideB, SideA * SideB);//для того щоб трикутник а на б та б на а мали однаковий хешкод
        }
    }
}
