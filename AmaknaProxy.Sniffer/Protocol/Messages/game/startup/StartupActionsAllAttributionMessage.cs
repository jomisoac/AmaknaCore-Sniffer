

// Generated on 08/19/2021 23:34:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StartupActionsAllAttributionMessage : NetworkMessage
    {
        public const uint Id = 2880;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double characterId;
        
        public StartupActionsAllAttributionMessage()
        {
        }
        
        public StartupActionsAllAttributionMessage(double characterId)
        {
            this.characterId = characterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            characterId = reader.ReadVarUhLong();
        }
        
    }
    
}