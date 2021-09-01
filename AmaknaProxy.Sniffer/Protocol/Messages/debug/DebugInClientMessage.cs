

// Generated on 09/01/2021 10:11:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DebugInClientMessage : NetworkMessage
    {
        public const uint Id = 9388;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte level;
        public string message;
        
        public DebugInClientMessage()
        {
        }
        
        public DebugInClientMessage(sbyte level, string message)
        {
            this.level = level;
            this.message = message;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(level);
            writer.WriteUTF(message);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            level = reader.ReadSbyte();
            message = reader.ReadUTF();
        }
        
    }
    
}