

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
    {
        public const short Id = 1956;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.EntityLook entityLook;
        public sbyte breed;
        
        public CharacterMinimalPlusLookInformations()
        {
        }
        
        public CharacterMinimalPlusLookInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed)
         : base(id, name, level)
        {
            this.entityLook = entityLook;
            this.breed = breed;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            entityLook.Serialize(writer);
            writer.WriteSbyte(breed);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            breed = reader.ReadSbyte();
        }
        
    }
    
}