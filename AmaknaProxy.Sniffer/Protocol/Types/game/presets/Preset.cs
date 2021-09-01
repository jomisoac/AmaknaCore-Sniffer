

// Generated on 09/01/2021 10:12:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Preset
    {
        public const short Id = 6748;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short id;
        
        public Preset()
        {
        }
        
        public Preset(short id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(id);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadShort();
        }
        
    }
    
}