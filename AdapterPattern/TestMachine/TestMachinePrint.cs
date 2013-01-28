using AdapterPattern;
using AdapterPattern.Library;
using NUnit.Framework;
using Rhino.Mocks;

namespace TestMachine
{
    [TestFixture]
    public class TestMachinePrint
    {
        [Test]
        public void Given_MachineDetail_when_PrintMachineNameCalled_ShouldReturnMachineName()
        {
            var printer = MockRepository.GenerateMock<IPrinter>();
            printer.Stub(x => x.GenerateMchineNameFormat(null)).IgnoreArguments().Return("The Machine Name is TestMachine");
            var machine = new Machine(printer);
            var machineDetail = new MachineDetail { Id = 1, Name = "TestMachine" };
            machine.PrintMachineName(machineDetail);
            Assert.That(machine.Output, Is.EqualTo("The Machine Name is TestMachine"));

 
        }
    }
}
