

// Generated on 09/01/2021 10:11:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestStepStartedMessage : NetworkMessage
    {
        public const uint Id = 4938;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        public uint stepId;
        
        public QuestStepStartedMessage()
        {
        }
        
        public QuestStepStartedMessage(uint questId, uint stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)stepId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUhShort();
            stepId = reader.ReadVarUhShort();
        }
        
    }
    
}