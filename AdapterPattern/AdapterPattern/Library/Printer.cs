namespace AdapterPattern.Library
{
    public class Printer : IPrinter
    {
        public string GenerateMchineNameFormat(IMachineDetail machineDetail )
        {
            return "The Machine Name is " + machineDetail.Name;
        }
    }
}