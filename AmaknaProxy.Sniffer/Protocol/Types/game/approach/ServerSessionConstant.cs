

// Generated on 08/19/2021 23:34:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ServerSessionConstant
    {
        public const short Id = 2772;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        
        public ServerSessionConstant()
        {
        }
        
        public ServerSessionConstant(uint id)
        {
            this.id = id;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)id);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUhShort();
        }
        
    }
    
}