

// Generated on 09/01/2021 10:11:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
    {
        public const uint Id = 3724;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.JobCrafterDirectorySettings settings;
        
        public JobCrafterDirectoryDefineSettingsMessage()
        {
        }
        
        public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
        {
            this.settings = settings;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            settings.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            settings = new Types.JobCrafterDirectorySettings();
            settings.Deserialize(reader);
        }
        
    }
    
}