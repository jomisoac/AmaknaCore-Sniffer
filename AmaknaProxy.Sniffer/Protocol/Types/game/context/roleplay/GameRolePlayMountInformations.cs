

// Generated on 09/08/2021 14:22:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
    {
        public const short Id = 2326;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public string ownerName;
        public byte level;
        
        public GameRolePlayMountInformations()
        {
        }
        
        public GameRolePlayMountInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, string ownerName, byte level)
         : base(contextualId, disposition, look, name)
        {
            this.ownerName = ownerName;
            this.level = level;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(ownerName);
            writer.WriteByte(level);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            ownerName = reader.ReadUTF();
            level = reader.ReadByte();
        }
        
    }
    
}