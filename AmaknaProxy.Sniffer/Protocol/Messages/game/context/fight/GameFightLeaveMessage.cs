

// Generated on 09/08/2021 14:21:47
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightLeaveMessage : NetworkMessage
    {
        public const uint Id = 2140;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double charId;
        
        public GameFightLeaveMessage()
        {
        }
        
        public GameFightLeaveMessage(double charId)
        {
            this.charId = charId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(charId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            charId = reader.ReadDouble();
        }
        
    }
    
}