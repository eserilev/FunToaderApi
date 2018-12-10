using System;
using System.Collections.Generic;
using System.Text;

namespace Funtoader.Data.Models.Command
{
    /// <summary>
    /// Extended partial POCO equivalent of a command from the data store with properties for command content operations
    /// </summary>
    public class CommandContent
    {
        //properties
        /// <summary>
        /// Gets or sets the contents of the message
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the contents of the message in bytes
        /// </summary>
        public byte[] Buffer { get; set; }
    }
}
