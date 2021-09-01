

// Generated on 09/01/2021 10:12:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SymbioticObjectAssociateRequestMessage : NetworkMessage
    {
        public const uint Id = 6088;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint symbioteUID;
        public byte symbiotePos;
        public uint hostUID;
        public byte hostPos;
        
        public SymbioticObjectAssociateRequestMessage()
        {
        }
        
        public SymbioticObjectAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos)
        {
            this.symbioteUID = symbioteUID;
            this.symbiotePos = symbiotePos;
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)symbioteUID);
            writer.WriteByte(symbiotePos);
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            symbioteUID = reader.ReadVarUhInt();
            symbiotePos = reader.ReadByte();
            hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
        }
        
    }
    
}