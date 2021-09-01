

// Generated on 09/01/2021 10:11:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayFightRequestCanceledMessage : NetworkMessage
    {
        public const uint Id = 3985;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public double sourceId;
        public double targetId;
        
        public GameRolePlayFightRequestCanceledMessage()
        {
        }
        
        public GameRolePlayFightRequestCanceledMessage(uint fightId, double sourceId, double targetId)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)fightId);
            writer.WriteDouble(sourceId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
            targetId = reader.ReadDouble();
        }
        
    }
    
}