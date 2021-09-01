

// Generated on 09/01/2021 10:11:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceInvitationStateRecrutedMessage : NetworkMessage
    {
        public const uint Id = 6214;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte invitationState;
        
        public AllianceInvitationStateRecrutedMessage()
        {
        }
        
        public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(invitationState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            invitationState = reader.ReadSbyte();
        }
        
    }
    
}