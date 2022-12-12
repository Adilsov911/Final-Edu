using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class EventSpeaker:BaseEntity
    {
        public int EventsId { get; set; }
        public Event Events { get; set; }
        public int SpeakersId { get; set; }
        public Speaker Speakers { get; set; }
    }
}
