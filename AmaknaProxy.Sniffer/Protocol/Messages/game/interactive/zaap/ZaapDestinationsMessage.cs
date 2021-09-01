

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ZaapDestinationsMessage : TeleportDestinationsMessage
    {
        public const uint Id = 1847;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double spawnMapId;
        
        public ZaapDestinationsMessage()
        {
        }
        
        public ZaapDestinationsMessage(sbyte type, Types.TeleportDestination[] destinations, double spawnMapId)
         : base(type, destinations)
        {
            this.spawnMapId = spawnMapId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(spawnMapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            spawnMapId = reader.ReadDouble();
        }
        
    }
    
}