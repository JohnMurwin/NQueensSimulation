using NUnit.Framework;

namespace NQueensSimulation.Tests
{
    public class ET_SimpleAddTest
    {
        [Test]
        public void TestIncrement()
        {
            // Given
            int one = 1;

            // When
            int test = 0;
            test++;

            // Then
            Assert.AreEqual(one, test);
        }

    }
}
