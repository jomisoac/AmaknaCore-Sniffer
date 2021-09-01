

// Generated on 09/01/2021 10:12:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LivingObjectDissociateMessage : NetworkMessage
    {
        public const uint Id = 5480;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint livingUID;
        public byte livingPosition;
        
        public LivingObjectDissociateMessage()
        {
        }
        
        public LivingObjectDissociateMessage(uint livingUID, byte livingPosition)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            livingUID = reader.ReadVarUhInt();
            livingPosition = reader.ReadByte();
        }
        
    }
    
}