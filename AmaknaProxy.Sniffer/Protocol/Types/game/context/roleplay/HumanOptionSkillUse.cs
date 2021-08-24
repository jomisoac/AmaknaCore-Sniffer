

// Generated on 08/19/2021 23:35:03
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HumanOptionSkillUse : HumanOption
    {
        public const short Id = 1691;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint elementId;
        public uint skillId;
        public double skillEndTime;
        
        public HumanOptionSkillUse()
        {
        }
        
        public HumanOptionSkillUse(uint elementId, uint skillId, double skillEndTime)
        {
            this.elementId = elementId;
            this.skillId = skillId;
            this.skillEndTime = skillEndTime;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)elementId);
            writer.WriteVarShort((int)skillId);
            writer.WriteDouble(skillEndTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            elementId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            skillEndTime = reader.ReadDouble();
        }
        
    }
    
}