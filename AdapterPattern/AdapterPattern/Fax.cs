using System.Collections.Generic;

namespace AdapterPattern
{
    public class Fax
    {
        private readonly IMachineAdapter _machineAdapter;

        public Fax(IMachineAdapter machineAdapter)
        {
            _machineAdapter = machineAdapter;
        }

        public string GetFaxName(List<MachineDetail> details)
        {
            string faxName = _machineAdapter.GetFaxName(details);
            return faxName;
        }
    }
}
