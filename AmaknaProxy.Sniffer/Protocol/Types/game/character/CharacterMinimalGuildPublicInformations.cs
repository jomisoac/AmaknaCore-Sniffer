

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterMinimalGuildPublicInformations : CharacterMinimalInformations
    {
        public const short Id = 5512;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint rank;
        
        public CharacterMinimalGuildPublicInformations()
        {
        }
        
        public CharacterMinimalGuildPublicInformations(double id, string name, uint level, uint rank)
         : base(id, name, level)
        {
            this.rank = rank;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)rank);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            rank = reader.ReadVarUhInt();
        }
        
    }
    
}