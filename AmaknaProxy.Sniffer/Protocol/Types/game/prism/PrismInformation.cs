

// Generated on 08/19/2021 23:35:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PrismInformation
    {
        public const short Id = 1753;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte typeId;
        public sbyte state;
        public int nextVulnerabilityDate;
        public int placementDate;
        public uint rewardTokenCount;
        
        public PrismInformation()
        {
        }
        
        public PrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount)
        {
            this.typeId = typeId;
            this.state = state;
            this.nextVulnerabilityDate = nextVulnerabilityDate;
            this.placementDate = placementDate;
            this.rewardTokenCount = rewardTokenCount;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(typeId);
            writer.WriteSbyte(state);
            writer.WriteInt(nextVulnerabilityDate);
            writer.WriteInt(placementDate);
            writer.WriteVarInt((int)rewardTokenCount);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            typeId = reader.ReadSbyte();
            state = reader.ReadSbyte();
            nextVulnerabilityDate = reader.ReadInt();
            placementDate = reader.ReadInt();
            rewardTokenCount = reader.ReadVarUhInt();
        }
        
    }
    
}