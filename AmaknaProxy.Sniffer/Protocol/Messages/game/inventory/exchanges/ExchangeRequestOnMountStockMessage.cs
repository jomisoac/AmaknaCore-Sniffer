

// Generated on 09/08/2021 14:22:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeRequestOnMountStockMessage : NetworkMessage
    {
        public const uint Id = 3253;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeRequestOnMountStockMessage()
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