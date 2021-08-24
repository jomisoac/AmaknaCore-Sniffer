

// Generated on 08/19/2021 23:34:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementDetailedListMessage : NetworkMessage
    {
        public const uint Id = 8315;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.Achievement[] startedAchievements;
        public Types.Achievement[] finishedAchievements;
        
        public AchievementDetailedListMessage()
        {
        }
        
        public AchievementDetailedListMessage(Types.Achievement[] startedAchievements, Types.Achievement[] finishedAchievements)
        {
            this.startedAchievements = startedAchievements;
            this.finishedAchievements = finishedAchievements;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)startedAchievements.Length);
            foreach (var entry in startedAchievements)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)finishedAchievements.Length);
            foreach (var entry in finishedAchievements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            startedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 startedAchievements[i] = new Types.Achievement();
                 startedAchievements[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            finishedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievements[i] = new Types.Achievement();
                 finishedAchievements[i].Deserialize(reader);
            }
        }
        
    }
    
}