

// Generated on 09/08/2021 14:22:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SkillActionDescription
    {
        public const short Id = 9402;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint skillId;
        
        public SkillActionDescription()
        {
        }
        
        public SkillActionDescription(uint skillId)
        {
            this.skillId = skillId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)skillId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            skillId = reader.ReadVarUhShort();
        }
        
    }
    
}