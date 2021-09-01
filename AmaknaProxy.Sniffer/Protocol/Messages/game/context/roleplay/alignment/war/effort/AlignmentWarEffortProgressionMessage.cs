

// Generated on 09/01/2021 10:11:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AlignmentWarEffortProgressionMessage : NetworkMessage
    {
        public const uint Id = 8318;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.AlignmentWarEffortInformation[] effortProgressions;
        
        public AlignmentWarEffortProgressionMessage()
        {
        }
        
        public AlignmentWarEffortProgressionMessage(Types.AlignmentWarEffortInformation[] effortProgressions)
        {
            this.effortProgressions = effortProgressions;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)effortProgressions.Length);
            foreach (var entry in effortProgressions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            effortProgressions = new Types.AlignmentWarEffortInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 effortProgressions[i] = new Types.AlignmentWarEffortInformation();
                 effortProgressions[i].Deserialize(reader);
            }
        }
        
    }
    
}