

// Generated on 09/01/2021 10:12:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectUseMessage : NetworkMessage
    {
        public const uint Id = 585;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        
        public ObjectUseMessage()
        {
        }
        
        public ObjectUseMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadVarUhInt();
        }
        
    }
    
}