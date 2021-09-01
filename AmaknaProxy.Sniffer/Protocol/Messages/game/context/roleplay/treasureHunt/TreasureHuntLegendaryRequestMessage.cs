

// Generated on 09/01/2021 10:11:56
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TreasureHuntLegendaryRequestMessage : NetworkMessage
    {
        public const uint Id = 7019;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint legendaryId;
        
        public TreasureHuntLegendaryRequestMessage()
        {
        }
        
        public TreasureHuntLegendaryRequestMessage(uint legendaryId)
        {
            this.legendaryId = legendaryId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)legendaryId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            legendaryId = reader.ReadVarUhShort();
        }
        
    }
    
}