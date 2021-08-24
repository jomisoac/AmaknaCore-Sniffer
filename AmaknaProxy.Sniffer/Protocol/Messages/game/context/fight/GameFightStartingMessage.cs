

// Generated on 08/19/2021 23:34:26
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightStartingMessage : NetworkMessage
    {
        public const uint Id = 7976;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte fightType;
        public uint fightId;
        public double attackerId;
        public double defenderId;
        public bool containsBoss;
        
        public GameFightStartingMessage()
        {
        }
        
        public GameFightStartingMessage(sbyte fightType, uint fightId, double attackerId, double defenderId, bool containsBoss)
        {
            this.fightType = fightType;
            this.fightId = fightId;
            this.attackerId = attackerId;
            this.defenderId = defenderId;
            this.containsBoss = containsBoss;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(fightType);
            writer.WriteVarShort((int)fightId);
            writer.WriteDouble(attackerId);
            writer.WriteDouble(defenderId);
            writer.WriteBoolean(containsBoss);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightType = reader.ReadSbyte();
            fightId = reader.ReadVarUhShort();
            attackerId = reader.ReadDouble();
            defenderId = reader.ReadDouble();
            containsBoss = reader.ReadBoolean();
        }
        
    }
    
}