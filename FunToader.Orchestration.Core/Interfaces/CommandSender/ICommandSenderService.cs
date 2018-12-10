using Funtoader.Data.Models.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunToader.Orchestration.Core.Interfaces.CommandSender
{
    /// <summary>
    /// Provides an abstraction for the business logic flows for working with the <see cref=""/> business model. 
    /// </summary>
    public interface ICommandSenderService
    {
        /// <summary>
        /// Sends the provided <see cref="CommandDisplay"/> object to the intialized port
        /// </summary>
        /// <returns>The <see cref="Task"/> that represents the asynchronous operation, containing the <see cref="CommandDisplay"/> indicating a succesful operation</returns>
        Task<Command> SendCommandAsync(Command command);
   
    }
}
