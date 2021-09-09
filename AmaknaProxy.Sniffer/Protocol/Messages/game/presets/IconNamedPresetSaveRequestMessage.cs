

// Generated on 09/08/2021 14:22:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IconNamedPresetSaveRequestMessage : IconPresetSaveRequestMessage
    {
        public const uint Id = 6473;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string name;
        public sbyte type;
        
        public IconNamedPresetSaveRequestMessage()
        {
        }
        
        public IconNamedPresetSaveRequestMessage(short presetId, sbyte symbolId, bool updateData, string name, sbyte type)
         : base(presetId, symbolId, updateData)
        {
            this.name = name;
            this.type = type;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteSbyte(type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            type = reader.ReadSbyte();
        }
        
    }
    
}