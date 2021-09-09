

// Generated on 09/08/2021 14:21:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class NotificationUpdateFlagMessage : NetworkMessage
    {
        public const uint Id = 552;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint index;
        
        public NotificationUpdateFlagMessage()
        {
        }
        
        public NotificationUpdateFlagMessage(uint index)
        {
            this.index = index;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)index);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            index = reader.ReadVarUhShort();
        }
        
    }
    
}