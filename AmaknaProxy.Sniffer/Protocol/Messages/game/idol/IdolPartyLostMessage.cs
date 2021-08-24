

// Generated on 08/19/2021 23:34:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdolPartyLostMessage : NetworkMessage
    {
        public const uint Id = 5868;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint idolId;
        
        public IdolPartyLostMessage()
        {
        }
        
        public IdolPartyLostMessage(uint idolId)
        {
            this.idolId = idolId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)idolId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            idolId = reader.ReadVarUhShort();
        }
        
    }
    
}