

// Generated on 08/19/2021 23:34:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdolPartyRegisterRequestMessage : NetworkMessage
    {
        public const uint Id = 7517;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool register;
        
        public IdolPartyRegisterRequestMessage()
        {
        }
        
        public IdolPartyRegisterRequestMessage(bool register)
        {
            this.register = register;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(register);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            register = reader.ReadBoolean();
        }
        
    }
    
}