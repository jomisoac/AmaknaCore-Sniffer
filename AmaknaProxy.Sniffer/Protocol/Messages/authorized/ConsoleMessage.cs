

// Generated on 09/01/2021 10:11:33
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ConsoleMessage : NetworkMessage
    {
        public const uint Id = 5874;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte type;
        public string content;
        
        public ConsoleMessage()
        {
        }
        
        public ConsoleMessage(sbyte type, string content)
        {
            this.type = type;
            this.content = content;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(type);
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            type = reader.ReadSbyte();
            content = reader.ReadUTF();
        }
        
    }
    
}