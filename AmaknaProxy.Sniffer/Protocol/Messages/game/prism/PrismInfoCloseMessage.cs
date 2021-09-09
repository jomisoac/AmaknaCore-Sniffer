

// Generated on 09/08/2021 14:22:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismInfoCloseMessage : NetworkMessage
    {
        public const uint Id = 4982;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PrismInfoCloseMessage()
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