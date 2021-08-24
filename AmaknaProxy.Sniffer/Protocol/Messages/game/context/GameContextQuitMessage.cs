

// Generated on 08/19/2021 23:34:24
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameContextQuitMessage : NetworkMessage
    {
        public const uint Id = 7249;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GameContextQuitMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}