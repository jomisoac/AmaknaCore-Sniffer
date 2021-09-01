

// Generated on 09/01/2021 10:12:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpawnInformation
    {
        public const short Id = 9403;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public SpawnInformation()
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