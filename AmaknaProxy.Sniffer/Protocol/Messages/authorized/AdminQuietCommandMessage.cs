

// Generated on 08/19/2021 23:34:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AdminQuietCommandMessage : AdminCommandMessage
    {
        public const uint Id = 5788;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AdminQuietCommandMessage()
        {
        }
        
        public AdminQuietCommandMessage(string content)
         : base(content)
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