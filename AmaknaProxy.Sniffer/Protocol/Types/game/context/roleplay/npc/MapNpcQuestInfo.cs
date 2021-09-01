

// Generated on 09/01/2021 10:12:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MapNpcQuestInfo
    {
        public const short Id = 6262;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double mapId;
        public int[] npcsIdsWithQuest;
        public Types.GameRolePlayNpcQuestFlag[] questFlags;
        
        public MapNpcQuestInfo()
        {
        }
        
        public MapNpcQuestInfo(double mapId, int[] npcsIdsWithQuest, Types.GameRolePlayNpcQuestFlag[] questFlags)
        {
            this.mapId = mapId;
            this.npcsIdsWithQuest = npcsIdsWithQuest;
            this.questFlags = questFlags;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
            writer.WriteShort((short)npcsIdsWithQuest.Length);
            foreach (var entry in npcsIdsWithQuest)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)questFlags.Length);
            foreach (var entry in questFlags)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            npcsIdsWithQuest = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 npcsIdsWithQuest[i] = reader.ReadInt();
            }
            limit = (ushort)reader.ReadUShort();
            questFlags = new Types.GameRolePlayNpcQuestFlag[limit];
            for (int i = 0; i < limit; i++)
            {
                 questFlags[i] = new Types.GameRolePlayNpcQuestFlag();
                 questFlags[i].Deserialize(reader);
            }
        }
        
    }
    
}