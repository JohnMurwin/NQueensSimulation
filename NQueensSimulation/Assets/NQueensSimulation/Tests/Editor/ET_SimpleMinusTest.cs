using NUnit.Framework;

namespace NQueensSimulation.Tests
{
    public class ET_SimpleMinusTest
    {
        [Test]
        public void TestMinus()
        {
            // Given
            int one = 1;

            // When
            int test = 2;
            test--;

            // Then
            Assert.AreEqual(one, test);
        }

    }
}
