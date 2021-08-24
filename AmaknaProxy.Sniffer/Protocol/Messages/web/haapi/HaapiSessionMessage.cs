

// Generated on 08/19/2021 23:34:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiSessionMessage : NetworkMessage
    {
        public const uint Id = 3824;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string key;
        public sbyte type;
        
        public HaapiSessionMessage()
        {
        }
        
        public HaapiSessionMessage(string key, sbyte type)
        {
            this.key = key;
            this.type = type;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(key);
            writer.WriteSbyte(type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            key = reader.ReadUTF();
            type = reader.ReadSbyte();
        }
        
    }
    
}