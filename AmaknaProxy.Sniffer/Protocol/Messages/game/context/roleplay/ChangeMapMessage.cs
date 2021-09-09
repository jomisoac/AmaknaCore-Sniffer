

// Generated on 09/08/2021 14:21:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChangeMapMessage : NetworkMessage
    {
        public const uint Id = 6904;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        public bool autopilot;
        
        public ChangeMapMessage()
        {
        }
        
        public ChangeMapMessage(double mapId, bool autopilot)
        {
            this.mapId = mapId;
            this.autopilot = autopilot;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
            writer.WriteBoolean(autopilot);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
            autopilot = reader.ReadBoolean();
        }
        
    }
    
}