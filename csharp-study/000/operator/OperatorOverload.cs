using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.Operator
{
    [TestClass]
    public class OperatorOverload
    {
        [TestMethod]
        public void OperatorOverload_Test()
        {
            var vect1 = new Vector(3.0, 3.0, 1.0);
            var vect2 = new Vector(2.0, -4.0, -4.0);
            var vect3 = vect1 + vect2;
            
            // Check vect1.x, vect1.y, vect1.z
            Assert.AreEqual(3.0, vect1.X);
            Assert.AreEqual(3.0, vect1.Y);
            Assert.AreEqual(1.0, vect1.Z);

            // Check vect2.x, vect2.y, vect2.z
            Assert.AreEqual(2.0, vect2.X);
            Assert.AreEqual(-4.0, vect2.Y);
            Assert.AreEqual(-4.0, vect2.Z);

            // Check vect3.x, vect3.y, vect3.z
            Assert.AreEqual(5.0, vect3.X);
            Assert.AreEqual(-1.0, vect3.Y);
            Assert.AreEqual(-3.0, vect3.Z);

        }

        [TestMethod]
        public void OperatorOverload_Mul_Test()
        {
            var vect1 = new Vector(3.0, 3.0, 1.0);
            var result1 = 2.0 * vect1;
            var result2 = vect1 * 2;

            // Check result 1
            Assert.AreEqual(6.0, result1.X);
            Assert.AreEqual(6.0, result1.Y);
            Assert.AreEqual(2.0, result1.Z);

            // Check result 2
            Assert.AreEqual(6.0, result2.X);
            Assert.AreEqual(6.0, result2.Y);
            Assert.AreEqual(2.0, result2.Z);
        }

        [TestMethod]
        public void OperatorOverload_EqualSignOverload_Test()
        {
            var vect1 = new Vector(3.0, 3.0, 1.0);
            // TODO: Without ideas.
        }
    }

    struct Vector
    {
        public double X, Y, Z;

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector(Vector rhs)
        {
            X = rhs.X;
            Y = rhs.Y;
            Z = rhs.Z;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + "," + Z + ")";
        }

        public static Vector operator + (Vector lhs, Vector rhs)
        {
            var result = new Vector(lhs);
            result.X += rhs.X;
            result.Y += rhs.Y;
            result.Z += rhs.Z;
            return result;
        }

        public static Vector operator *(double lhs, Vector rhs)
        {
            return new Vector(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static Vector operator *(Vector rhs, double lhs)
        {
            return lhs * rhs;
        }

        public static bool operator ==(Vector lhs, Vector rhs)
        {
            if (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z)
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector lhs, Vector rhs)
        {
            return !(lhs == rhs);
        }
    }

}
