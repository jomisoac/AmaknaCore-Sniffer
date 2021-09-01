

// Generated on 09/01/2021 10:11:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachInvitationCloseMessage : NetworkMessage
    {
        public const uint Id = 8320;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterMinimalInformations host;
        
        public BreachInvitationCloseMessage()
        {
        }
        
        public BreachInvitationCloseMessage(Types.CharacterMinimalInformations host)
        {
            this.host = host;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            host.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            host = new Types.CharacterMinimalInformations();
            host.Deserialize(reader);
        }
        
    }
    
}