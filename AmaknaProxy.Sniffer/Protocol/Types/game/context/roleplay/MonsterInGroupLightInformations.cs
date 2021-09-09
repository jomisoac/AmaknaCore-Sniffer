

// Generated on 09/08/2021 14:22:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MonsterInGroupLightInformations
    {
        public const short Id = 3401;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int genericId;
        public sbyte grade;
        public short level;
        
        public MonsterInGroupLightInformations()
        {
        }
        
        public MonsterInGroupLightInformations(int genericId, sbyte grade, short level)
        {
            this.genericId = genericId;
            this.grade = grade;
            this.level = level;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(genericId);
            writer.WriteSbyte(grade);
            writer.WriteShort(level);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            genericId = reader.ReadInt();
            grade = reader.ReadSbyte();
            level = reader.ReadShort();
        }
        
    }
    
}