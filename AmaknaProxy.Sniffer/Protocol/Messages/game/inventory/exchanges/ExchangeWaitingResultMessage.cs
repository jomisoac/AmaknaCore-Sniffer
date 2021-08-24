

// Generated on 08/19/2021 23:34:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeWaitingResultMessage : NetworkMessage
    {
        public const uint Id = 5604;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool bwait;
        
        public ExchangeWaitingResultMessage()
        {
        }
        
        public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(bwait);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            bwait = reader.ReadBoolean();
        }
        
    }
    
}