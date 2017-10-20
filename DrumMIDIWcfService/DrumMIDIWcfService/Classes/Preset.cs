using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService
{
    [DataContract]
    public class Preset
    {
        Int32 intId;
        Int32 strName;
        Int32 intIdDrumPart1;
        Int32 intIdDrumPart2;
        Int32 intIdDrumPart3;
        Int32 intIdDrumPart4;
        Int32 intIdDrumPart5;
        DrumPart objDrumPart1;
        DrumPart objDrumPart2;
        DrumPart objDrumPart3;
        DrumPart objDrumPart4;
        DrumPart objDrumPart5;
        Int32 intIdUser;
        User objUser;

        [DataMember]
        public Int32 Id
        {
            get { return intId; }
            set { intId = value; }
        }

        [DataMember]
        public Int32 IdDrumPart1
        {
            get { return intIdDrumPart1; }
            set { intIdDrumPart1 = value; }
        }

        [DataMember]
        public Int32 IdDrumPart2
        {
            get { return intIdDrumPart2; }
            set { intIdDrumPart2 = value; }
        }

        [DataMember]
        public Int32 IdDrumPart3
        {
            get { return intIdDrumPart3; }
            set { intIdDrumPart3 = value; }
        }

        [DataMember]
        public Int32 IdDrumPart4
        {
            get { return intIdDrumPart4; }
            set { intIdDrumPart4 = value; }
        }

        [DataMember]
        public Int32 IdDrumPart5
        {
            get { return intIdDrumPart5; }
            set { intIdDrumPart5 = value; }
        }

        [DataMember]
        public DrumPart DrumPart1
        {
            get { return objDrumPart1; }
            set { objDrumPart1 = value; }
        }

        [DataMember]
        public DrumPart DrumPart2
        {
            get { return objDrumPart2; }
            set { objDrumPart2 = value; }
        }

        [DataMember]
        public DrumPart DrumPart3
        {
            get { return objDrumPart3; }
            set { objDrumPart3 = value; }
        }

        [DataMember]
        public DrumPart DrumPart4
        {
            get { return objDrumPart4; }
            set { objDrumPart4 = value; }
        }

        [DataMember]
        public DrumPart DrumPart5
        {
            get { return objDrumPart5; }
            set { objDrumPart5 = value; }
        }

        [DataMember]
        public Int32 IdUser
        {
            get { return intIdUser; }
            set { intIdUser = value; }
        }

        [DataMember]
        public User User
        {
            get { return objUser; }
            set { objUser = value; }
        }
    }
}