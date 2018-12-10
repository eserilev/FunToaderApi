using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Models
{
    public class ColorRequest: BaseRequest
    {
        public int[] rgba { get; set; }
        public int display {  get; set; }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int alpha { get; set; }        
        public ColorDisplaySetting displaySetting { get; set; }
    }
}
