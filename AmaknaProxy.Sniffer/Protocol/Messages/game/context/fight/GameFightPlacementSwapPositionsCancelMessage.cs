

// Generated on 09/01/2021 10:11:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightPlacementSwapPositionsCancelMessage : NetworkMessage
    {
        public const uint Id = 7979;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int requestId;
        
        public GameFightPlacementSwapPositionsCancelMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsCancelMessage(int requestId)
        {
            this.requestId = requestId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(requestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadInt();
        }
        
    }
    
}