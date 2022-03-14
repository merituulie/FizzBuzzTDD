using NUnit.Framework;

//Write a console program that prints the numbers from 1 to 100.
//  If printed number can be divided by 3, print “Fizz”
//  If printed number can be divided by 5, print “Buzz”
//  If printed number can be divided by both 3 and 5, print “FizzBuzz”

//Typical TDD steps
//  1. Write a single unit test describing an aspect of the program
//  2. Run the test, which should fail because the program lacks that feature
//  3. Write just enough code, the simplest possible, to make the test pass
//  4. Refactor the code
//  5. Repeat, accumulating unit tests over time

namespace FizzBuzzTDD
{
    [TestFixture]
    public class FizzBuzzUnitTest
    {
        [Test]
        public void TestMethod1()
        {
            Assert.Fail();
        }
    }
}
