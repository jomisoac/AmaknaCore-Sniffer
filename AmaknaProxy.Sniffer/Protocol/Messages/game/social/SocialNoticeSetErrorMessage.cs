

// Generated on 09/08/2021 14:22:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SocialNoticeSetErrorMessage : NetworkMessage
    {
        public const uint Id = 1339;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public SocialNoticeSetErrorMessage()
        {
        }
        
        public SocialNoticeSetErrorMessage(sbyte reason)
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