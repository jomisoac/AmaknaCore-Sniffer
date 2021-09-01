

// Generated on 09/01/2021 10:11:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayAttackMonsterRequestMessage : NetworkMessage
    {
        public const uint Id = 3441;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double monsterGroupId;
        
        public GameRolePlayAttackMonsterRequestMessage()
        {
        }
        
        public GameRolePlayAttackMonsterRequestMessage(double monsterGroupId)
        {
            this.monsterGroupId = monsterGroupId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(monsterGroupId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            monsterGroupId = reader.ReadDouble();
        }
        
    }
    
}