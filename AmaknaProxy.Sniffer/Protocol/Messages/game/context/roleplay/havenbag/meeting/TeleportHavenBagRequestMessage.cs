

// Generated on 08/19/2021 23:34:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportHavenBagRequestMessage : NetworkMessage
    {
        public const uint Id = 4331;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double guestId;
        
        public TeleportHavenBagRequestMessage()
        {
        }
        
        public TeleportHavenBagRequestMessage(double guestId)
        {
            this.guestId = guestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(guestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guestId = reader.ReadVarUhLong();
        }
        
    }
    
}