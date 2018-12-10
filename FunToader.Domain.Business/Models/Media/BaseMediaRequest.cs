using Funtoader.Common.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunToader.Domain.Business.Models.Media
{
    public class BaseMediaRequest
    {

        public string StopCommand { get { return "STOP"; } }
        public string FieldDelimiter { get { return ":"; } }
        public DateTime RequestTime { get; set; }
        public CommandMethod RequestMethod { get; set; }
    }
}
