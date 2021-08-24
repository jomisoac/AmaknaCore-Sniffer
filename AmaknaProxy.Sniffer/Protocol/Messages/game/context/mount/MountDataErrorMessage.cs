

// Generated on 08/19/2021 23:34:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountDataErrorMessage : NetworkMessage
    {
        public const uint Id = 4449;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public MountDataErrorMessage()
        {
        }
        
        public MountDataErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            reason = reader.ReadSbyte();
        }
        
    }
    
}