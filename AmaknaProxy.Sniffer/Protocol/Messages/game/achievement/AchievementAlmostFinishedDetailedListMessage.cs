

// Generated on 09/01/2021 10:11:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AchievementAlmostFinishedDetailedListMessage : NetworkMessage
    {
        public const uint Id = 1599;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.Achievement[] almostFinishedAchievements;
        
        public AchievementAlmostFinishedDetailedListMessage()
        {
        }
        
        public AchievementAlmostFinishedDetailedListMessage(Types.Achievement[] almostFinishedAchievements)
        {
            this.almostFinishedAchievements = almostFinishedAchievements;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)almostFinishedAchievements.Length);
            foreach (var entry in almostFinishedAchievements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            almostFinishedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 almostFinishedAchievements[i] = new Types.Achievement();
                 almostFinishedAchievements[i].Deserialize(reader);
            }
        }
        
    }
    
}