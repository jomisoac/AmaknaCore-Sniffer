

// Generated on 09/08/2021 14:21:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChallengeTargetsListRequestMessage : NetworkMessage
    {
        public const uint Id = 1589;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint challengeId;
        
        public ChallengeTargetsListRequestMessage()
        {
        }
        
        public ChallengeTargetsListRequestMessage(uint challengeId)
        {
            this.challengeId = challengeId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)challengeId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            challengeId = reader.ReadVarUhShort();
        }
        
    }
    
}