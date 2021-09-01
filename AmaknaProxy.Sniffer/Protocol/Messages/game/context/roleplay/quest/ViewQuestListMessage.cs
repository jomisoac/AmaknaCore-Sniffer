

// Generated on 09/01/2021 10:11:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ViewQuestListMessage : QuestListMessage
    {
        public const uint Id = 5319;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ViewQuestListMessage()
        {
        }
        
        public ViewQuestListMessage(uint[] finishedQuestsIds, uint[] finishedQuestsCounts, Types.QuestActiveInformations[] activeQuests, uint[] reinitDoneQuestsIds)
         : base(finishedQuestsIds, finishedQuestsCounts, activeQuests, reinitDoneQuestsIds)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}