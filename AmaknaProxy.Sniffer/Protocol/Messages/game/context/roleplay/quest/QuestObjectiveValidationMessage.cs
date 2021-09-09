

// Generated on 09/08/2021 14:21:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestObjectiveValidationMessage : NetworkMessage
    {
        public const uint Id = 3382;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        public uint objectiveId;
        
        public QuestObjectiveValidationMessage()
        {
        }
        
        public QuestObjectiveValidationMessage(uint questId, uint objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)objectiveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUhShort();
            objectiveId = reader.ReadVarUhShort();
        }
        
    }
    
}