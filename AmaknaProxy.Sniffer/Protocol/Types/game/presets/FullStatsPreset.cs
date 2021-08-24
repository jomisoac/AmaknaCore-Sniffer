

// Generated on 08/19/2021 23:35:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FullStatsPreset : Preset
    {
        public const short Id = 3276;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.CharacterCharacteristicForPreset[] stats;
        
        public FullStatsPreset()
        {
        }
        
        public FullStatsPreset(short id, Types.CharacterCharacteristicForPreset[] stats)
         : base(id)
        {
            this.stats = stats;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)stats.Length);
            foreach (var entry in stats)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            stats = new Types.CharacterCharacteristicForPreset[limit];
            for (int i = 0; i < limit; i++)
            {
                 stats[i] = new Types.CharacterCharacteristicForPreset();
                 stats[i].Deserialize(reader);
            }
        }
        
    }
    
}