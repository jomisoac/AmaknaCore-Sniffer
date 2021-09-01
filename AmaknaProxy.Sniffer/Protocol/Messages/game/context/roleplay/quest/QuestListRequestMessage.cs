

// Generated on 09/01/2021 10:11:55
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class QuestListRequestMessage : NetworkMessage
    {
        public const uint Id = 5830;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public QuestListRequestMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}