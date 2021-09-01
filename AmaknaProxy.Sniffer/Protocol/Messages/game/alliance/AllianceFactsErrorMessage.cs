

// Generated on 09/01/2021 10:11:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceFactsErrorMessage : NetworkMessage
    {
        public const uint Id = 1681;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint allianceId;
        
        public AllianceFactsErrorMessage()
        {
        }
        
        public AllianceFactsErrorMessage(uint allianceId)
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