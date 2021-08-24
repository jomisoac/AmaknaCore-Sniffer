

// Generated on 08/19/2021 23:34:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class BasicLatencyStatsMessage : NetworkMessage
    {
        public const uint Id = 8738;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public ushort latency;
        public uint sampleCount;
        public uint max;
        
        public BasicLatencyStatsMessage()
        {
        }
        
        public BasicLatencyStatsMessage(ushort latency, uint sampleCount, uint max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(latency);
            writer.WriteVarShort((int)sampleCount);
            writer.WriteVarShort((int)max);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            latency = reader.ReadUShort();
            sampleCount = reader.ReadVarUhShort();
            max = reader.ReadVarUhShort();
        }
        
    }
    
}