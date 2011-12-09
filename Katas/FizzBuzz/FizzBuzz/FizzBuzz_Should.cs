namespace FizzBuzzKata
{
    using NUnit.Framework;

    [TestFixture]
    public class FizzBuzz_Should
    {

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Multiple_Of_Three_Should_Be_Fizz(int input)
        {
            Assert.That(FizzBuzz.Of(input), Is.EqualTo("Fizz"));
        }

        [Test]
        public void One_Should_Be_One()
        {
            Assert.That(FizzBuzz.Of(1), Is.EqualTo("1"));
        }

        [Test]
        public void Three_Should_Be_Fizz()
        {
            Assert.That(FizzBuzz.Of(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Five_Should_Be_Buzz()
        {
            Assert.That(FizzBuzz.Of(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Six_Should_Be_Fizz()
        {
            Assert.That(FizzBuzz.Of(6), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Ten_Should_Be_Buzz()
        {
            Assert.That(FizzBuzz.Of(10), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Fifteen_Should_Be_FizzBuzz()
        {
            Assert.That(FizzBuzz.Of(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Thirteen_Should_Be_Fizz()
        {
            Assert.That(FizzBuzz.Of(13), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Fiftytwo_Should_Be_Buzz()
        {
            Assert.That(FizzBuzz.Of(52), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Fiftythree_Should_Be_FizzBuzz()
        {
            Assert.That(FizzBuzz.Of(53), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Integer_three_should_be_fizz()
        {
            var result = 3.Test_For_FizzBuzz();
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Until_First_Fizz()
        {
            var from1To100 = FizzBuzz.From1To100().GetEnumerator();
            while (from1To100.MoveNext())
            {
                var item = from1To100.Current;
                if (item == "Fizz")
                {
                    break;
                }
            }
            Assert.That(from1To100.Current, Is.EqualTo("Fizz"));
        }
    }
}