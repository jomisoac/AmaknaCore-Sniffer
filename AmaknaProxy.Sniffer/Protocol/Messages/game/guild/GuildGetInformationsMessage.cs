

// Generated on 09/01/2021 10:11:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildGetInformationsMessage : NetworkMessage
    {
        public const uint Id = 5467;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte infoType;
        
        public GuildGetInformationsMessage()
        {
        }
        
        public GuildGetInformationsMessage(sbyte infoType)
        {
            this.infoType = infoType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(infoType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            infoType = reader.ReadSbyte();
        }
        
    }
    
}