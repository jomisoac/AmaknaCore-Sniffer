

// Generated on 09/01/2021 10:11:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightNewRoundMessage : NetworkMessage
    {
        public const uint Id = 1563;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint roundNumber;
        
        public GameFightNewRoundMessage()
        {
        }
        
        public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)roundNumber);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            roundNumber = reader.ReadVarUhInt();
        }
        
    }
    
}