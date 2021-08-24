

// Generated on 08/19/2021 23:35:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayActorInformations : GameContextActorInformations
    {
        public const short Id = 5720;
        public override short TypeId
        {
            get { return Id; }
        }
        
        
        public GameRolePlayActorInformations()
        {
        }
        
        public GameRolePlayActorInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look)
         : base(contextualId, disposition, look)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}