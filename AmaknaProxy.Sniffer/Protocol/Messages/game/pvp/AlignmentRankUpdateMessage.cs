

// Generated on 08/19/2021 23:34:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlignmentRankUpdateMessage : NetworkMessage
    {
        public const uint Id = 1286;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte alignmentRank;
        public bool verbose;
        
        public AlignmentRankUpdateMessage()
        {
        }
        
        public AlignmentRankUpdateMessage(sbyte alignmentRank, bool verbose)
        {
            this.alignmentRank = alignmentRank;
            this.verbose = verbose;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(alignmentRank);
            writer.WriteBoolean(verbose);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            alignmentRank = reader.ReadSbyte();
            verbose = reader.ReadBoolean();
        }
        
    }
    
}