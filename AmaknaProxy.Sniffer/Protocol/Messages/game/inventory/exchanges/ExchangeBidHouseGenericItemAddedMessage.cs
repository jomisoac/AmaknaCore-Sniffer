

// Generated on 09/08/2021 14:22:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseGenericItemAddedMessage : NetworkMessage
    {
        public const uint Id = 5133;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objGenericId;
        
        public ExchangeBidHouseGenericItemAddedMessage()
        {
        }
        
        public ExchangeBidHouseGenericItemAddedMessage(uint objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)objGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objGenericId = reader.ReadVarUhShort();
        }
        
    }
    
}