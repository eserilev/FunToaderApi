using Funtoader.Common.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunToader.Domain.Business.Models.Media
{
    public class ColorRequest: BaseMediaRequest
    {
        //properties
        public int[] Rgba { get; set; }
        public int Display { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }
        public ColorDisplaySetting DisplaySetting { get; set; }




    }
}
