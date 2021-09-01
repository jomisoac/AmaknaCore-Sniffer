

// Generated on 09/01/2021 10:11:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AcquaintanceSearchErrorMessage : NetworkMessage
    {
        public const uint Id = 6800;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte reason;
        
        public AcquaintanceSearchErrorMessage()
        {
        }
        
        public AcquaintanceSearchErrorMessage(sbyte reason)
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