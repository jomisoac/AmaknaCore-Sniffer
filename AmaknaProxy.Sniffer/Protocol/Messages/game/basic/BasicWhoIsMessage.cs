

// Generated on 09/01/2021 10:11:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicWhoIsMessage : NetworkMessage
    {
        public const uint Id = 5025;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool self;
        public bool verbose;
        public sbyte position;
        public Types.AccountTagInformation accountTag;
        public int accountId;
        public string playerName;
        public double playerId;
        public short areaId;
        public short serverId;
        public short originServerId;
        public Types.AbstractSocialGroupInfos[] socialGroups;
        public sbyte playerState;
        
        public BasicWhoIsMessage()
        {
        }
        
        public BasicWhoIsMessage(bool self, bool verbose, sbyte position, Types.AccountTagInformation accountTag, int accountId, string playerName, double playerId, short areaId, short serverId, short originServerId, Types.AbstractSocialGroupInfos[] socialGroups, sbyte playerState)
        {
            this.self = self;
            this.verbose = verbose;
            this.position = position;
            this.accountTag = accountTag;
            this.accountId = accountId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.areaId = areaId;
            this.serverId = serverId;
            this.originServerId = originServerId;
            this.socialGroups = socialGroups;
            this.playerState = playerState;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, self);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, verbose);
            writer.WriteByte(flag1);
            writer.WriteSbyte(position);
            accountTag.Serialize(writer);
            writer.WriteInt(accountId);
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            writer.WriteShort(areaId);
            writer.WriteShort(serverId);
            writer.WriteShort(originServerId);
            writer.WriteShort((short)socialGroups.Length);
            foreach (var entry in socialGroups)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteSbyte(playerState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag1 = reader.ReadByte();
            self = BooleanByteWrapper.GetFlag(flag1, 0);
            verbose = BooleanByteWrapper.GetFlag(flag1, 1);
            position = reader.ReadSbyte();
            accountTag = new Types.AccountTagInformation();
            accountTag.Deserialize(reader);
            accountId = reader.ReadInt();
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            areaId = reader.ReadShort();
            serverId = reader.ReadShort();
            originServerId = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            socialGroups = new Types.AbstractSocialGroupInfos[limit];
            for (int i = 0; i < limit; i++)
            {
                 socialGroups[i] = ProtocolTypeManager.GetInstance<Types.AbstractSocialGroupInfos>(reader.ReadUShort());
                 socialGroups[i].Deserialize(reader);
            }
            playerState = reader.ReadSbyte();
        }
        
    }
    
}