

// Generated on 08/19/2021 23:34:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyNameSetRequestMessage : AbstractPartyMessage
    {
        public const uint Id = 2939;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string partyName;
        
        public PartyNameSetRequestMessage()
        {
        }
        
        public PartyNameSetRequestMessage(uint partyId, string partyName)
         : base(partyId)
        {
            this.partyName = partyName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(partyName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            partyName = reader.ReadUTF();
        }
        
    }
    
}