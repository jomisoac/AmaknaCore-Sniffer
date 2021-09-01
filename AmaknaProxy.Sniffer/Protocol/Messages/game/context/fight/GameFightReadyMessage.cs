

// Generated on 09/01/2021 10:11:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightReadyMessage : NetworkMessage
    {
        public const uint Id = 37;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool isReady;
        
        public GameFightReadyMessage()
        {
        }
        
        public GameFightReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(isReady);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            isReady = reader.ReadBoolean();
        }
        
    }
    
}