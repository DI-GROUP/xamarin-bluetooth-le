using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.BLE.Abstractions.Contracts
{
    public enum ConnectionPriority
    {
        High,
        Normal,
        Low
    }
    public interface IAndroidConnectionParametersUpdater
    {
        bool RequestConnectionParametersUpdate(ConnectionPriority connectionPriority);
    }
}
