

// Generated on 09/08/2021 14:21:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachExitRequestMessage : NetworkMessage
    {
        public const uint Id = 5568;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public BreachExitRequestMessage()
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