

// Generated on 09/08/2021 14:22:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SubscriptionLimitationMessage : NetworkMessage
    {
        public const uint Id = 6711;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public SubscriptionLimitationMessage()
        {
        }
        
        public SubscriptionLimitationMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}