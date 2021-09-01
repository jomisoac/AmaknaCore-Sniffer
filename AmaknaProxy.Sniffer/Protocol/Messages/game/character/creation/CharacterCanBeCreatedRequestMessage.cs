

// Generated on 09/01/2021 10:11:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterCanBeCreatedRequestMessage : NetworkMessage
    {
        public const uint Id = 9021;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public CharacterCanBeCreatedRequestMessage()
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