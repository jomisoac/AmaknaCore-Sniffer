

// Generated on 09/08/2021 14:22:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InvalidPresetsMessage : NetworkMessage
    {
        public const uint Id = 3104;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short[] presetIds;
        
        public InvalidPresetsMessage()
        {
        }
        
        public InvalidPresetsMessage(short[] presetIds)
        {
            this.presetIds = presetIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)presetIds.Length);
            foreach (var entry in presetIds)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            presetIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 presetIds[i] = reader.ReadShort();
            }
        }
        
    }
    
}