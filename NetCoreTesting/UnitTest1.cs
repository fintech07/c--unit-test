using NUnit.Framework;
using Math;

namespace NetCoreTesting.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private CMath _math;

        [SetUp]
        public void SetUp(){
            _math = new CMath();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArgument()
        {
            var result = _math.Add(1, 3);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_RetrnTheFirst(){
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_RetrnTheSecond(){
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_RetrnTheSameArgument(){
            var result = _math.Max(2, 2);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
