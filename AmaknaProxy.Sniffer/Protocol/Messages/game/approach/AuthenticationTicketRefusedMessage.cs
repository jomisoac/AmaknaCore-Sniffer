

// Generated on 08/19/2021 23:34:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AuthenticationTicketRefusedMessage : NetworkMessage
    {
        public const uint Id = 3932;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AuthenticationTicketRefusedMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}