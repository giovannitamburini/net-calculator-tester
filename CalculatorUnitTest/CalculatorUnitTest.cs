using net_calculator_tester;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            // dichiaro gli input
            float num1 = 5f;
            float num2 = 3f;

            // dichiaro output atteso
            float totalExpected = 8f;

            // richiamo la funzione
            float outputAdd = Calculator.Add(num1, num2);

            // confronto output funzione con l'output atteso
            Assert.IsTrue(outputAdd == totalExpected, $"Il risultato atteso dall'addizione sarebbe {totalExpected} mentre il risultato ottenuto è {outputAdd}");
        }

        [Test]
        public void TestSubtract()
        {
            // dichiaro gli input
            float num1 = 5f;
            float num2 = 3f;

            // dichiaro output atteso
            float totalExpected = 2f;

            // richiamo la funzione
            float outputAdd = Calculator.Subtract(num1, num2);

            // confronto output funzione con l'output atteso
            Assert.IsTrue(outputAdd == totalExpected, $"Il risultato atteso dalla sottrazione sarebbe {totalExpected} mentre il risultato ottenuto è {outputAdd}");
        }

        [Test]
        public void TestDivide()
        {
            // dichiaro gli input
            float num1 = 10f;
            float num2 = 2f;

            // dichiaro output atteso
            float totalExpected = 5f;

            // richiamo la funzione
            float outputDivide = Calculator.Divide(num1, num2);

            // confront output funzione con l'output atteso
            Assert.IsTrue(outputDivide == totalExpected, $"Il risultato atteso dalla divisione sarebbe {totalExpected} mentre il risultato ottenuto è {outputDivide}");
        }

        [Test]
        public void TestMultiply()
        {
            // dichiaro gli input
            float num1 = 3f;
            float num2 = 5f;

            // dichiaro output atteso
            float totalExpected = 15f;

            // richiamo la funzione
            float outputMultiply = Calculator.Multiply(num1, num2);

            // confronto output funzione con l'output atteso
            Assert.IsTrue(outputMultiply == totalExpected, $"Il risultato atteso dalla moltiplicazione sarebbe {totalExpected} mentre il risultato ottenuto è {outputMultiply}");
        }
    }
}