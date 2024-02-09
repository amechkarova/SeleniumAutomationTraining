using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("", 10000));
        }
        [TestMethod]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student(null, 10000));
        }
        [TestMethod]
        public void ThrowArgumentException_When_IdIsSmallerThan10000()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Aneliya", 9999));
        }

        [TestMethod]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Aneliya", 100000));
        }

        [TestMethod]
        public void NoThrowArgumentException_When_IdIs99999()
        {
            Student newStudent = new Student("Aneliya", 99999);

            Assert.IsNotNull(newStudent);
        }

        [TestMethod]
        public void NoThrowArgumentException_When_IdIs10000()
        {
            Student newStudent = new Student("Aneliya", 10000);

            Assert.IsNotNull(newStudent);
        }
    }
}
