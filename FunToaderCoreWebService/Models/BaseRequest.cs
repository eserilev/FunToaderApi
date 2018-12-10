using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Models
{
    public class BaseRequest: BaseEntity
    {
        public DateTime requestTime { get; set; }
        public int method { get; set; }
        
        public CommandMethod requestMethod {
            get
            {
                switch (method)
                {
                    default:
                        return CommandMethod.WIFI;
                }
            }
        }
    }
}
