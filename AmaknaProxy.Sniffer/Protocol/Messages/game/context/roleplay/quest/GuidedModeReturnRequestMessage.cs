

// Generated on 08/19/2021 23:34:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuidedModeReturnRequestMessage : NetworkMessage
    {
        public const uint Id = 1579;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuidedModeReturnRequestMessage()
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