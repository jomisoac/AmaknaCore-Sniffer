

// Generated on 09/08/2021 14:21:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockSellRequestMessage : NetworkMessage
    {
        public const uint Id = 5147;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double price;
        public bool forSale;
        
        public PaddockSellRequestMessage()
        {
        }
        
        public PaddockSellRequestMessage(double price, bool forSale)
        {
            this.price = price;
            this.forSale = forSale;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(price);
            writer.WriteBoolean(forSale);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            price = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
        }
        
    }
    
}