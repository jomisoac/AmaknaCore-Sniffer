

// Generated on 09/01/2021 10:12:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
    {
        public const short Id = 3311;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public string name;
        public uint level;
        
        public FightTeamMemberCharacterInformations()
        {
        }
        
        public FightTeamMemberCharacterInformations(double id, string name, uint level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarShort((int)level);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadVarUhShort();
        }
        
    }
    
}