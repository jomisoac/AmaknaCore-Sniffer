

// Generated on 09/01/2021 10:11:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterSelectedErrorMessage : NetworkMessage
    {
        public const uint Id = 2771;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public CharacterSelectedErrorMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}