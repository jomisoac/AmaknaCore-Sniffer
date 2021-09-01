

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportDestinationsMessage : NetworkMessage
    {
        public const uint Id = 2128;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte type;
        public Types.TeleportDestination[] destinations;
        
        public TeleportDestinationsMessage()
        {
        }
        
        public TeleportDestinationsMessage(sbyte type, Types.TeleportDestination[] destinations)
        {
            this.type = type;
            this.destinations = destinations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(type);
            writer.WriteShort((short)destinations.Length);
            foreach (var entry in destinations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            type = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            destinations = new Types.TeleportDestination[limit];
            for (int i = 0; i < limit; i++)
            {
                 destinations[i] = new Types.TeleportDestination();
                 destinations[i].Deserialize(reader);
            }
        }
        
    }
    
}