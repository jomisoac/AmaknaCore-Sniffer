

// Generated on 09/08/2021 14:22:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameContextSummonsInformation
    {
        public const short Id = 9597;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.SpawnInformation spawnInformation;
        public sbyte wave;
        public Types.EntityLook look;
        public Types.GameFightCharacteristics stats;
        public Types.GameContextBasicSpawnInformation[] summons;
        
        public GameContextSummonsInformation()
        {
        }
        
        public GameContextSummonsInformation(Types.SpawnInformation spawnInformation, sbyte wave, Types.EntityLook look, Types.GameFightCharacteristics stats, Types.GameContextBasicSpawnInformation[] summons)
        {
            this.spawnInformation = spawnInformation;
            this.wave = wave;
            this.look = look;
            this.stats = stats;
            this.summons = summons;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(spawnInformation.TypeId);
            spawnInformation.Serialize(writer);
            writer.WriteSbyte(wave);
            look.Serialize(writer);
            writer.WriteShort(stats.TypeId);
            stats.Serialize(writer);
            writer.WriteShort((short)summons.Length);
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            spawnInformation = ProtocolTypeManager.GetInstance<Types.SpawnInformation>(reader.ReadUShort());
            spawnInformation.Deserialize(reader);
            wave = reader.ReadSbyte();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            stats = ProtocolTypeManager.GetInstance<Types.GameFightCharacteristics>(reader.ReadUShort());
            stats.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            summons = new Types.GameContextBasicSpawnInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 summons[i] = ProtocolTypeManager.GetInstance<Types.GameContextBasicSpawnInformation>(reader.ReadUShort());
                 summons[i].Deserialize(reader);
            }
        }
        
    }
    
}