

// Generated on 09/01/2021 10:12:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MonsterBoosts
    {
        public const short Id = 5803;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint id;
        public uint xpBoost;
        public uint dropBoost;
        
        public MonsterBoosts()
        {
        }
        
        public MonsterBoosts(uint id, uint xpBoost, uint dropBoost)
        {
            this.id = id;
            this.xpBoost = xpBoost;
            this.dropBoost = dropBoost;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)id);
            writer.WriteVarShort((int)xpBoost);
            writer.WriteVarShort((int)dropBoost);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUhInt();
            xpBoost = reader.ReadVarUhShort();
            dropBoost = reader.ReadVarUhShort();
        }
        
    }
    
}