

// Generated on 09/08/2021 14:21:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountEquipedErrorMessage : NetworkMessage
    {
        public const uint Id = 1488;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte errorType;
        
        public MountEquipedErrorMessage()
        {
        }
        
        public MountEquipedErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(errorType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            errorType = reader.ReadSbyte();
        }
        
    }
    
}