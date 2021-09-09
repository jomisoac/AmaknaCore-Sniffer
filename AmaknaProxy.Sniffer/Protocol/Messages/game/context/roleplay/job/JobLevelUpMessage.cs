

// Generated on 09/08/2021 14:21:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobLevelUpMessage : NetworkMessage
    {
        public const uint Id = 5198;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public byte newLevel;
        public Types.JobDescription jobsDescription;
        
        public JobLevelUpMessage()
        {
        }
        
        public JobLevelUpMessage(byte newLevel, Types.JobDescription jobsDescription)
        {
            this.newLevel = newLevel;
            this.jobsDescription = jobsDescription;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(newLevel);
            jobsDescription.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            newLevel = reader.ReadByte();
            jobsDescription = new Types.JobDescription();
            jobsDescription.Deserialize(reader);
        }
        
    }
    
}