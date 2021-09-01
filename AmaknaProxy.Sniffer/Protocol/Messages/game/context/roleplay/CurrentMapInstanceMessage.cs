

// Generated on 09/01/2021 10:11:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CurrentMapInstanceMessage : CurrentMapMessage
    {
        public const uint Id = 5592;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double instantiatedMapId;
        
        public CurrentMapInstanceMessage()
        {
        }
        
        public CurrentMapInstanceMessage(double mapId, string mapKey, double instantiatedMapId)
         : base(mapId, mapKey)
        {
            this.instantiatedMapId = instantiatedMapId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(instantiatedMapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            instantiatedMapId = reader.ReadDouble();
        }
        
    }
    
}