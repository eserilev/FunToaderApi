using Funtoader.Common.Shared.Enums;
using Funtoader.Data.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funtoader.Data.Models.Command
{
    /// <summary>
    /// Minimalistic partial POCO equivalent of a Command from the data store with navigational properties for general usage.
    /// <para>Serves as the hub that ties together all split table variants using <see cref="CommandBase"/></para>
    /// </summary>
    public class Command: CommandBase
    {
        //Split Tables
        /// <summary>
        /// Split table navigation property for accessing <see cref="CommandContent"/>, the minimialistic hub that ties together all split table variants for the Command table.
        /// </summary>
        public CommandContent CommandContent { get; set; }

        /// <summary>
        /// Split table navigation property for accessing <see cref="CommandDates"/>, the minimialistic hub that ties together all split table variants for the Command table.
        /// </summary>
        public CommandDates CommandDates { get; set; }
        
        //properties
        /// <summary>
        /// Gets or sets the command type
        /// </summary>
        public FunToaderCommandType CommandType { get; set; }

        /// <summary>
        /// Gets or sets the command method
        /// </summary>
        public CommandMethod CommandMethod { get; set; }

        public Command() { }

        public Command(string content, FunToaderCommandType commandType, CommandMethod commandMethod)
        {
            this.CommandContent = new CommandContent
            {
                Buffer = Encoding.ASCII.GetBytes(content),
                Content = content
            };
            this.CommandDates = new CommandDates
            {
                 Received = DateTime.Now.ToUniversalTime(),
                 Sent = null
            };
            this.CommandType = commandType;
            this.CommandMethod = commandMethod;
        }
    }

    public abstract class CommandBase : BaseEntity<int>
    {

    }
}
