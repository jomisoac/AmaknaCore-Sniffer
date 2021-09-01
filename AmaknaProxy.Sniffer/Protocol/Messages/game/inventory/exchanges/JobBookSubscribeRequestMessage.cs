

// Generated on 09/01/2021 10:12:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class JobBookSubscribeRequestMessage : NetworkMessage
    {
        public const uint Id = 5290;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte[] jobIds;
        
        public JobBookSubscribeRequestMessage()
        {
        }
        
        public JobBookSubscribeRequestMessage(sbyte[] jobIds)
        {
            this.jobIds = jobIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)(ushort)jobIds.Length);
            foreach (var entry in jobIds)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadVarInt();
            jobIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobIds[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}