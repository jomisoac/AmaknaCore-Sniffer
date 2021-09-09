

// Generated on 09/08/2021 14:21:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementFinishedMessage : NetworkMessage
    {
        public const uint Id = 7456;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AchievementAchievedRewardable achievement;
        
        public AchievementFinishedMessage()
        {
        }
        
        public AchievementFinishedMessage(Types.AchievementAchievedRewardable achievement)
        {
            this.achievement = achievement;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            achievement.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            achievement = new Types.AchievementAchievedRewardable();
            achievement.Deserialize(reader);
        }
        
    }
    
}