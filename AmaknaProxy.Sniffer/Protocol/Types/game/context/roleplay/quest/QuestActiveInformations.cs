

// Generated on 09/08/2021 14:22:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class QuestActiveInformations
    {
        public const short Id = 3840;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint questId;
        
        public QuestActiveInformations()
        {
        }
        
        public QuestActiveInformations(uint questId)
        {
            this.questId = questId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)questId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUhShort();
        }
        
    }
    
}