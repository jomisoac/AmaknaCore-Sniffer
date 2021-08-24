

// Generated on 08/19/2021 23:35:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AnomalySubareaInformation
    {
        public const short Id = 1547;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public int rewardRate;
        public bool hasAnomaly;
        public double anomalyClosingTime;
        
        public AnomalySubareaInformation()
        {
        }
        
        public AnomalySubareaInformation(uint subAreaId, int rewardRate, bool hasAnomaly, double anomalyClosingTime)
        {
            this.subAreaId = subAreaId;
            this.rewardRate = rewardRate;
            this.hasAnomaly = hasAnomaly;
            this.anomalyClosingTime = anomalyClosingTime;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)rewardRate);
            writer.WriteBoolean(hasAnomaly);
            writer.WriteVarLong(anomalyClosingTime);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            rewardRate = reader.ReadVarShort();
            hasAnomaly = reader.ReadBoolean();
            anomalyClosingTime = reader.ReadVarUhLong();
        }
        
    }
    
}