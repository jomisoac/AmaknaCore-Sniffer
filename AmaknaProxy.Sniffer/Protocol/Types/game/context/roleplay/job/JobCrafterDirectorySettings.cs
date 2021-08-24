

// Generated on 08/19/2021 23:35:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class JobCrafterDirectorySettings
    {
        public const short Id = 7816;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte jobId;
        public byte minLevel;
        public bool free;
        
        public JobCrafterDirectorySettings()
        {
        }
        
        public JobCrafterDirectorySettings(sbyte jobId, byte minLevel, bool free)
        {
            this.jobId = jobId;
            this.minLevel = minLevel;
            this.free = free;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(jobId);
            writer.WriteByte(minLevel);
            writer.WriteBoolean(free);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            jobId = reader.ReadSbyte();
            minLevel = reader.ReadByte();
            free = reader.ReadBoolean();
        }
        
    }
    
}