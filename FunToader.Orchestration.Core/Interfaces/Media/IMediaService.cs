using Funtoader.Data.Models.Command;
using FunToader.Domain.Business.Models.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunToader.Orchestration.Core.Interfaces.Media
{
    public interface IMediaService<T> where T : BaseMediaRequest
    {
        string BuildContentString(T mediaRequest);
    }
}
