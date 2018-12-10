using FunToaderCoreWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Services
{
    public interface IMediaService<T> where T : BaseRequest
    {
         Task<MessageModel> SendCommand(T request);
    }
}
