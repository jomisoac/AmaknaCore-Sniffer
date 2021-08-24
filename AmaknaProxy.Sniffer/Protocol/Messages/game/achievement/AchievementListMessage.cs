

// Generated on 08/19/2021 23:34:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementListMessage : NetworkMessage
    {
        public const uint Id = 9654;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AchievementAchieved[] finishedAchievements;
        
        public AchievementListMessage()
        {
        }
        
        public AchievementListMessage(Types.AchievementAchieved[] finishedAchievements)
        {
            this.finishedAchievements = finishedAchievements;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)finishedAchievements.Length);
            foreach (var entry in finishedAchievements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            finishedAchievements = new Types.AchievementAchieved[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievements[i] = ProtocolTypeManager.GetInstance<Types.AchievementAchieved>(reader.ReadUShort());
                 finishedAchievements[i].Deserialize(reader);
            }
        }
        
    }
    
}