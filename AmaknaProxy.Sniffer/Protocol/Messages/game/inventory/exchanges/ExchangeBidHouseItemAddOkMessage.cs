

// Generated on 09/01/2021 10:12:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseItemAddOkMessage : NetworkMessage
    {
        public const uint Id = 8921;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItemToSellInBid itemInfo;
        
        public ExchangeBidHouseItemAddOkMessage()
        {
        }
        
        public ExchangeBidHouseItemAddOkMessage(Types.ObjectItemToSellInBid itemInfo)
        {
            this.itemInfo = itemInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            itemInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            itemInfo = new Types.ObjectItemToSellInBid();
            itemInfo.Deserialize(reader);
        }
        
    }
    
}