using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService
{
    [DataContract]
    public class User
    {
        Int32 intId;
        String strName;
        String strPassword;

        [DataMember]
        public Int32 Id
        {
            get { return intId; }
            set { intId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        [DataMember]
        public string Password
        {
            get { return strPassword; }
            set { strPassword = value; }
        }
    }
}