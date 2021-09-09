

// Generated on 09/08/2021 14:22:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatisticDataBoolean : StatisticData
    {
        public const short Id = 9792;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public bool value;
        
        public StatisticDataBoolean()
        {
        }
        
        public StatisticDataBoolean(bool value)
        {
            this.value = value;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            value = reader.ReadBoolean();
        }
        
    }
    
}