using System.Collections.Generic;

namespace AdapterPattern
{
    public interface IMachineAdapter
    {
        string GetFaxName(List<MachineDetail> details);
    }
}