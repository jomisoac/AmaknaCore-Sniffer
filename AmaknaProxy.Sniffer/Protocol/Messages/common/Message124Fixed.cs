

// Generated on 08/19/2021 23:34:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public partial class RawDataMessageFixed : NetworkMessage
    {
        public const uint Id = 124;
        public byte[] content;
        public override uint MessageId
        {
            get { return Id; }
        }

        public RawDataMessageFixed()
        {
            
        }

        public RawDataMessageFixed(byte[] _content)
        {
            content = _content;
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(content.Length);
            writer.WriteBytes(content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var len = reader.ReadVarInt();
            content = reader.ReadBytes(len);
        }
        
    }
    
}