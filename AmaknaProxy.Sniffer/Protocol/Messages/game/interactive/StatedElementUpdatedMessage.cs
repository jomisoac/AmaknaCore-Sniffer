

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StatedElementUpdatedMessage : NetworkMessage
    {
        public const uint Id = 4006;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.StatedElement statedElement;
        
        public StatedElementUpdatedMessage()
        {
        }
        
        public StatedElementUpdatedMessage(Types.StatedElement statedElement)
        {
            this.statedElement = statedElement;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            statedElement.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            statedElement = new Types.StatedElement();
            statedElement.Deserialize(reader);
        }
        
    }
    
}