

// Generated on 08/19/2021 23:34:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CheckFileMessage : NetworkMessage
    {
        public const uint Id = 7035;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string filenameHash;
        public sbyte type;
        public string value;
        
        public CheckFileMessage()
        {
        }
        
        public CheckFileMessage(string filenameHash, sbyte type, string value)
        {
            this.filenameHash = filenameHash;
            this.type = type;
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(filenameHash);
            writer.WriteSbyte(type);
            writer.WriteUTF(value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            filenameHash = reader.ReadUTF();
            type = reader.ReadSbyte();
            value = reader.ReadUTF();
        }
        
    }
    
}