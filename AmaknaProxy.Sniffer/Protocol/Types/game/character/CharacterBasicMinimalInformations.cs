

// Generated on 08/19/2021 23:34:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterBasicMinimalInformations : AbstractCharacterInformation
    {
        public const short Id = 6835;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public string name;
        
        public CharacterBasicMinimalInformations()
        {
        }
        
        public CharacterBasicMinimalInformations(double id, string name)
         : base(id)
        {
            this.name = name;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
        }
        
    }
    
}