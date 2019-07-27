using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest
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
            Assert.AreEqual(3.0, vect1.x);
            Assert.AreEqual(3.0, vect1.y);
            Assert.AreEqual(1.0, vect1.z);

            // Check vect2.x, vect2.y, vect2.z
            Assert.AreEqual(2.0, vect2.x);
            Assert.AreEqual(-4.0, vect2.y);
            Assert.AreEqual(-4.0, vect2.z);

            // Check vect3.x, vect3.y, vect3.z
            Assert.AreEqual(5.0, vect3.x);
            Assert.AreEqual(-1.0, vect3.y);
            Assert.AreEqual(-3.0, vect3.z);

        }

        [TestMethod]
        public void OperatorOverload_Mul_Test()
        {
            var vect1 = new Vector(3.0, 3.0, 1.0);
            var result1 = 2.0 * vect1;
            var result2 = vect1 * 2;

            // Check result 1
            Assert.AreEqual(6.0, result1.x);
            Assert.AreEqual(6.0, result1.y);
            Assert.AreEqual(2.0, result1.z);

            // Check result 2
            Assert.AreEqual(6.0, result2.x);
            Assert.AreEqual(6.0, result2.y);
            Assert.AreEqual(2.0, result2.z);
        }

        [TestMethod]
        public void OperatorOverload_EqualSignOverload_Test()
        {
            var vect1 = new Vector(3.0, 3.0, 1.0);
        }
    }

    struct Vector
    {
        public double x, y, z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(Vector rhs)
        {
            x = rhs.x;
            y = rhs.y;
            z = rhs.z;
        }

        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }

        public static Vector operator + (Vector lhs, Vector rhs)
        {
            var result = new Vector(lhs);
            result.x += rhs.x;
            result.y += rhs.y;
            result.z += rhs.z;
            return result;
        }

        public static Vector operator *(double lhs, Vector rhs)
        {
            return new Vector(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }

        public static Vector operator *(Vector rhs, double lhs)
        {
            return lhs * rhs;
        }

        public static bool operator ==(Vector lhs, Vector rhs)
        {
            if (lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z)
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
