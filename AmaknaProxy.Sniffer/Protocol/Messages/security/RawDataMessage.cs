

// Generated on 09/08/2021 14:22:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class RawDataMessage1 : NetworkMessage
    {
        public const uint Id = 6253;
        public override uint MessageId
        {
            get { return Id; }
        }


        public RawDataMessage1()
        {
        }


        public override void Serialize(IDataWriter writer)
        {
        }

        public override void Deserialize(IDataReader reader)
        {
        }
    }
    public class RawDataMessage2 : NetworkMessage
    {
        public const uint Id = 124;
        public override uint MessageId
        {
            get { return Id; }
        }


        public RawDataMessage2()
        {
        }


        public override void Serialize(IDataWriter writer)
        {
        }

        public override void Deserialize(IDataReader reader)
        {
        }
    }
}