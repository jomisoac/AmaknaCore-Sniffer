

// Generated on 09/08/2021 14:22:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class StatisticData
    {
        public const short Id = 2111;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public StatisticData()
        {
        }
        
        
        public virtual void Serialize(IDataWriter writer)
        {
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}