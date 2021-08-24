

// Generated on 08/19/2021 23:34:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHousePriceMessage : NetworkMessage
    {
        public const uint Id = 6774;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint genId;
        
        public ExchangeBidHousePriceMessage()
        {
        }
        
        public ExchangeBidHousePriceMessage(uint genId)
        {
            this.genId = genId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)genId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            genId = reader.ReadVarUhShort();
        }
        
    }
    
}