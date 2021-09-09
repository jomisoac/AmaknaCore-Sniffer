

// Generated on 09/08/2021 14:22:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StorageKamasUpdateMessage : NetworkMessage
    {
        public const uint Id = 1383;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double kamasTotal;
        
        public StorageKamasUpdateMessage()
        {
        }
        
        public StorageKamasUpdateMessage(double kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(kamasTotal);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            kamasTotal = reader.ReadVarUhLong();
        }
        
    }
    
}