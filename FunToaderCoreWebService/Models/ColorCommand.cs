using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Models
{
    public class ColorCommand : BaseCommand<ColorRequest>
    {
        public Int32 argbValue { get; private set; }
        private const string argbCmd = "ARGB.";
        private const string displaySettingCmd = "t.";
        private const string colorCountCmd = "CC.";
        private const string colorCmd = "C.";
        private const CommandType type = CommandType.COLOR;
        private ColorDisplaySetting displaySetting;

        public ColorCommand(ColorRequest r) : base(type, r.requestMethod)
        {
            argbValue = GetArgbValue(r.red, r.green, r.blue, r.alpha);
            displaySetting = r.displaySetting;
            CreateMessage(argbValue.ToString(), r);
        }

        public override void CreateMessage(string value, ColorRequest r)
        {
            string cmd;
            switch (displaySetting)
            {
                case ColorDisplaySetting.Cut:
                    cmd = colorCmd + argbCmd + argbValue.ToString() + fieldDelimeter + displaySettingCmd + 0;
                    break;
                case ColorDisplaySetting.Disolve:
                    cmd = colorCmd + argbCmd + argbValue.ToString() + fieldDelimeter + displaySettingCmd + 1;
                    break;
                default:
                    cmd = colorCmd + argbCmd + argbValue.ToString() + fieldDelimeter + displaySettingCmd + 0;
                    break;
            }
            message = new MessageModel(cmd, r);
        }

        private int GetArgbValue(int red, int green, int blue, int alpha)
        {
            return Color.FromArgb(alpha, red, green, blue).ToArgb();
        }
    }

    public enum ColorDisplaySetting
    {
        Cut,
        Disolve
    }
}
