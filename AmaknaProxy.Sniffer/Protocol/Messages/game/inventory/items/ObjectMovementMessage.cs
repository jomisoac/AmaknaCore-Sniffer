

// Generated on 09/08/2021 14:22:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectMovementMessage : NetworkMessage
    {
        public const uint Id = 3776;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        public short position;
        
        public ObjectMovementMessage()
        {
        }
        
        public ObjectMovementMessage(uint objectUID, short position)
        {
            this.objectUID = objectUID;
            this.position = position;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteShort(position);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            position = reader.ReadShort();
        }
        
    }
    
}