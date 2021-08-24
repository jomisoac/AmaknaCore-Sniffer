

// Generated on 08/19/2021 23:34:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobExperienceOtherPlayerUpdateMessage : JobExperienceUpdateMessage
    {
        public const uint Id = 4536;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double playerId;
        
        public JobExperienceOtherPlayerUpdateMessage()
        {
        }
        
        public JobExperienceOtherPlayerUpdateMessage(Types.JobExperience experiencesUpdate, double playerId)
         : base(experiencesUpdate)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}