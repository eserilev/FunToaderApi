using System;
using System.Collections.Generic;
using System.Text;

namespace Funtoader.Data.Models.Command
{
    /// <summary>
    /// Extended partial POCO equivalent of a command from the data store with properties for command date operations
    /// </summary>
    public class CommandDates
    {
        //properties
        /// <summary>
        /// Gets or sets the date with which the command was sent
        /// </summary>
        public DateTime? Sent { get; set; }

        /// <summary>
        /// Gets or sets the date with which the command was received
        /// </summary>
        public DateTime? Received { get; set; }
    }
}
