

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class InteractiveElementSkill
    {
        public const short Id = 4345;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint skillId;
        public int skillInstanceUid;
        
        public InteractiveElementSkill()
        {
        }
        
        public InteractiveElementSkill(uint skillId, int skillInstanceUid)
        {
            this.skillId = skillId;
            this.skillInstanceUid = skillInstanceUid;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)skillId);
            writer.WriteInt(skillInstanceUid);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            skillId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadInt();
        }
        
    }
    
}