

// Generated on 09/01/2021 10:11:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChangeHavenBagRoomRequestMessage : NetworkMessage
    {
        public const uint Id = 3960;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte roomId;
        
        public ChangeHavenBagRoomRequestMessage()
        {
        }
        
        public ChangeHavenBagRoomRequestMessage(sbyte roomId)
        {
            this.roomId = roomId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(roomId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            roomId = reader.ReadSbyte();
        }
        
    }
    
}