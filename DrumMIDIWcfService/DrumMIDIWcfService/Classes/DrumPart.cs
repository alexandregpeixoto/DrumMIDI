using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService
{
    [DataContract]
    public class DrumPart
    {
        Int32 intId;
        Int32 intIntensity;
        Int32 intAnalogPort;
        Int32 intIdNote;
        Note objNote;

        [DataMember]
        public Int32 Id
        {
            get { return intId; }
            set { intId = value; }
        }

        [DataMember]
        public Int32 Intensity
        {
            get { return intIntensity; }
            set { intIntensity = value; }
        }

        [DataMember]
        public Int32 AnalogPort
        {
            get { return intAnalogPort; }
            set { intAnalogPort = value; }
        }

        [DataMember]
        public Note Note
        {
            get { return objNote; }
            set { objNote = value; }
        }

    }
}