

// Generated on 09/01/2021 10:12:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IconPresetSaveRequestMessage : NetworkMessage
    {
        public const uint Id = 4174;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short presetId;
        public sbyte symbolId;
        public bool updateData;
        
        public IconPresetSaveRequestMessage()
        {
        }
        
        public IconPresetSaveRequestMessage(short presetId, sbyte symbolId, bool updateData)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.updateData = updateData;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(presetId);
            writer.WriteSbyte(symbolId);
            writer.WriteBoolean(updateData);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            presetId = reader.ReadShort();
            symbolId = reader.ReadSbyte();
            updateData = reader.ReadBoolean();
        }
        
    }
    
}