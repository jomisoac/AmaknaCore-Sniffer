

// Generated on 09/01/2021 10:11:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameMapChangeOrientationMessage : NetworkMessage
    {
        public const uint Id = 2457;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ActorOrientation orientation;
        
        public GameMapChangeOrientationMessage()
        {
        }
        
        public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
        {
            this.orientation = orientation;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            orientation.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            orientation = new Types.ActorOrientation();
            orientation.Deserialize(reader);
        }
        
    }
    
}