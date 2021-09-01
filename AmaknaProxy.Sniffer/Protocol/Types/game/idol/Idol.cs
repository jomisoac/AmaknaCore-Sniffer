

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Idol
    {
        public const short Id = 5210;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint xpBonusPercent;
        public uint dropBonusPercent;
        
        public Idol()
        {
        }
        
        public Idol(uint id, uint xpBonusPercent, uint dropBonusPercent)
        {
            this.id = id;
            this.xpBonusPercent = xpBonusPercent;
            this.dropBonusPercent = dropBonusPercent;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)id);
            writer.WriteVarShort((int)xpBonusPercent);
            writer.WriteVarShort((int)dropBonusPercent);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUhShort();
            xpBonusPercent = reader.ReadVarUhShort();
            dropBonusPercent = reader.ReadVarUhShort();
        }
        
    }
    
}