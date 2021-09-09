

// Generated on 09/08/2021 14:22:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BulletinMessage : SocialNoticeMessage
    {
        public const uint Id = 1259;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int lastNotifiedTimestamp;
        
        public BulletinMessage()
        {
        }
        
        public BulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName)
        {
            this.lastNotifiedTimestamp = lastNotifiedTimestamp;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(lastNotifiedTimestamp);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            lastNotifiedTimestamp = reader.ReadInt();
        }
        
    }
    
}