

// Generated on 09/08/2021 14:22:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightEffectTriggerCount
    {
        public const short Id = 2413;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint effectId;
        public double targetId;
        public sbyte count;
        
        public GameFightEffectTriggerCount()
        {
        }
        
        public GameFightEffectTriggerCount(uint effectId, double targetId, sbyte count)
        {
            this.effectId = effectId;
            this.targetId = targetId;
            this.count = count;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)effectId);
            writer.WriteDouble(targetId);
            writer.WriteSbyte(count);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            effectId = reader.ReadVarUhInt();
            targetId = reader.ReadDouble();
            count = reader.ReadSbyte();
        }
        
    }
    
}