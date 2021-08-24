

// Generated on 08/19/2021 23:34:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeSetCraftRecipeMessage : NetworkMessage
    {
        public const uint Id = 3940;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectGID;
        
        public ExchangeSetCraftRecipeMessage()
        {
        }
        
        public ExchangeSetCraftRecipeMessage(uint objectGID)
        {
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)objectGID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}