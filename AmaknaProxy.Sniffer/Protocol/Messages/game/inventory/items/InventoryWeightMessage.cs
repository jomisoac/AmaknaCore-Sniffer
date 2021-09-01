

// Generated on 09/01/2021 10:12:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InventoryWeightMessage : NetworkMessage
    {
        public const uint Id = 7128;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint inventoryWeight;
        public uint shopWeight;
        public uint weightMax;
        
        public InventoryWeightMessage()
        {
        }
        
        public InventoryWeightMessage(uint inventoryWeight, uint shopWeight, uint weightMax)
        {
            this.inventoryWeight = inventoryWeight;
            this.shopWeight = shopWeight;
            this.weightMax = weightMax;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)inventoryWeight);
            writer.WriteVarInt((int)shopWeight);
            writer.WriteVarInt((int)weightMax);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            inventoryWeight = reader.ReadVarUhInt();
            shopWeight = reader.ReadVarUhInt();
            weightMax = reader.ReadVarUhInt();
        }
        
    }
    
}