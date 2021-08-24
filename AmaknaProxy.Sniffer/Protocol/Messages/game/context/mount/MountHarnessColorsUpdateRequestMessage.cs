

// Generated on 08/19/2021 23:34:27
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountHarnessColorsUpdateRequestMessage : NetworkMessage
    {
        public const uint Id = 8829;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool useHarnessColors;
        
        public MountHarnessColorsUpdateRequestMessage()
        {
        }
        
        public MountHarnessColorsUpdateRequestMessage(bool useHarnessColors)
        {
            this.useHarnessColors = useHarnessColors;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(useHarnessColors);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            useHarnessColors = reader.ReadBoolean();
        }
        
    }
    
}