

// Generated on 09/08/2021 14:21:52
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CloseHavenBagFurnitureSequenceRequestMessage : NetworkMessage
    {
        public const uint Id = 5763;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public CloseHavenBagFurnitureSequenceRequestMessage()
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