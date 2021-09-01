

// Generated on 09/01/2021 10:11:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlliancePartialListMessage : AllianceListMessage
    {
        public const uint Id = 1670;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public AlliancePartialListMessage()
        {
        }
        
        public AlliancePartialListMessage(Types.AllianceFactSheetInformations[] alliances)
         : base(alliances)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}