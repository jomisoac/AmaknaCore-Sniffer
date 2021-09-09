

// Generated on 09/08/2021 14:22:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StartupActionsObjetAttributionMessage : NetworkMessage
    {
        public const uint Id = 10;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int actionId;
        public double characterId;
        
        public StartupActionsObjetAttributionMessage()
        {
        }
        
        public StartupActionsObjetAttributionMessage(int actionId, double characterId)
        {
            this.actionId = actionId;
            this.characterId = characterId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(actionId);
            writer.WriteVarLong(characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            actionId = reader.ReadInt();
            characterId = reader.ReadVarUhLong();
        }
        
    }
    
}