

// Generated on 09/01/2021 10:11:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
    {
        public const uint Id = 7492;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string content;
        
        public GuildMotdSetRequestMessage()
        {
        }
        
        public GuildMotdSetRequestMessage(string content)
        {
            this.content = content;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            content = reader.ReadUTF();
        }
        
    }
    
}