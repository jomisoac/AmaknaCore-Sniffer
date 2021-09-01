

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InteractiveUseRequestMessage : NetworkMessage
    {
        public const uint Id = 7117;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint elemId;
        public uint skillInstanceUid;
        
        public InteractiveUseRequestMessage()
        {
        }
        
        public InteractiveUseRequestMessage(uint elemId, uint skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)elemId);
            writer.WriteVarInt((int)skillInstanceUid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            elemId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadVarUhInt();
        }
        
    }
    
}