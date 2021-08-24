

// Generated on 08/19/2021 23:34:53
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccessoryPreviewErrorMessage : NetworkMessage
    {
        public const uint Id = 1428;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte error;
        
        public AccessoryPreviewErrorMessage()
        {
        }
        
        public AccessoryPreviewErrorMessage(sbyte error)
        {
            this.error = error;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(error);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            error = reader.ReadSbyte();
        }
        
    }
    
}