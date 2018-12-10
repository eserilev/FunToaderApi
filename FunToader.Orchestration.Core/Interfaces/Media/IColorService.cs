using Funtoader.Data.Models.Command;
using FunToader.Domain.Business.Models.Media;
using System.Threading.Tasks;

namespace FunToader.Orchestration.Core.Interfaces.Media
{
    public interface IColorService
    {
        Task<Command> SendArgbColorCommand(ColorRequest colorRequest);     
    }
}
