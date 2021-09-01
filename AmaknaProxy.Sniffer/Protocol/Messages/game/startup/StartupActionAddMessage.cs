

// Generated on 09/01/2021 10:12:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StartupActionAddMessage : NetworkMessage
    {
        public const uint Id = 2141;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.StartupActionAddObject newAction;
        
        public StartupActionAddMessage()
        {
        }
        
        public StartupActionAddMessage(Types.StartupActionAddObject newAction)
        {
            this.newAction = newAction;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            newAction.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            newAction = new Types.StartupActionAddObject();
            newAction.Deserialize(reader);
        }
        
    }
    
}