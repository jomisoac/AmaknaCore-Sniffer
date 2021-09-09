

// Generated on 09/08/2021 14:21:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CurrentMapMessage : NetworkMessage
    {
        public const uint Id = 3437;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        public string mapKey;
        
        public CurrentMapMessage()
        {
        }
        
        public CurrentMapMessage(double mapId, string mapKey)
        {
            this.mapId = mapId;
            this.mapKey = mapKey;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mapId);
            writer.WriteUTF(mapKey);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapId = reader.ReadDouble();
            mapKey = reader.ReadUTF();
        }
        
    }
    
}