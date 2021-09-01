

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterMinimalInformations : CharacterBasicMinimalInformations
    {
        public const short Id = 2126;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint level;
        
        public CharacterMinimalInformations()
        {
        }
        
        public CharacterMinimalInformations(double id, string name, uint level)
         : base(id, name)
        {
            this.level = level;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)level);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadVarUhShort();
        }
        
    }
    
}