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
        [TestCase(10, 2, 5)]
        public void TestDivide(float num1, float num2, float totalExpected)
        {
            // richiamo la funzione
            float outputDivide = Calculator.Divide(num1, num2);

            // confronto output funzione con l'output atteso
            Assert.IsTrue(num1/num2 == outputDivide, $"Il risultato atteso dalla divisione sarebbe {totalExpected} mentre il risultato ottenuto è {outputDivide}");
        }

        [Test]
        public void TestDivideByZeroEqualsPositiveInfinity()
        {
            // dichiaro gli input
            float num1 = 5f;
            float num2 = 0;

            float totalExpected = float.PositiveInfinity;

            float outputDivide = Calculator.Divide(num1, num2);

            Assert.That(outputDivide, Is.EqualTo(totalExpected), $"Il risultato atteso della divisione sarebbe {totalExpected} mentre il risultato ottenuto è {outputDivide}");
        }

        [Test]
        [TestCase(-6, -2, 3)]
        public void TestDivideNegativeNumByNegativeNum (float num1, float num2, float expectedResult)
        {
            Assert.That(num1 / num2, Is.EqualTo(expectedResult), "Il risultato atteso è errato");
        }

        [Test]
        public void TestDivideByZeroEqualsNegativeInfinity()
        {
            // dichiaro gli input
            float num1 = -5f;
            float num2 = 0;

            float totalExpected = float.NegativeInfinity;

            float outputDivide = Calculator.Divide(num1, num2);

            Assert.That(outputDivide, Is.EqualTo(totalExpected), $"Il risultato atteso della divisione sarebbe {totalExpected} mentre il risultato ottenuto è {outputDivide}");
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

        [Test]
        public void TestMultiplyWithMaxNumber()
        {
            // dichiaro gli input
            float num1 = float.MaxValue;
            float num2 = 2f;

            // dichiaro l'output atteso
            float totalExpected = float.PositiveInfinity;

            // richiamo la funzione
            float outputMultiply = Calculator.Multiply(num1, num2);

            // confronto l'output della funzione con l'output atteso
            Assert.That(outputMultiply == totalExpected, $"Il risultato atteso dalla moltiplicazione sarebbe {totalExpected} mentre il risultato ottenuto è {outputMultiply}");
        }

        [Test]
        public void TestMultiplyWithNaN()
        {
            // dichiaro gli input, uno dei quali è NaN
            float num1 = 5f;
            float num2 = float.NaN;

            // controllo che il test sollevi la giusta eccezione
            Assert.Throws<InvalidOperationException>(() => Calculator.Multiply(num1, num2), "Non puoi utilizzare una variabile che non rappresenta un valore numerico");
        }
    }
}