

// Generated on 09/01/2021 10:11:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseSellRequestMessage : NetworkMessage
    {
        public const uint Id = 1652;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int instanceId;
        public double amount;
        public bool forSale;
        
        public HouseSellRequestMessage()
        {
        }
        
        public HouseSellRequestMessage(int instanceId, double amount, bool forSale)
        {
            this.instanceId = instanceId;
            this.amount = amount;
            this.forSale = forSale;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(instanceId);
            writer.WriteVarLong(amount);
            writer.WriteBoolean(forSale);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            instanceId = reader.ReadInt();
            amount = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
        }
        
    }
    
}