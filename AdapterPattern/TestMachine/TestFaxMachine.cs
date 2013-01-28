using System.Collections.Generic;
using AdapterPattern;
using NUnit.Framework;

namespace TestMachine
{
    [TestFixture]
   public class TestFaxMachine
    {
        [Test]
        public void Given_ListOfFaxMachine_When_GetFaxName_should_returnListOfMachineNameInFormat()
        {
            var fax = new Fax(new MachineAdapter());
           var machineList=new List<MachineDetail>
                               {
                                   new MachineDetail {Id = 1, Name = "Fax 1"},
                                   new MachineDetail {Id = 2, Name = "Fax 2"}
                               };
            string faxName = fax.GetFaxName(machineList);
            Assert.IsNotNullOrEmpty(faxName);
        }
    }
}
