

// Generated on 09/08/2021 14:21:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AdminCommandMessage : NetworkMessage
    {
        public const uint Id = 2679;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string content;
        
        public AdminCommandMessage()
        {
        }
        
        public AdminCommandMessage(string content)
        {
            this.content = content;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            content = reader.ReadUTF();
        }
        
    }
    
}