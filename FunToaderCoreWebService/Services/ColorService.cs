using FunToaderCoreWebService.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Services
{
    public class ColorService: IMediaService<ColorRequest>
    {
        private readonly CommandSender comandSender;

        public ColorService(CommandSender comandSender)
        {
            this.comandSender = comandSender;
        }

        public async Task<MessageModel> SendCommand(ColorRequest request)
        {
            return await SendArgbColorCommand(request);
        }

        public async Task<MessageModel> SendArgbColorCommand(ColorRequest request)
        {
            var color = new ColorCommand(request);

            return await comandSender.SendMessage(color.message);
        }


        public async Task<MessageModel[]> SendArgbCommands(ColorRequest[] requests)
        {
            MessageModel[] m = new MessageModel[requests.Length];
            for (int i = 0; i < requests.Length; i++)
            {
                var r = requests[i];
                m[i] = await SendArgbColorCommand(r);
            }
            return m;
        }
    }
}
