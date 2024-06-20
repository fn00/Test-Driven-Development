using Test_Driven_Development;

namespace Unit_Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetProduct(1);
            var result = sw.ToString().Trim();
            Assert.That(result == "Chais");
        }
        [Test]
        public void Test2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetProduct(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "no product found with id 0");
        }
        [Test]
        public void Test3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplier(16);
            var result = sw.ToString().Trim();
            Assert.That(result == "Bigfoot Breweries");
        }
        [Test]
        public void Test4()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplier(0);
            var result = sw.ToString().Trim();
            Assert.That(result == "no supplier found with id 0");

        }
        [Test]
        public void Test5()

        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetProduct(10000);
            var result = sw.ToString().Trim();
            Assert.That(result == "no product found with id 10000");
        }
        [Test]
        public void Test6()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Program.GetSupplier(10000);
            var result = sw.ToString().Trim();
            Assert.That(result == "no supplier found with id 10000");
        }
    }
}