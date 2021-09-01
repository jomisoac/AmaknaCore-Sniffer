

// Generated on 09/01/2021 10:11:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChallengeTargetUpdateMessage : NetworkMessage
    {
        public const uint Id = 8121;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint challengeId;
        public double targetId;
        
        public ChallengeTargetUpdateMessage()
        {
        }
        
        public ChallengeTargetUpdateMessage(uint challengeId, double targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
        }
        
    }
    
}