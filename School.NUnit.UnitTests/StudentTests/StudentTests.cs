using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.NUnit.UnitTests.StudentTests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Student("", 10000));
        }
        [Test]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Student(null, 10000));
        }
        [Test]
        public void ThrowArgumentException_When_IdIsSmallerThan10000()
        {
            Assert.Throws<ArgumentException>(() => new Student("Aneliya", 9999));
        }

        [Test]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Assert.Throws<ArgumentException>(() => new Student("Aneliya", 100000));
        }

        [Test]
        public void NoThrowArgumentException_When_IdIs99999()
        {
            Student newStudent = new Student("Aneliya", 99999);

            ClassicAssert.IsNotNull(newStudent);
        }

        [Test]
        public void NoThrowArgumentException_When_IdIs10000()
        {
            Student newStudent = new Student("Aneliya", 10000);

            ClassicAssert.IsNotNull(newStudent);
        }
    }
}
