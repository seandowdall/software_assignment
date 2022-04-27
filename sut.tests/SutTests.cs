using NUnit.Framework;
using software_assignment;

namespace sut.tests
{
    [TestFixture]
    class SutTests
    {

        [Test]
        public void Test1()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(24, "rural");
            Assert.That(result, Is.EqualTo(5.0));
        }
        [Test]
        public void test2()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(37, "rural");
            Assert.That(result, Is.EqualTo(2.50));
        }
        [Test]
        public void test3()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(12, "rural");
            Assert.That(result, Is.EqualTo(0.0));
        }
        [Test]
        public void test4()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(27, "urban");
            Assert.That(result, Is.EqualTo(6.0));
        }
        [Test]
        public void test5()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(40, "urban");
            Assert.That(result, Is.EqualTo(5.0));
        }
        [Test]
        public void test6()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(16, "urban");
            Assert.That(result, Is.EqualTo(0.0));
        }
        [Test]
        public void test7()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(67, "urban");
            Assert.That(result, Is.EqualTo(0.75));
        }
        [Test]
        public void test8()
        {
            InsuranceService ins = new InsuranceService();
            double result = ins.CalcPremium(70, "rural");
            Assert.That(result, Is.EqualTo(0.375));
        }

    }
}
