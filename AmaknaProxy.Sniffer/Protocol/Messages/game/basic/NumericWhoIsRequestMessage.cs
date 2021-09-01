

// Generated on 09/01/2021 10:11:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NumericWhoIsRequestMessage : NetworkMessage
    {
        public const uint Id = 7502;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public NumericWhoIsRequestMessage()
        {
        }
        
        public NumericWhoIsRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}