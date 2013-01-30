using NUnit.Framework;

namespace ElseIf
{
    [TestFixture]
    public class TestFactory
    {
        [Test]
        public void Given_One_when_FactoryCalled_Then_ShouldReturnAppropriateStatus()
        {
            ElseIf elseIf=new ElseIf();
            string factoryStatus= elseIf.Factory(new One());
            Assert.That(factoryStatus, Is.EqualTo("This is class one type"));
        }

    }
}