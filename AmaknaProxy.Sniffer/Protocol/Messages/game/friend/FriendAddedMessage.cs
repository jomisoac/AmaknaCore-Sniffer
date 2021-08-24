

// Generated on 08/19/2021 23:34:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class FriendAddedMessage : NetworkMessage
    {
        public const uint Id = 2089;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.FriendInformations friendAdded;
        
        public FriendAddedMessage()
        {
        }
        
        public FriendAddedMessage(Types.FriendInformations friendAdded)
        {
            this.friendAdded = friendAdded;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(friendAdded.TypeId);
            friendAdded.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            friendAdded = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadUShort());
            friendAdded.Deserialize(reader);
        }
        
    }
    
}