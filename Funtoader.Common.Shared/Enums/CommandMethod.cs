using System;
using System.Collections.Generic;
using System.Text;

namespace Funtoader.Common.Shared.Enums
{
    /// <summary>
    /// Specifies the possible Command Methods
    /// </summary>
    public enum CommandMethod
    {
        /// <summary>
        /// Indicates Wifi Command Method
        /// </summary>      
        WIFI = 1,

        /// <summary>
        /// Indicates Cell Command Method
        /// </summary>
        CELL = 2,

        /// <summary>
        /// Indicates both Wifi and Cell Command Method
        /// </summary>
        BOTH = 3,      
    };
}
