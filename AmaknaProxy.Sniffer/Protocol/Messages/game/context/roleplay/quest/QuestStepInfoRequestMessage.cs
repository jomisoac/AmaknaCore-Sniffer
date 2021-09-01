

// Generated on 09/01/2021 10:11:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestStepInfoRequestMessage : NetworkMessage
    {
        public const uint Id = 2999;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint questId;
        
        public QuestStepInfoRequestMessage()
        {
        }
        
        public QuestStepInfoRequestMessage(uint questId)
        {
            this.questId = questId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)questId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questId = reader.ReadVarUhShort();
        }
        
    }
    
}