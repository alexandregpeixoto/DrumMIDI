using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService
{
    [DataContract]
    public class Note
    {
        Int32 intId;
        Int32 intCodeMIDI;
        String strName;

        [DataMember]
        public Int32 Id
        {
            get { return intId; }
            set { intId = value; }
        }

        [DataMember]
        public Int32 CodeMIDI
        {
            get { return intCodeMIDI; }
            set { intCodeMIDI = value; }
        }

        [DataMember]
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
    }
}