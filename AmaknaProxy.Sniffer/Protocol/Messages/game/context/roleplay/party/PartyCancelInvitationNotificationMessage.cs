

// Generated on 09/01/2021 10:11:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
    {
        public const uint Id = 1017;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double cancelerId;
        public double guestId;
        
        public PartyCancelInvitationNotificationMessage()
        {
        }
        
        public PartyCancelInvitationNotificationMessage(uint partyId, double cancelerId, double guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(cancelerId);
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            cancelerId = reader.ReadVarUhLong();
            guestId = reader.ReadVarUhLong();
        }
        
    }
    
}