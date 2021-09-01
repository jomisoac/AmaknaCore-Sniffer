

// Generated on 09/01/2021 10:11:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseSellFromInsideRequestMessage : HouseSellRequestMessage
    {
        public const uint Id = 4554;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public HouseSellFromInsideRequestMessage()
        {
        }
        
        public HouseSellFromInsideRequestMessage(int instanceId, double amount, bool forSale)
         : base(instanceId, amount, forSale)
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