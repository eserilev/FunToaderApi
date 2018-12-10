using System;
using System.Collections.Generic;
using System.Text;

namespace Funtoader.Common.Shared.Enums
{
    /// <summary>
    /// Specifies the possible Command Types
    /// </summary>
    public enum FunToaderCommandType
    {
        /// <summary>
        /// Indicates an Audio Command Type
        /// </summary>
        AUDIO = 1,

        /// <summary>
        /// Indicates a Color Command Type
        /// </summary>
        COLOR = 2,

        /// <summary>
        /// Indicates an Image Command Type
        /// </summary>
        IMAGE = 3,

        /// <summary>
        /// Indicates a Video Command Type
        /// </summary>
        VIDEO = 4,  
    }
}
