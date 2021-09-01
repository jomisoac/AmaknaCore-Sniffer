

// Generated on 09/01/2021 10:11:46
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