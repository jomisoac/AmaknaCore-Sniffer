

// Generated on 09/08/2021 14:22:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildFightPlayersEnemiesListMessage : NetworkMessage
    {
        public const uint Id = 3648;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double fightId;
        public Types.CharacterMinimalPlusLookInformations[] playerInfo;
        
        public GuildFightPlayersEnemiesListMessage()
        {
        }
        
        public GuildFightPlayersEnemiesListMessage(double fightId, Types.CharacterMinimalPlusLookInformations[] playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(fightId);
            writer.WriteShort((short)playerInfo.Length);
            foreach (var entry in playerInfo)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            playerInfo = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerInfo[i] = new Types.CharacterMinimalPlusLookInformations();
                 playerInfo[i].Deserialize(reader);
            }
        }
        
    }
    
}