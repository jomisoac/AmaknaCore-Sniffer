

// Generated on 09/01/2021 10:12:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MimicryObjectEraseRequestMessage : NetworkMessage
    {
        public const uint Id = 2479;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint hostUID;
        public byte hostPos;
        
        public MimicryObjectEraseRequestMessage()
        {
        }
        
        public MimicryObjectEraseRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
        }
        
    }
    
}