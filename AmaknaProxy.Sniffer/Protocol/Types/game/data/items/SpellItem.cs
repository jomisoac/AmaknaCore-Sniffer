

// Generated on 09/01/2021 10:12:18
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SpellItem : Item
    {
        public const short Id = 5350;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int spellId;
        public short spellLevel;
        
        public SpellItem()
        {
        }
        
        public SpellItem(int spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(spellId);
            writer.WriteShort(spellLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            spellId = reader.ReadInt();
            spellLevel = reader.ReadShort();
        }
        
    }
    
}