using Funtoader.Common.Shared.Enums;
using Funtoader.Data.Models.Command;
using FunToader.Domain.Business.Models.Media;
using FunToader.Orchestration.Core.Interfaces.Media;
using FunToader.Orchestration.Core.Services.CommandSender;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunToader.Orchestration.Core.Services.Media
{
    public class AudioService : IMediaService<AudioRequest>, IAudioService
    {
        private readonly CommandSenderService commandSenderService;

        public AudioService(CommandSenderService commandSenderService)
        {
            this.commandSenderService = commandSenderService;
        }

        public async Task<Command> SendAudioCommand(AudioRequest audioRequest)
        {
            var command = new Command(BuildContentString(audioRequest), FunToaderCommandType.AUDIO , audioRequest.RequestMethod);
            return await commandSenderService.SendCommandAsync(command);
        }

        //=====================================================================
        /* An example of a complete Audio command: 5:S.0:SC.12:RS.0:RT.200:SG.mygroup
         *                                         5:S.myfile:SC.12:RS.0:RT.200:SG.0
         * 5 is the cmdID (note ":" is a field delimiter).
         * "S.3" - S is for Audio cmd, 3 is the Audio file index.
         *         A value of 0 means ignore the index and play the group (pick randomly).
         * "SC.12" - SC is for Audio Counter, 12 is for the number of playbacks.
         * "RS.0" - RS is for Random Audio, 0 means "no", 1 means "yes"
         *          If RS.1, randomly pick a Audio file index.
         *          (ignore the Audio file index from Sx).
         * "RST.200" - RST means Random Audio Time (range in msec).
         *            0 means no randomness.
         *            200 means start the playback randomly in (0, 200) msec range.
         * "SG.mygroup - is a group name from which we pick a file randomly.           
         *               if mygroup = "0", play S.myfile (not random).
         *  NOTE: The Sx, SC.x, RS.x, RT.x, SG are always present is every Audio cmd.
        ---------------------------------------------------------------------*/
        public string BuildContentString(AudioRequest mediaRequest)
        {
            if(mediaRequest.Filename == null)
            {
                return null;
            }
            string cmd = mediaRequest.AudioCommandLabel + mediaRequest.Filename + mediaRequest.FieldDelimiter + mediaRequest.AudioCountLabel + mediaRequest.Count + mediaRequest.FieldDelimiter +
                mediaRequest.RandomAudioLabel + (mediaRequest.IsRandomAudio == true ? 1 : 0) + mediaRequest.FieldDelimiter + mediaRequest.RandomAudioTimeLabel + mediaRequest.RandomAudioTime + 
                mediaRequest.FieldDelimiter + mediaRequest.AudioGroupNameLabel + mediaRequest.AudioGroupName;
            return cmd;
        }
    }
}
