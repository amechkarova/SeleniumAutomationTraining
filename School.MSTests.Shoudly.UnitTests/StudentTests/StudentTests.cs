using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.MSTests.Shoudly.UnitTests.StudentTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Should.Throw<ArgumentException>(() => new Student("", 10000));
        }
        [TestMethod]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Should.Throw<ArgumentException>(() => new Student(null, 10000));
        }
        [TestMethod]
        public void ThrowArgumentException_When_IdIsSmallerThan10000()
        {
            Should.Throw<ArgumentException>(() => new Student("Aneliya", 9999));
        }

        [TestMethod]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Should.Throw<ArgumentException>(() => new Student("Aneliya", 100000));
        }

        [TestMethod]
        public void NoThrowArgumentException_When_IdIs99999()
        {
            //Student newStudent = new Student("Aneliya", 99999);
            Should.NotThrow(() => new Student("Aneliya", 99999));
        }

        [TestMethod]
        public void NoThrowArgumentException_When_IdIs10000()
        {
            Should.NotThrow(() => new Student("Aneliya", 10000));
        }
    }
}
