using System;
using System.Collections.Generic;
using System.Text;

namespace FunToader.Domain.Business.Models.Media
{
    
    public class AudioRequest : BaseMediaRequest
    {
        public string AudioCommandLabel { get { return "S."; } }
        public string RandomAudioLabel { get { return "RS."; } }
        public string AudioCountLabel { get { return "SC."; } }
        public string RandomAudioTimeLabel { get { return "RST."; } }
        public string AudioGroupNameLabel { get { return "SG."; } }

        public string Filename { get; set; }
        public string Count { get; set; }
        public bool IsRandomAudio { get; set; }
        public int RandomAudioTime { get; set; }
        public string AudioGroupName { get; set; }

    }
}
