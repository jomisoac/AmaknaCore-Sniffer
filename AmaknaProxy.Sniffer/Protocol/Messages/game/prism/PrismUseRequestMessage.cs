

// Generated on 09/08/2021 14:22:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismUseRequestMessage : NetworkMessage
    {
        public const uint Id = 4515;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte moduleToUse;
        
        public PrismUseRequestMessage()
        {
        }
        
        public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(moduleToUse);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            moduleToUse = reader.ReadSbyte();
        }
        
    }
    
}