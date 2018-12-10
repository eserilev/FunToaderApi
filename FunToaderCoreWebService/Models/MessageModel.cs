using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunToaderCoreWebService.Models
{
    public class MessageModel : BaseEntity
    {
        public string messageContent { get; private set; }
        public byte[] messageBuffer { get; private set; }
        public DateTime requestTime { get; set; }
        public DateTime sentTime { get; set; }
        public CommandMethod commandMethod { get; set; }

        public MessageModel(string m, ColorRequest r)
        {
           
            messageContent = m;
            if(m != null)
            {
                messageBuffer = Encoding.ASCII.GetBytes(m);

            }
            if(r != null)
            {
                requestTime = r.requestTime.ToUniversalTime();
                commandMethod = r.requestMethod;
            }
            
        }
        
        public void UpdateSentTime()
        {
            this.sentTime = DateTime.Now.ToUniversalTime();
        }

    }
}
