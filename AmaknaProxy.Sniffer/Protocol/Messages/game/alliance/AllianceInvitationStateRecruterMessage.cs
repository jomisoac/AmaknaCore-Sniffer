

// Generated on 08/19/2021 23:34:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceInvitationStateRecruterMessage : NetworkMessage
    {
        public const uint Id = 6648;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string recrutedName;
        public sbyte invitationState;
        
        public AllianceInvitationStateRecruterMessage()
        {
        }
        
        public AllianceInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(recrutedName);
            writer.WriteSbyte(invitationState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSbyte();
        }
        
    }
    
}