

// Generated on 08/19/2021 23:34:30
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayDelayedActionMessage : NetworkMessage
    {
        public const uint Id = 6;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double delayedCharacterId;
        public sbyte delayTypeId;
        public double delayEndTime;
        
        public GameRolePlayDelayedActionMessage()
        {
        }
        
        public GameRolePlayDelayedActionMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(delayedCharacterId);
            writer.WriteSbyte(delayTypeId);
            writer.WriteDouble(delayEndTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            delayedCharacterId = reader.ReadDouble();
            delayTypeId = reader.ReadSbyte();
            delayEndTime = reader.ReadDouble();
        }
        
    }
    
}