

// Generated on 09/01/2021 10:11:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachBudgetMessage : NetworkMessage
    {
        public const uint Id = 1748;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint bugdet;
        
        public BreachBudgetMessage()
        {
        }
        
        public BreachBudgetMessage(uint bugdet)
        {
            this.bugdet = bugdet;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)bugdet);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            bugdet = reader.ReadVarUhInt();
        }
        
    }
    
}