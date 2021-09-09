

// Generated on 09/08/2021 14:21:51
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BreachInvitationOfferMessage : NetworkMessage
    {
        public const uint Id = 6134;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterMinimalInformations host;
        public uint timeLeftBeforeCancel;
        
        public BreachInvitationOfferMessage()
        {
        }
        
        public BreachInvitationOfferMessage(Types.CharacterMinimalInformations host, uint timeLeftBeforeCancel)
        {
            this.host = host;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            host.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            host = new Types.CharacterMinimalInformations();
            host.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarUhInt();
        }
        
    }
    
}