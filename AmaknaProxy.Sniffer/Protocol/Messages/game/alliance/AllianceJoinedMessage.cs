

// Generated on 09/01/2021 10:11:37
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AllianceJoinedMessage : NetworkMessage
    {
        public const uint Id = 9123;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AllianceInformations allianceInfo;
        public bool enabled;
        public uint leadingGuildId;
        
        public AllianceJoinedMessage()
        {
        }
        
        public AllianceJoinedMessage(Types.AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
        {
            this.allianceInfo = allianceInfo;
            this.enabled = enabled;
            this.leadingGuildId = leadingGuildId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            allianceInfo.Serialize(writer);
            writer.WriteBoolean(enabled);
            writer.WriteVarInt((int)leadingGuildId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            allianceInfo = new Types.AllianceInformations();
            allianceInfo.Deserialize(reader);
            enabled = reader.ReadBoolean();
            leadingGuildId = reader.ReadVarUhInt();
        }
        
    }
    
}