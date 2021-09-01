

// Generated on 09/01/2021 10:12:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeRequestOnTaxCollectorMessage : NetworkMessage
    {
        public const uint Id = 464;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeRequestOnTaxCollectorMessage()
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