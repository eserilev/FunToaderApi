using Funtoader.Data.Models.Command;
using FunToader.Domain.Business.Models.Media;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunToader.Orchestration.Core.Interfaces.Media
{
    public interface IAudioService
    {
        Task<Command> SendAudioCommand(AudioRequest audioRequest);
    }
}
