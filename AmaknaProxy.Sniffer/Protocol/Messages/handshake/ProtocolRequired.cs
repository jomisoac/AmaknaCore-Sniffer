

// Generated on 09/01/2021 10:12:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ProtocolRequired : NetworkMessage
    {
        public const uint Id = 9546;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string version;
        
        public ProtocolRequired()
        {
        }
        
        public ProtocolRequired(string version)
        {
            this.version = version;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(version);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            version = reader.ReadUTF();
        }
        
    }
    
}