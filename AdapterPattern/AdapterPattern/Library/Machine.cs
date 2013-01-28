using System;

namespace AdapterPattern.Library
{
    public class Machine : IMachine
    {
       private readonly IPrinter _printer;
       public string Output;

       public Machine(IPrinter printer)
       {
           _printer = printer;
       }

       
        public void PrintMachineName(IMachineDetail machineDetail)
        {
            Output = _printer.GenerateMchineNameFormat(machineDetail);
            Console.WriteLine(Output);
        }
    }
}
