

// Generated on 09/01/2021 10:11:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IgnoredAddRequestMessage : NetworkMessage
    {
        public const uint Id = 2703;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AbstractPlayerSearchInformation target;
        public bool session;
        
        public IgnoredAddRequestMessage()
        {
        }
        
        public IgnoredAddRequestMessage(Types.AbstractPlayerSearchInformation target, bool session)
        {
            this.target = target;
            this.session = session;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(target.TypeId);
            target.Serialize(writer);
            writer.WriteBoolean(session);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            target = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            target.Deserialize(reader);
            session = reader.ReadBoolean();
        }
        
    }
    
}