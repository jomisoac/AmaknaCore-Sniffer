

// Generated on 09/01/2021 10:11:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceBulletinMessage : BulletinMessage
    {
        public const uint Id = 6273;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AllianceBulletinMessage()
        {
        }
        
        public AllianceBulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName, lastNotifiedTimestamp)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}