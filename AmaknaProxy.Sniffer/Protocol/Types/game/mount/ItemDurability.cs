

// Generated on 09/08/2021 14:22:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ItemDurability
    {
        public const short Id = 988;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short durability;
        public short durabilityMax;
        
        public ItemDurability()
        {
        }
        
        public ItemDurability(short durability, short durabilityMax)
        {
            this.durability = durability;
            this.durabilityMax = durabilityMax;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(durability);
            writer.WriteShort(durabilityMax);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            durability = reader.ReadShort();
            durabilityMax = reader.ReadShort();
        }
        
    }
    
}