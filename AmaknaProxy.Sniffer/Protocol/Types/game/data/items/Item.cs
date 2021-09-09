

// Generated on 09/08/2021 14:22:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Item
    {
        public const short Id = 4071;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public Item()
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