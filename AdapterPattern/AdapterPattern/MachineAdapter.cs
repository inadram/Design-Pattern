using System.Collections.Generic;
using AdapterPattern.Library;

namespace AdapterPattern
{
   public class MachineAdapter   : IMachineAdapter
    {
        Machine _machine;
        public string GetFaxName(List<MachineDetail> details)
        {
            string allFaxMachineNameInFormat=string.Empty;
            foreach (var machineDetail in details)
            {
                _machine = new Machine(new Printer());
                _machine.PrintMachineName(machineDetail);
                allFaxMachineNameInFormat += _machine.Output+"\n";

            }
            return allFaxMachineNameInFormat;

        }

       
    }
}