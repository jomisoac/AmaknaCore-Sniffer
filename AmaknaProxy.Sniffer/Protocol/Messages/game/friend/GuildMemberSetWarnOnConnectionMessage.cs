

// Generated on 09/08/2021 14:21:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMemberSetWarnOnConnectionMessage : NetworkMessage
    {
        public const uint Id = 6334;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool enable;
        
        public GuildMemberSetWarnOnConnectionMessage()
        {
        }
        
        public GuildMemberSetWarnOnConnectionMessage(bool enable)
        {
            this.enable = enable;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            enable = reader.ReadBoolean();
        }
        
    }
    
}