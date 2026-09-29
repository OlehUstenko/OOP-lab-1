using OOP_lab_1;

namespace OOP_lab_1.Tests
{
    [TestClass]
    public class LabTests
    {
        [TestMethod]
        public void MyArray_IndexerAndMinMax_WorksCorrectly()
        {
            //макс та мін значення в масиві
            var arr = new MyArray(3);
            arr[0] = 10;
            arr[1] = -5;
            arr[2] = 3;

            Assert.AreEqual(10, arr.MaxValueInArr());
            Assert.AreEqual(-5, arr.MinValueInArr());
        }

        [TestMethod]
        public void TRTriangle_AreaAndPerimeter()
        {
            //площа та периметр
            var tr = new TRTriangle(3, 4);

            Assert.AreEqual(6.0, tr.S(), 0.001);
            Assert.AreEqual(12.0, tr.P(), 0.001);
        }

        [TestMethod]
        public void TRTriangle_Multiply()
        {
            //множення трикутника 
            var tr = new TRTriangle(3, 4);

            TRTriangle scaled = tr * 2;

            Assert.AreEqual(6.0, scaled.SideA);
            Assert.AreEqual(8.0, scaled.SideB);
        }

        [TestMethod]
        public void TRPiramid_Volume_Calculates()
        {
            //об'єм піраміди
            var piramid = new TRPiramid(3, 4, 5);

            double volume = piramid.V();

            Assert.AreEqual(10.0, volume, 0.001);
        }

        [TestMethod]
        public void TRPiramid_Equals_SameDimensions_ReturnsTrue()
        {
            //рівність з різними катетами і одной висотою
            var p1 = new TRPiramid(3, 4, 5);
            var p2 = new TRPiramid(4, 3, 5);

            Assert.IsTrue(p1.Equals(p2));
        }
    }
}