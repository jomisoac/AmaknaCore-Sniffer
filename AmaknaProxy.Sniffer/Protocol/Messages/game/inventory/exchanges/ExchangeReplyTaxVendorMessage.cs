

// Generated on 08/19/2021 23:34:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeReplyTaxVendorMessage : NetworkMessage
    {
        public const uint Id = 8775;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double objectValue;
        public double totalTaxValue;
        
        public ExchangeReplyTaxVendorMessage()
        {
        }
        
        public ExchangeReplyTaxVendorMessage(double objectValue, double totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(objectValue);
            writer.WriteVarLong(totalTaxValue);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectValue = reader.ReadVarUhLong();
            totalTaxValue = reader.ReadVarUhLong();
        }
        
    }
    
}