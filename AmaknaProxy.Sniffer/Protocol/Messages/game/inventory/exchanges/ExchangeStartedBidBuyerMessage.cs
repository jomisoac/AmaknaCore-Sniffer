

// Generated on 09/08/2021 14:22:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeStartedBidBuyerMessage : NetworkMessage
    {
        public const uint Id = 4958;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.SellerBuyerDescriptor buyerDescriptor;
        
        public ExchangeStartedBidBuyerMessage()
        {
        }
        
        public ExchangeStartedBidBuyerMessage(Types.SellerBuyerDescriptor buyerDescriptor)
        {
            this.buyerDescriptor = buyerDescriptor;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            buyerDescriptor.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            buyerDescriptor = new Types.SellerBuyerDescriptor();
            buyerDescriptor.Deserialize(reader);
        }
        
    }
    
}