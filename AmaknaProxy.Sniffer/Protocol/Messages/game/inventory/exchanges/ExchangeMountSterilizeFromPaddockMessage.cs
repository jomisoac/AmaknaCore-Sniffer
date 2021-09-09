

// Generated on 09/08/2021 14:22:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeMountSterilizeFromPaddockMessage : NetworkMessage
    {
        public const uint Id = 2391;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string name;
        public short worldX;
        public short worldY;
        public string sterilizator;
        
        public ExchangeMountSterilizeFromPaddockMessage()
        {
        }
        
        public ExchangeMountSterilizeFromPaddockMessage(string name, short worldX, short worldY, string sterilizator)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.sterilizator = sterilizator;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteUTF(sterilizator);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            name = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            sterilizator = reader.ReadUTF();
        }
        
    }
    
}