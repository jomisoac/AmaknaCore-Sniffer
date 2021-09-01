

// Generated on 09/01/2021 10:11:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMemberOnlineStatusMessage : NetworkMessage
    {
        public const uint Id = 4687;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double memberId;
        public bool online;
        
        public GuildMemberOnlineStatusMessage()
        {
        }
        
        public GuildMemberOnlineStatusMessage(double memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(memberId);
            writer.WriteBoolean(online);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            memberId = reader.ReadVarUhLong();
            online = reader.ReadBoolean();
        }
        
    }
    
}