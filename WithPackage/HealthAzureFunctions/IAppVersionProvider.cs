using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAzureFunctions
{
    /// <summary>
    /// This is the interface implemented to read AppVersion.
    /// For this example. This is just to demostrate that how to handle dependency.
    /// </summary>
    public interface IAppVersionProvider
    {
        string GetVersion();
    }
}
