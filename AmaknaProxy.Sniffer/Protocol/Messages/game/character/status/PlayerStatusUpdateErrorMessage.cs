

// Generated on 09/08/2021 14:21:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PlayerStatusUpdateErrorMessage : NetworkMessage
    {
        public const uint Id = 266;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PlayerStatusUpdateErrorMessage()
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