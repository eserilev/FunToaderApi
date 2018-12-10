using Funtoader.Common.Shared.Enums;
using Funtoader.Data.Models.Command;
using FunToader.Domain.Business.Models.Media;
using FunToader.Orchestration.Core.Interfaces.CommandSender;
using FunToader.Orchestration.Core.Interfaces.Media;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace FunToader.Orchestration.Core.Services.Media
{
    public class ColorService : IMediaService<ColorRequest>, IColorService
    {

        private readonly ICommandSenderService commandSenderService;

        private const string argbCmd = "ARGB.";
        private const string displaySettingCmd = "t.";
        private const string colorCountCmd = "CC.";
        private const string colorCmd = "C.";
        private const FunToaderCommandType type = FunToaderCommandType.COLOR;
        public const string fieldDelimeter = ":";

        public ColorService(ICommandSenderService commandSenderService)
        {
            this.commandSenderService = commandSenderService;
        }

        public async Task<Command> SendArgbColorCommand(ColorRequest colorRequest)
        {
            var command = new Command(BuildContentString(colorRequest), FunToaderCommandType.COLOR, colorRequest.RequestMethod);
            return await commandSenderService.SendCommandAsync(command);
        }
        
        public string BuildContentString(ColorRequest mediaRequest)
        {
            string cmd;
            int argbValue = GetArgbValue(mediaRequest.Alpha, mediaRequest.Red, mediaRequest.Green, mediaRequest.Blue);
            switch (mediaRequest.DisplaySetting)
            {
                case ColorDisplaySetting.Cut:
                    cmd = colorCmd + argbCmd + argbValue.ToString() + fieldDelimeter + displaySettingCmd + 0;
                    break;
                case ColorDisplaySetting.Dissolve:
                    cmd = colorCmd + argbCmd + argbValue.ToString() + fieldDelimeter + displaySettingCmd + 1;
                    break;
                default:
                    cmd = colorCmd + argbCmd + argbValue.ToString() + fieldDelimeter + displaySettingCmd + 0;
                    break;
            }
           return cmd;
        }

        private int GetArgbValue(int red, int green, int blue, int alpha)
        {
            return Color.FromArgb(alpha, red, green, blue).ToArgb();
        }

    }
}
