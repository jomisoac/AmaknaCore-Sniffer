

// Generated on 09/08/2021 14:22:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMembershipMessage : GuildJoinedMessage
    {
        public const uint Id = 8256;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public GuildMembershipMessage()
        {
        }
        
        public GuildMembershipMessage(Types.GuildInformations guildInfo, uint memberRights)
         : base(guildInfo, memberRights)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}