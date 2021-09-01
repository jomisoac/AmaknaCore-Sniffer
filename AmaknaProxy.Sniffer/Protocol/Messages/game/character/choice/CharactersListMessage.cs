

// Generated on 09/01/2021 10:11:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharactersListMessage : BasicCharactersListMessage
    {
        public const uint Id = 7692;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool hasStartupActions;
        
        public CharactersListMessage()
        {
        }
        
        public CharactersListMessage(Types.CharacterBaseInformations[] characters, bool hasStartupActions)
         : base(characters)
        {
            this.hasStartupActions = hasStartupActions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(hasStartupActions);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            hasStartupActions = reader.ReadBoolean();
        }
        
    }
    
}