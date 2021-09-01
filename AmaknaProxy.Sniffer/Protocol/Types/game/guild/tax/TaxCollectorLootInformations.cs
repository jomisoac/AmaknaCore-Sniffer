

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
    {
        public const short Id = 9341;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double kamas;
        public double experience;
        public uint pods;
        public double itemsValue;
        
        public TaxCollectorLootInformations()
        {
        }
        
        public TaxCollectorLootInformations(double kamas, double experience, uint pods, double itemsValue)
        {
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(kamas);
            writer.WriteVarLong(experience);
            writer.WriteVarInt((int)pods);
            writer.WriteVarLong(itemsValue);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            kamas = reader.ReadVarUhLong();
            experience = reader.ReadVarUhLong();
            pods = reader.ReadVarUhInt();
            itemsValue = reader.ReadVarUhLong();
        }
        
    }
    
}