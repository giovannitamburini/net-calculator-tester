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
            float total = 8f;

            // richiamo la funzione
            float outputAdd = Calculator.Add(num1, num2);

            // confronto output funzione con l'output atteso
            Assert.IsTrue(outputAdd == total, $"Il risultato atteso sarebbe {total} mentre il risultato ottenuto è {outputAdd}");
        }
    }
}