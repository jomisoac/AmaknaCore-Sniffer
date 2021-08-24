

// Generated on 08/19/2021 23:34:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
    {
        public const uint Id = 6278;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public uint delta;
        
        public GameActionFightLifePointsGainMessage()
        {
        }
        
        public GameActionFightLifePointsGainMessage(uint actionId, double sourceId, double targetId, uint delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)delta);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            delta = reader.ReadVarUhInt();
        }
        
    }
    
}