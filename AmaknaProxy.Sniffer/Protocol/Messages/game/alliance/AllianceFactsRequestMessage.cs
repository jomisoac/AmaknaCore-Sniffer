

// Generated on 09/08/2021 14:21:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceFactsRequestMessage : NetworkMessage
    {
        public const uint Id = 5404;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint allianceId;
        
        public AllianceFactsRequestMessage()
        {
        }
        
        public AllianceFactsRequestMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)allianceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            allianceId = reader.ReadVarUhInt();
        }
        
    }
    
}