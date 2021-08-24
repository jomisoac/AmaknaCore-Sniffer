

// Generated on 08/19/2021 23:34:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyLeaveMessage : AbstractPartyMessage
    {
        public const uint Id = 3653;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PartyLeaveMessage()
        {
        }
        
        public PartyLeaveMessage(uint partyId)
         : base(partyId)
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