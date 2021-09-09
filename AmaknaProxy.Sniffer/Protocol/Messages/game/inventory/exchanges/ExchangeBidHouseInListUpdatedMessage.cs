

// Generated on 09/08/2021 14:22:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseInListUpdatedMessage : ExchangeBidHouseInListAddedMessage
    {
        public const uint Id = 4751;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ExchangeBidHouseInListUpdatedMessage()
        {
        }
        
        public ExchangeBidHouseInListUpdatedMessage(int itemUID, uint objectGID, int objectType, Types.ObjectEffect[] effects, double[] prices)
         : base(itemUID, objectGID, objectType, effects, prices)
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