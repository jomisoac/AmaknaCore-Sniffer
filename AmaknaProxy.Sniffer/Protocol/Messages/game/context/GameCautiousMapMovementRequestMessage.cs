

// Generated on 09/01/2021 10:11:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameCautiousMapMovementRequestMessage : GameMapMovementRequestMessage
    {
        public const uint Id = 5698;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GameCautiousMapMovementRequestMessage()
        {
        }
        
        public GameCautiousMapMovementRequestMessage(short[] keyMovements, double mapId)
         : base(keyMovements, mapId)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}