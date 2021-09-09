

// Generated on 09/08/2021 14:22:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpawnMonsterInformation : BaseSpawnMonsterInformation
    {
        public const short Id = 3997;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte creatureGrade;
        
        public SpawnMonsterInformation()
        {
        }
        
        public SpawnMonsterInformation(uint creatureGenericId, sbyte creatureGrade)
         : base(creatureGenericId)
        {
            this.creatureGrade = creatureGrade;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(creatureGrade);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            creatureGrade = reader.ReadSbyte();
        }
        
    }
    
}