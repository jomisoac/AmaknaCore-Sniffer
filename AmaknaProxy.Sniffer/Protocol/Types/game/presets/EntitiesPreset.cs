

// Generated on 08/19/2021 23:35:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class EntitiesPreset : Preset
    {
        public const short Id = 8645;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public short iconId;
        public uint[] entityIds;
        
        public EntitiesPreset()
        {
        }
        
        public EntitiesPreset(short id, short iconId, uint[] entityIds)
         : base(id)
        {
            this.iconId = iconId;
            this.entityIds = entityIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(iconId);
            writer.WriteShort((short)entityIds.Length);
            foreach (var entry in entityIds)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            iconId = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            entityIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 entityIds[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}