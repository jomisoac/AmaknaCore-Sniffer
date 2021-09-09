

// Generated on 09/08/2021 14:21:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
    {
        public const uint Id = 8574;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double partyLeaderId;
        
        public PartyLeaderUpdateMessage()
        {
        }
        
        public PartyLeaderUpdateMessage(uint partyId, double partyLeaderId)
         : base(partyId)
        {
            this.partyLeaderId = partyLeaderId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(partyLeaderId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            partyLeaderId = reader.ReadVarUhLong();
        }
        
    }
    
}