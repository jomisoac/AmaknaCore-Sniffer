

// Generated on 09/01/2021 10:11:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendGuildWarnOnAchievementCompleteStateMessage : NetworkMessage
    {
        public const uint Id = 5548;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool enable;
        
        public FriendGuildWarnOnAchievementCompleteStateMessage()
        {
        }
        
        public FriendGuildWarnOnAchievementCompleteStateMessage(bool enable)
        {
            this.enable = enable;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            enable = reader.ReadBoolean();
        }
        
    }
    
}