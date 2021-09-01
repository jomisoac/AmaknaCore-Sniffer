

// Generated on 09/01/2021 10:11:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicWhoAmIRequestMessage : NetworkMessage
    {
        public const uint Id = 2167;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool verbose;
        
        public BasicWhoAmIRequestMessage()
        {
        }
        
        public BasicWhoAmIRequestMessage(bool verbose)
        {
            this.verbose = verbose;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(verbose);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            verbose = reader.ReadBoolean();
        }
        
    }
    
}