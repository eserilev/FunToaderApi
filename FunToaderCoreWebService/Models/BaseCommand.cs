using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Models
{
    public abstract class BaseCommand<TRequest> : BaseEntity where TRequest : BaseRequest
    {
        public string jobId { get; set; }
        public CommandType commandType { get; private set; }
        public MessageModel message { get; set; }
        public const string fieldDelimeter = ":";
        public CommandMethod commandMethod { get; private set; }
        

        public BaseCommand(CommandType type, CommandMethod method)
        {
            commandType = type;
            commandMethod = method;
        }

        public abstract void CreateMessage(string value, TRequest request);


    }

    public enum CommandType
    {
        COLOR,
        VIDEO,
        AUDIO,
        IMAGE
    }

    public enum CommandMethod
    {
        WIFI,
        BOTH,
        CELL
    };
}
