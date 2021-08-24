

// Generated on 08/19/2021 23:34:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyNewMemberMessage : PartyUpdateMessage
    {
        public const uint Id = 7489;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PartyNewMemberMessage()
        {
        }
        
        public PartyNewMemberMessage(uint partyId, Types.PartyMemberInformations memberInformations)
         : base(partyId, memberInformations)
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