

// Generated on 09/08/2021 14:22:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PresetDeleteResultMessage : NetworkMessage
    {
        public const uint Id = 6559;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short presetId;
        public sbyte code;
        
        public PresetDeleteResultMessage()
        {
        }
        
        public PresetDeleteResultMessage(short presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(presetId);
            writer.WriteSbyte(code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            presetId = reader.ReadShort();
            code = reader.ReadSbyte();
        }
        
    }
    
}