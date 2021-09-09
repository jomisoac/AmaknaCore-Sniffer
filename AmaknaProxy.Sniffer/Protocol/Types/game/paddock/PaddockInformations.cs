

// Generated on 09/08/2021 14:22:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PaddockInformations
    {
        public const short Id = 1010;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint maxOutdoorMount;
        public uint maxItems;
        
        public PaddockInformations()
        {
        }
        
        public PaddockInformations(uint maxOutdoorMount, uint maxItems)
        {
            this.maxOutdoorMount = maxOutdoorMount;
            this.maxItems = maxItems;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)maxOutdoorMount);
            writer.WriteVarShort((int)maxItems);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            maxOutdoorMount = reader.ReadVarUhShort();
            maxItems = reader.ReadVarUhShort();
        }
        
    }
    
}